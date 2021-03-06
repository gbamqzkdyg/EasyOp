using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EasyOp
{
    internal partial class AuxOpForm : Form
    {
        public AuxOpForm()
        {
            InitializeComponent();
            UpdateWholeView();
        }

        private Macro CurrentMacro { get => macroListBox.SelectedItem as Macro; }

        private string CurrentOperationName { get => this.operationDgv.SelectedRows[0].Cells[0].Value as string; }

        private void LoadMacroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                InitialDirectory = Application.ExecutablePath
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                AuxOp.LoadMacrosFromFile(ofd.FileName);
                this.UpdateWholeView();
            }
        }

        private void UpdateMacroListBox()
        {
            macroListBox.Items.Clear();
            if (AuxOp.Macros == null) return;
            foreach (var macro in AuxOp.Macros.MacroTable.Values)
            {
                macroListBox.Items.Add(macro);
            }
        }

        private void UpdateButtons()
        {
            execMacroButton.Enabled = macroListBox.SelectedItem != null;
            deleteMacroButton.Enabled = execMacroButton.Enabled;
            execOperationButton.Enabled = operationDgv.DataSource != null && (operationDgv.DataSource as List<Operation>).Count > 0;
            deleteOperationButton.Enabled = execOperationButton.Enabled;
            AddOperationButton.Enabled = execMacroButton.Enabled;
        }

        private void UpdateWholeView()
        {
            this.UpdateMacroListBox();
            this.UpdateButtons();
        }

        private void UpdateOperationDgv()
        {
            if (CurrentMacro == null) return;
            this.operationDgv.DataSource = null;
            this.operationDgv.DataSource = CurrentMacro.Ops;
        }

        private void ExecMacroButton_Click(object sender, EventArgs e)
        {
            CurrentMacro.Perform();
        }

        private void DeleteMacroButton_Click(object sender, EventArgs e)
        {
            AuxOp.Macros.DeleteMacro(CurrentMacro.Name);
            this.UpdateWholeView();
        }

        private void SaveMacroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                InitialDirectory = Application.ExecutablePath
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                AuxOp.SaveMacrosToFile(sfd.FileName);
                this.UpdateWholeView();
            }
        }

        private void AddMacroButton_Click(object sender, EventArgs e)
        {
            new AddMacroDialog().ShowDialog();
            this.UpdateWholeView();
        }

        private void MacroListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.UpdateOperationDgv();
            this.UpdateButtons();
        }

        private void AddOperationButton_Click(object sender, EventArgs e)
        {
            new AddOperationDialog(operationDgv, CurrentMacro.Name).ShowDialog();
        }

        private void DeleteOperationButton_Click(object sender, EventArgs e)
        {
            DeleteFromDgv(operationDgv.CurrentRow.Index);
            this.UpdateWholeView();
        }

        private void ExecOperationButton_Click(object sender, EventArgs e)
        {
            CurrentMacro.GetOperation(CurrentOperationName).Perform();
        }

        private void DeleteFromDgv(int index)
        {
            IList<Operation> list = operationDgv.DataSource as IList<Operation>;
            list.RemoveAt(index);
            operationDgv.DataSource = null;
            operationDgv.DataSource = list;
        }
    }
}
