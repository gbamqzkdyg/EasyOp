using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EasyOp
{
    public partial class AddOperationDialog : Form
    {
        private string CurrentControlName { get => controlListBox.SelectedItem as string; }
        private readonly string macroName;
        private readonly DataGridView operationDgv;
        private int waitingTime;

        public AddOperationDialog(DataGridView operationDgv, string macroName)
        {
            InitializeComponent();
            this.operationDgv = operationDgv;
            this.macroName = macroName;
            this.Text = $"向{ macroName }添加操作";
            this.waitingTimeTextBox.Text = Operations.defaultWaitTime.ToString();
            UpdateWholeView();
        }

        private void UpdateWholeView()
        {
            UpdateControlListBox();
        }

        private void UpdateControlListBox()
        {
            controlListBox.Items.Clear();
            foreach (var name in AuxOp.ControlsManager.Controls.Keys) controlListBox.Items.Add(name);
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            waitingTime = int.Parse(waitingTimeTextBox.Text);
            this.AddToDgv(new Operation(this.nameTextBox.Text, CurrentControlName,
                new object[] { objectsTextBox.Text }, (Oprands)oprandListBox.SelectedItem, waitingTime));
            this.Close();
        }

        private void UpdateOprandListBox()
        {
            oprandListBox.Items.Clear();
            foreach(var op in Operations.GetOps(AuxOp.ControlsManager.Controls[CurrentControlName].GetType()))
            {
                oprandListBox.Items.Add(op);
            }
        }

        private void ControlListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (controlListBox.SelectedItem == null) return;
            UpdateOprandListBox();
            this.confirmButton.Enabled = ValidateInput();
        }

        private bool ValidateInput()
        {
            return 
                controlListBox.SelectedItem != null &&
                oprandListBox.SelectedItem != null &&
                nameTextBox.Text != null &&
                nameTextBox.Text.Length > 0 &&
                !AuxOp.Macros[this.macroName].OpNames.Contains(nameTextBox.Text) &&
                waitingTimeTextBox.Text != null &&
                waitingTimeTextBox.Text.Length > 0 &&
                int.TryParse(waitingTimeTextBox.Text, out waitingTime) &&
                waitingTime > 0;
        }

        private void WaitingTimeTextBox_TextChanged(object sender, EventArgs e)
        {
            confirmButton.Enabled = ValidateInput();
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            confirmButton.Enabled = ValidateInput();
        }

        private void AddToDgv(Operation operation)
        {
            IList<Operation> list = operationDgv.DataSource as IList<Operation>;
            list.Add(operation);
            operationDgv.DataSource = null;
            operationDgv.DataSource = list;
        }

        private void OprandListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            ValidateInput();
        }
    }
}
