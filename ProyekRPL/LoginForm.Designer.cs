namespace ProyekRPL
{
    partial class LoginForm
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
            this.UserLogo = new System.Windows.Forms.Label();
            this.UsernameTxt = new System.Windows.Forms.TextBox();
            this.UsernameTxtMargin = new System.Windows.Forms.Panel();
            this.PanelUsername = new System.Windows.Forms.Panel();
            this.UsernameClearBtn = new System.Windows.Forms.Button();
            this.PanelPassword = new System.Windows.Forms.Panel();
            this.PasswordClearBtn = new System.Windows.Forms.Button();
            this.PasswordLogo = new System.Windows.Forms.Label();
            this.PasswordTxtMargin = new System.Windows.Forms.Panel();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.UserLevel = new System.Windows.Forms.ComboBox();
            this.LoginBtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.UsernameTxtMargin.SuspendLayout();
            this.PanelUsername.SuspendLayout();
            this.PanelPassword.SuspendLayout();
            this.PasswordTxtMargin.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserLogo
            // 
            this.UserLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.UserLogo.Font = new System.Drawing.Font("Hack NF", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLogo.Location = new System.Drawing.Point(0, 0);
            this.UserLogo.Name = "UserLogo";
            this.UserLogo.Size = new System.Drawing.Size(33, 33);
            this.UserLogo.TabIndex = 3;
            this.UserLogo.Text = "";
            this.UserLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UsernameTxt
            // 
            this.UsernameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsernameTxt.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTxt.Location = new System.Drawing.Point(3, 3);
            this.UsernameTxt.Name = "UsernameTxt";
            this.UsernameTxt.Size = new System.Drawing.Size(220, 23);
            this.UsernameTxt.TabIndex = 4;
            // 
            // UsernameTxtMargin
            // 
            this.UsernameTxtMargin.BackColor = System.Drawing.Color.White;
            this.UsernameTxtMargin.Controls.Add(this.UsernameTxt);
            this.UsernameTxtMargin.Location = new System.Drawing.Point(36, 0);
            this.UsernameTxtMargin.Name = "UsernameTxtMargin";
            this.UsernameTxtMargin.Size = new System.Drawing.Size(226, 33);
            this.UsernameTxtMargin.TabIndex = 5;
            // 
            // PanelUsername
            // 
            this.PanelUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelUsername.Controls.Add(this.UsernameClearBtn);
            this.PanelUsername.Controls.Add(this.UserLogo);
            this.PanelUsername.Controls.Add(this.UsernameTxtMargin);
            this.PanelUsername.Location = new System.Drawing.Point(23, 76);
            this.PanelUsername.Name = "PanelUsername";
            this.PanelUsername.Size = new System.Drawing.Size(296, 33);
            this.PanelUsername.TabIndex = 6;
            // 
            // UsernameClearBtn
            // 
            this.UsernameClearBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameClearBtn.Location = new System.Drawing.Point(263, -1);
            this.UsernameClearBtn.Name = "UsernameClearBtn";
            this.UsernameClearBtn.Size = new System.Drawing.Size(33, 33);
            this.UsernameClearBtn.TabIndex = 7;
            this.UsernameClearBtn.TabStop = false;
            this.UsernameClearBtn.Text = "X";
            this.UsernameClearBtn.UseVisualStyleBackColor = true;
            this.UsernameClearBtn.Click += new System.EventHandler(this.UsernameClearBtn_Click);
            // 
            // PanelPassword
            // 
            this.PanelPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelPassword.Controls.Add(this.PasswordClearBtn);
            this.PanelPassword.Controls.Add(this.PasswordLogo);
            this.PanelPassword.Controls.Add(this.PasswordTxtMargin);
            this.PanelPassword.Location = new System.Drawing.Point(23, 120);
            this.PanelPassword.Name = "PanelPassword";
            this.PanelPassword.Size = new System.Drawing.Size(296, 33);
            this.PanelPassword.TabIndex = 8;
            // 
            // PasswordClearBtn
            // 
            this.PasswordClearBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordClearBtn.Location = new System.Drawing.Point(263, -1);
            this.PasswordClearBtn.Name = "PasswordClearBtn";
            this.PasswordClearBtn.Size = new System.Drawing.Size(33, 33);
            this.PasswordClearBtn.TabIndex = 7;
            this.PasswordClearBtn.TabStop = false;
            this.PasswordClearBtn.Text = "X";
            this.PasswordClearBtn.UseVisualStyleBackColor = true;
            this.PasswordClearBtn.Click += new System.EventHandler(this.PasswordClearBtn_Click);
            // 
            // PasswordLogo
            // 
            this.PasswordLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PasswordLogo.Font = new System.Drawing.Font("Hack NF", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLogo.Location = new System.Drawing.Point(0, 0);
            this.PasswordLogo.Name = "PasswordLogo";
            this.PasswordLogo.Size = new System.Drawing.Size(33, 33);
            this.PasswordLogo.TabIndex = 3;
            this.PasswordLogo.Text = "";
            this.PasswordLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PasswordLogo.Click += new System.EventHandler(this.PasswordLogo_Click);
            // 
            // PasswordTxtMargin
            // 
            this.PasswordTxtMargin.BackColor = System.Drawing.Color.White;
            this.PasswordTxtMargin.Controls.Add(this.PasswordTxt);
            this.PasswordTxtMargin.Location = new System.Drawing.Point(36, 0);
            this.PasswordTxtMargin.Name = "PasswordTxtMargin";
            this.PasswordTxtMargin.Size = new System.Drawing.Size(226, 33);
            this.PasswordTxtMargin.TabIndex = 5;
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTxt.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTxt.Location = new System.Drawing.Point(3, 3);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.PasswordChar = '*';
            this.PasswordTxt.Size = new System.Drawing.Size(220, 23);
            this.PasswordTxt.TabIndex = 4;
            // 
            // UserLevel
            // 
            this.UserLevel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLevel.FormattingEnabled = true;
            this.UserLevel.Items.AddRange(new object[] {
            "Level",
            "Admin",
            "Kasir",
            "Koki",
            "Waiter"});
            this.UserLevel.Location = new System.Drawing.Point(23, 164);
            this.UserLevel.Name = "UserLevel";
            this.UserLevel.Size = new System.Drawing.Size(296, 31);
            this.UserLevel.TabIndex = 9;
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(245, 208);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(75, 34);
            this.LoginBtn.TabIndex = 11;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 226);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(56, 19);
            this.metroLabel1.TabIndex = 12;
            this.metroLabel1.Text = "(C) 2021";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 265);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.UserLevel);
            this.Controls.Add(this.PanelPassword);
            this.Controls.Add(this.PanelUsername);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "LoginForm";
            this.Resizable = false;
            this.Text = "Login ke Aplikasi";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.UsernameTxtMargin.ResumeLayout(false);
            this.UsernameTxtMargin.PerformLayout();
            this.PanelUsername.ResumeLayout(false);
            this.PanelPassword.ResumeLayout(false);
            this.PasswordTxtMargin.ResumeLayout(false);
            this.PasswordTxtMargin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label UserLogo;
        private System.Windows.Forms.TextBox UsernameTxt;
        private System.Windows.Forms.Panel UsernameTxtMargin;
        private System.Windows.Forms.Panel PanelUsername;
        private System.Windows.Forms.Button UsernameClearBtn;
        private System.Windows.Forms.Panel PanelPassword;
        private System.Windows.Forms.Button PasswordClearBtn;
        private System.Windows.Forms.Label PasswordLogo;
        private System.Windows.Forms.Panel PasswordTxtMargin;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.ComboBox UserLevel;
        private MetroFramework.Controls.MetroButton LoginBtn;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}