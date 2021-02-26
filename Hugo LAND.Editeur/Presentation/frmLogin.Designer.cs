namespace HugoLandEditeur.Presentation
{
    partial class frmLogin
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
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(12, 35);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(121, 17);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Nom d\'utilisateur :";
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(32, 68);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(101, 17);
            this.lblPwd.TabIndex = 1;
            this.lblPwd.Text = "Mot de passe :";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(139, 32);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(158, 22);
            this.txtUserName.TabIndex = 2;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(139, 68);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(158, 22);
            this.txtPwd.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(52, 121);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(98, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Connexion";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(176, 121);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 166);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.lblUser);
            this.Name = "frmLogin";
            this.Text = "Connexion Utilisateur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCancel;
    }
}