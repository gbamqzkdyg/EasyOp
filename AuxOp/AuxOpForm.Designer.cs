
namespace EasyOp
{
    partial class AuxOpForm
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
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadMacroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMacroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.addMacroButton = new System.Windows.Forms.Button();
            this.deleteMacroButton = new System.Windows.Forms.Button();
            this.execMacroButton = new System.Windows.Forms.Button();
            this.macroListBox = new System.Windows.Forms.ListBox();
            this.operationDgv = new System.Windows.Forms.DataGridView();
            this.AddOperationButton = new System.Windows.Forms.Button();
            this.deleteOperationButton = new System.Windows.Forms.Button();
            this.execOperationButton = new System.Windows.Forms.Button();
            this.mainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.operationDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(968, 28);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadMacroToolStripMenuItem,
            this.saveMacroToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.FileToolStripMenuItem.Text = "文件";
            // 
            // loadMacroToolStripMenuItem
            // 
            this.loadMacroToolStripMenuItem.Name = "loadMacroToolStripMenuItem";
            this.loadMacroToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.loadMacroToolStripMenuItem.Text = "读取宏";
            this.loadMacroToolStripMenuItem.Click += new System.EventHandler(this.LoadMacroToolStripMenuItem_Click);
            // 
            // saveMacroToolStripMenuItem
            // 
            this.saveMacroToolStripMenuItem.Name = "saveMacroToolStripMenuItem";
            this.saveMacroToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.saveMacroToolStripMenuItem.Text = "保存宏";
            this.saveMacroToolStripMenuItem.Click += new System.EventHandler(this.SaveMacroToolStripMenuItem_Click);
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 28);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.addMacroButton);
            this.splitContainer.Panel1.Controls.Add(this.deleteMacroButton);
            this.splitContainer.Panel1.Controls.Add(this.execMacroButton);
            this.splitContainer.Panel1.Controls.Add(this.macroListBox);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.operationDgv);
            this.splitContainer.Panel2.Controls.Add(this.AddOperationButton);
            this.splitContainer.Panel2.Controls.Add(this.deleteOperationButton);
            this.splitContainer.Panel2.Controls.Add(this.execOperationButton);
            this.splitContainer.Size = new System.Drawing.Size(968, 497);
            this.splitContainer.SplitterDistance = 243;
            this.splitContainer.TabIndex = 1;
            // 
            // addMacroButton
            // 
            this.addMacroButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addMacroButton.Location = new System.Drawing.Point(0, 386);
            this.addMacroButton.Name = "addMacroButton";
            this.addMacroButton.Size = new System.Drawing.Size(243, 37);
            this.addMacroButton.TabIndex = 3;
            this.addMacroButton.Text = "添加宏";
            this.addMacroButton.UseVisualStyleBackColor = true;
            this.addMacroButton.Click += new System.EventHandler(this.AddMacroButton_Click);
            // 
            // deleteMacroButton
            // 
            this.deleteMacroButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.deleteMacroButton.Enabled = false;
            this.deleteMacroButton.Location = new System.Drawing.Point(0, 423);
            this.deleteMacroButton.Name = "deleteMacroButton";
            this.deleteMacroButton.Size = new System.Drawing.Size(243, 37);
            this.deleteMacroButton.TabIndex = 2;
            this.deleteMacroButton.Text = "删除选中宏";
            this.deleteMacroButton.UseVisualStyleBackColor = true;
            this.deleteMacroButton.Click += new System.EventHandler(this.DeleteMacroButton_Click);
            // 
            // execMacroButton
            // 
            this.execMacroButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.execMacroButton.Enabled = false;
            this.execMacroButton.Location = new System.Drawing.Point(0, 460);
            this.execMacroButton.Name = "execMacroButton";
            this.execMacroButton.Size = new System.Drawing.Size(243, 37);
            this.execMacroButton.TabIndex = 1;
            this.execMacroButton.Text = "执行选中宏";
            this.execMacroButton.UseVisualStyleBackColor = true;
            this.execMacroButton.Click += new System.EventHandler(this.ExecMacroButton_Click);
            // 
            // macroListBox
            // 
            this.macroListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.macroListBox.FormattingEnabled = true;
            this.macroListBox.ItemHeight = 15;
            this.macroListBox.Location = new System.Drawing.Point(0, 0);
            this.macroListBox.Name = "macroListBox";
            this.macroListBox.Size = new System.Drawing.Size(243, 497);
            this.macroListBox.Sorted = true;
            this.macroListBox.TabIndex = 0;
            this.macroListBox.SelectedIndexChanged += new System.EventHandler(this.MacroListBox_SelectedIndexChanged);
            // 
            // operationDgv
            // 
            this.operationDgv.AllowUserToAddRows = false;
            this.operationDgv.AllowUserToDeleteRows = false;
            this.operationDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.operationDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.operationDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.operationDgv.Location = new System.Drawing.Point(0, 0);
            this.operationDgv.MultiSelect = false;
            this.operationDgv.Name = "operationDgv";
            this.operationDgv.ReadOnly = true;
            this.operationDgv.RowHeadersVisible = false;
            this.operationDgv.RowHeadersWidth = 51;
            this.operationDgv.RowTemplate.Height = 27;
            this.operationDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.operationDgv.Size = new System.Drawing.Size(721, 388);
            this.operationDgv.TabIndex = 5;
            // 
            // AddOperationButton
            // 
            this.AddOperationButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddOperationButton.Location = new System.Drawing.Point(0, 386);
            this.AddOperationButton.Name = "AddOperationButton";
            this.AddOperationButton.Size = new System.Drawing.Size(721, 37);
            this.AddOperationButton.TabIndex = 4;
            this.AddOperationButton.Text = "添加操作";
            this.AddOperationButton.UseVisualStyleBackColor = true;
            this.AddOperationButton.Click += new System.EventHandler(this.AddOperationButton_Click);
            // 
            // deleteOperationButton
            // 
            this.deleteOperationButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.deleteOperationButton.Enabled = false;
            this.deleteOperationButton.Location = new System.Drawing.Point(0, 423);
            this.deleteOperationButton.Name = "deleteOperationButton";
            this.deleteOperationButton.Size = new System.Drawing.Size(721, 37);
            this.deleteOperationButton.TabIndex = 3;
            this.deleteOperationButton.Text = "删除选中操作";
            this.deleteOperationButton.UseVisualStyleBackColor = true;
            this.deleteOperationButton.Click += new System.EventHandler(this.DeleteOperationButton_Click);
            // 
            // execOperationButton
            // 
            this.execOperationButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.execOperationButton.Enabled = false;
            this.execOperationButton.Location = new System.Drawing.Point(0, 460);
            this.execOperationButton.Name = "execOperationButton";
            this.execOperationButton.Size = new System.Drawing.Size(721, 37);
            this.execOperationButton.TabIndex = 2;
            this.execOperationButton.Text = "执行选中操作";
            this.execOperationButton.UseVisualStyleBackColor = true;
            this.execOperationButton.Click += new System.EventHandler(this.ExecOperationButton_Click);
            // 
            // AuxOpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 525);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "AuxOpForm";
            this.ShowIcon = false;
            this.Text = "AuxOp";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.operationDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadMacroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMacroToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.ListBox macroListBox;
        private System.Windows.Forms.Button addMacroButton;
        private System.Windows.Forms.Button deleteMacroButton;
        private System.Windows.Forms.Button execMacroButton;
        private System.Windows.Forms.Button AddOperationButton;
        private System.Windows.Forms.Button deleteOperationButton;
        private System.Windows.Forms.Button execOperationButton;
        private System.Windows.Forms.DataGridView operationDgv;
    }
}