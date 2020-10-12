namespace Mouse_Auto_Scroll
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.txtScrollPerSecond = new System.Windows.Forms.TextBox();
            this.lblScrollPerSecond = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tmrMouseScrollTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbxCurrentProcesses = new System.Windows.Forms.ComboBox();
            this.lblProcesses = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtScrollPerSecond
            // 
            this.txtScrollPerSecond.Location = new System.Drawing.Point(12, 56);
            this.txtScrollPerSecond.Name = "txtScrollPerSecond";
            this.txtScrollPerSecond.Size = new System.Drawing.Size(80, 20);
            this.txtScrollPerSecond.TabIndex = 0;
            // 
            // lblScrollPerSecond
            // 
            this.lblScrollPerSecond.AutoSize = true;
            this.lblScrollPerSecond.Location = new System.Drawing.Point(12, 37);
            this.lblScrollPerSecond.Name = "lblScrollPerSecond";
            this.lblScrollPerSecond.Size = new System.Drawing.Size(92, 13);
            this.lblScrollPerSecond.TabIndex = 1;
            this.lblScrollPerSecond.Text = "Scroll Per Second";
            this.toolTip1.SetToolTip(this.lblScrollPerSecond, "How fast do you want the mouse to scroll per second");
            // 
            // tmrMouseScrollTimer
            // 
            this.tmrMouseScrollTimer.Tick += new System.EventHandler(this.tmrMouseScrollTimer_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(247, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // cmbxCurrentProcesses
            // 
            this.cmbxCurrentProcesses.FormattingEnabled = true;
            this.cmbxCurrentProcesses.Location = new System.Drawing.Point(12, 109);
            this.cmbxCurrentProcesses.Name = "cmbxCurrentProcesses";
            this.cmbxCurrentProcesses.Size = new System.Drawing.Size(223, 21);
            this.cmbxCurrentProcesses.TabIndex = 3;
            // 
            // lblProcesses
            // 
            this.lblProcesses.AutoSize = true;
            this.lblProcesses.Location = new System.Drawing.Point(12, 93);
            this.lblProcesses.Name = "lblProcesses";
            this.lblProcesses.Size = new System.Drawing.Size(93, 13);
            this.lblProcesses.TabIndex = 4;
            this.lblProcesses.Text = "Current Processes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 217);
            this.Controls.Add(this.lblProcesses);
            this.Controls.Add(this.cmbxCurrentProcesses);
            this.Controls.Add(this.lblScrollPerSecond);
            this.Controls.Add(this.txtScrollPerSecond);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Auto Mouse Scroller";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtScrollPerSecond;
        private System.Windows.Forms.Label lblScrollPerSecond;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer tmrMouseScrollTimer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbxCurrentProcesses;
        private System.Windows.Forms.Label lblProcesses;
    }
}

