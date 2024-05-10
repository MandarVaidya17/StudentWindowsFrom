namespace StudentWindowsFrom
{
    partial class MDI
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
            this.menuStrip4 = new System.Windows.Forms.MenuStrip();
            this.connectedFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectedFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip4
            // 
            this.menuStrip4.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip4.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectedFormToolStripMenuItem,
            this.disconnectedFormToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip4.Location = new System.Drawing.Point(0, 0);
            this.menuStrip4.Name = "menuStrip4";
            this.menuStrip4.Size = new System.Drawing.Size(800, 36);
            this.menuStrip4.TabIndex = 4;
            this.menuStrip4.Text = "menuStrip4";
            // 
            // connectedFormToolStripMenuItem
            // 
            this.connectedFormToolStripMenuItem.Name = "connectedFormToolStripMenuItem";
            this.connectedFormToolStripMenuItem.Size = new System.Drawing.Size(157, 32);
            this.connectedFormToolStripMenuItem.Text = "connected Form";
            this.connectedFormToolStripMenuItem.Click += new System.EventHandler(this.connectedFormToolStripMenuItem_Click);
            // 
            // disconnectedFormToolStripMenuItem
            // 
            this.disconnectedFormToolStripMenuItem.Name = "disconnectedFormToolStripMenuItem";
            this.disconnectedFormToolStripMenuItem.Size = new System.Drawing.Size(179, 32);
            this.disconnectedFormToolStripMenuItem.Text = "Disconnected form";
            this.disconnectedFormToolStripMenuItem.Click += new System.EventHandler(this.disconnectedFormToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(55, 32);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip4);
            this.IsMdiContainer = true;
            this.Name = "MDI";
            this.Text = "MDI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip4.ResumeLayout(false);
            this.menuStrip4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip4;
        private System.Windows.Forms.ToolStripMenuItem connectedFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectedFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}