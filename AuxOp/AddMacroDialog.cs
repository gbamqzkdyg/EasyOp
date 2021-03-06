using System;
using System.Windows.Forms;

namespace EasyOp
{
    public partial class AddMacroDialog : Form
    {
        public AddMacroDialog()
        {
            InitializeComponent();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                AuxOp.Macros.CreateMacro(this.textBox.Text);
            }
            catch
            {
                MessageBox.Show("创建宏失败！");
            }
            this.Close();
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            this.confirmButton.Enabled = textBox.Text.Length > 0 && AuxOp.Macros.MacroTable.ContainsKey(textBox.Text);
        }
    }
}
