
namespace EasyOp
{
    partial class AddOperationDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.controlGroupBox = new System.Windows.Forms.GroupBox();
            this.controlListBox = new System.Windows.Forms.ListBox();
            this.oprandGroupBox = new System.Windows.Forms.GroupBox();
            this.oprandListBox = new System.Windows.Forms.ListBox();
            this.panel = new System.Windows.Forms.Panel();
            this.confirmButton = new System.Windows.Forms.Button();
            this.waitTimegroupBox = new System.Windows.Forms.GroupBox();
            this.waitingTimeTextBox = new System.Windows.Forms.TextBox();
            this.nameGroupBox = new System.Windows.Forms.GroupBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.objectsGroupBox = new System.Windows.Forms.GroupBox();
            this.objectsTextBox = new System.Windows.Forms.TextBox();
            this.controlGroupBox.SuspendLayout();
            this.oprandGroupBox.SuspendLayout();
            this.panel.SuspendLayout();
            this.waitTimegroupBox.SuspendLayout();
            this.nameGroupBox.SuspendLayout();
            this.objectsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlGroupBox
            // 
            this.controlGroupBox.Controls.Add(this.controlListBox);
            this.controlGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.controlGroupBox.Location = new System.Drawing.Point(0, 0);
            this.controlGroupBox.Name = "controlGroupBox";
            this.controlGroupBox.Size = new System.Drawing.Size(200, 449);
            this.controlGroupBox.TabIndex = 0;
            this.controlGroupBox.TabStop = false;
            this.controlGroupBox.Text = "要操作的控件";
            // 
            // controlListBox
            // 
            this.controlListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlListBox.FormattingEnabled = true;
            this.controlListBox.ItemHeight = 15;
            this.controlListBox.Location = new System.Drawing.Point(3, 21);
            this.controlListBox.Name = "controlListBox";
            this.controlListBox.Size = new System.Drawing.Size(194, 425);
            this.controlListBox.TabIndex = 0;
            this.controlListBox.SelectedValueChanged += new System.EventHandler(this.ControlListBox_SelectedValueChanged);
            // 
            // oprandGroupBox
            // 
            this.oprandGroupBox.Controls.Add(this.oprandListBox);
            this.oprandGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.oprandGroupBox.Location = new System.Drawing.Point(200, 0);
            this.oprandGroupBox.Name = "oprandGroupBox";
            this.oprandGroupBox.Size = new System.Drawing.Size(200, 449);
            this.oprandGroupBox.TabIndex = 1;
            this.oprandGroupBox.TabStop = false;
            this.oprandGroupBox.Text = "操作类型";
            // 
            // oprandListBox
            // 
            this.oprandListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oprandListBox.FormattingEnabled = true;
            this.oprandListBox.ItemHeight = 15;
            this.oprandListBox.Location = new System.Drawing.Point(3, 21);
            this.oprandListBox.Name = "oprandListBox";
            this.oprandListBox.Size = new System.Drawing.Size(194, 425);
            this.oprandListBox.TabIndex = 0;
            this.oprandListBox.SelectedValueChanged += new System.EventHandler(this.OprandListBox_SelectedValueChanged);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.objectsGroupBox);
            this.panel.Controls.Add(this.confirmButton);
            this.panel.Controls.Add(this.waitTimegroupBox);
            this.panel.Controls.Add(this.nameGroupBox);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(400, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(270, 449);
            this.panel.TabIndex = 2;
            // 
            // confirmButton
            // 
            this.confirmButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.confirmButton.Location = new System.Drawing.Point(72, 353);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(127, 47);
            this.confirmButton.TabIndex = 4;
            this.confirmButton.Text = "确定";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // waitTimegroupBox
            // 
            this.waitTimegroupBox.Controls.Add(this.waitingTimeTextBox);
            this.waitTimegroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.waitTimegroupBox.Location = new System.Drawing.Point(0, 100);
            this.waitTimegroupBox.Name = "waitTimegroupBox";
            this.waitTimegroupBox.Size = new System.Drawing.Size(270, 100);
            this.waitTimegroupBox.TabIndex = 3;
            this.waitTimegroupBox.TabStop = false;
            this.waitTimegroupBox.Text = "等待时间（ms）";
            // 
            // waitingTimeTextBox
            // 
            this.waitingTimeTextBox.Location = new System.Drawing.Point(0, 39);
            this.waitingTimeTextBox.Name = "waitingTimeTextBox";
            this.waitingTimeTextBox.Size = new System.Drawing.Size(264, 25);
            this.waitingTimeTextBox.TabIndex = 1;
            this.waitingTimeTextBox.TextChanged += new System.EventHandler(this.WaitingTimeTextBox_TextChanged);
            // 
            // nameGroupBox
            // 
            this.nameGroupBox.Controls.Add(this.nameTextBox);
            this.nameGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.nameGroupBox.Location = new System.Drawing.Point(0, 0);
            this.nameGroupBox.Name = "nameGroupBox";
            this.nameGroupBox.Size = new System.Drawing.Size(270, 100);
            this.nameGroupBox.TabIndex = 2;
            this.nameGroupBox.TabStop = false;
            this.nameGroupBox.Text = "操作名称";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(0, 41);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(264, 25);
            this.nameTextBox.TabIndex = 0;
            this.nameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // objectsGroupBox
            // 
            this.objectsGroupBox.Controls.Add(this.objectsTextBox);
            this.objectsGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.objectsGroupBox.Location = new System.Drawing.Point(0, 200);
            this.objectsGroupBox.Name = "objectsGroupBox";
            this.objectsGroupBox.Size = new System.Drawing.Size(270, 100);
            this.objectsGroupBox.TabIndex = 5;
            this.objectsGroupBox.TabStop = false;
            this.objectsGroupBox.Text = "其他参数";
            // 
            // objectsTextBox
            // 
            this.objectsTextBox.Location = new System.Drawing.Point(0, 44);
            this.objectsTextBox.Name = "objectsTextBox";
            this.objectsTextBox.Size = new System.Drawing.Size(264, 25);
            this.objectsTextBox.TabIndex = 2;
            // 
            // AddOperationDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(670, 449);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.oprandGroupBox);
            this.Controls.Add(this.controlGroupBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddOperationDialog";
            this.ShowIcon = false;
            this.controlGroupBox.ResumeLayout(false);
            this.oprandGroupBox.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.waitTimegroupBox.ResumeLayout(false);
            this.waitTimegroupBox.PerformLayout();
            this.nameGroupBox.ResumeLayout(false);
            this.nameGroupBox.PerformLayout();
            this.objectsGroupBox.ResumeLayout(false);
            this.objectsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox controlGroupBox;
        private System.Windows.Forms.ListBox controlListBox;
        private System.Windows.Forms.GroupBox oprandGroupBox;
        private System.Windows.Forms.ListBox oprandListBox;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.GroupBox waitTimegroupBox;
        private System.Windows.Forms.GroupBox nameGroupBox;
        private System.Windows.Forms.TextBox waitingTimeTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.GroupBox objectsGroupBox;
        private System.Windows.Forms.TextBox objectsTextBox;
    }
}