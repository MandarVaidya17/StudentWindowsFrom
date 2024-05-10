namespace StudentWindowsFrom
{
    partial class Form3
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.Btncancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Password";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(34, 31);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(89, 20);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "User Name";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(174, 25);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(230, 26);
            this.txtusername.TabIndex = 9;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(174, 73);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(230, 26);
            this.txtPass.TabIndex = 8;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(51, 160);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 39);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Btncancel
            // 
            this.Btncancel.Location = new System.Drawing.Point(174, 160);
            this.Btncancel.Name = "Btncancel";
            this.Btncancel.Size = new System.Drawing.Size(75, 39);
            this.Btncancel.TabIndex = 6;
            this.Btncancel.Text = "Cancel";
            this.Btncancel.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 279);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.Btncancel);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button Btncancel;
    }
}