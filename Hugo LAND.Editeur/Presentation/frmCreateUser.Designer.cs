
namespace HugoLandEditeur.Presentation
{
    partial class frmCreateUser
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblUserType = new System.Windows.Forms.Label();
            this.txtPasswordConfirmation = new System.Windows.Forms.TextBox();
            this.lblPasswordConfirmation = new System.Windows.Forms.Label();
            this.compteJoueurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboUserType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.compteJoueurBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(29, 306);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(96, 34);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(182, 306);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 34);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(27, 39);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(140, 37);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(139, 20);
            this.txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(140, 70);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(139, 20);
            this.txtPassword.TabIndex = 5;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(27, 72);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(140, 136);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(139, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(27, 138);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(140, 175);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(139, 20);
            this.txtFirstName.TabIndex = 9;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(27, 177);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(55, 13);
            this.lblFirstName.TabIndex = 8;
            this.lblFirstName.Text = "First name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(140, 217);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(139, 20);
            this.txtLastName.TabIndex = 11;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(27, 220);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(56, 13);
            this.lblLastName.TabIndex = 10;
            this.lblLastName.Text = "Last name";
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.Location = new System.Drawing.Point(27, 263);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(52, 13);
            this.lblUserType.TabIndex = 12;
            this.lblUserType.Text = "User type";
            // 
            // txtPasswordConfirmation
            // 
            this.txtPasswordConfirmation.Location = new System.Drawing.Point(140, 102);
            this.txtPasswordConfirmation.Name = "txtPasswordConfirmation";
            this.txtPasswordConfirmation.Size = new System.Drawing.Size(139, 20);
            this.txtPasswordConfirmation.TabIndex = 16;
            // 
            // lblPasswordConfirmation
            // 
            this.lblPasswordConfirmation.AutoSize = true;
            this.lblPasswordConfirmation.Location = new System.Drawing.Point(27, 104);
            this.lblPasswordConfirmation.Name = "lblPasswordConfirmation";
            this.lblPasswordConfirmation.Size = new System.Drawing.Size(113, 13);
            this.lblPasswordConfirmation.TabIndex = 15;
            this.lblPasswordConfirmation.Text = "Password confirmation";
            // 
            // compteJoueurBindingSource
            // 
            this.compteJoueurBindingSource.DataSource = typeof(Hugo_LAND.Core.Models.CompteJoueur);
            // 
            // comboUserType
            // 
            this.comboUserType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.compteJoueurBindingSource, "TypeUtilisateur", true));
            this.comboUserType.FormattingEnabled = true;
            this.comboUserType.Location = new System.Drawing.Point(140, 261);
            this.comboUserType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboUserType.Name = "comboUserType";
            this.comboUserType.Size = new System.Drawing.Size(139, 21);
            this.comboUserType.TabIndex = 20;
            // 
            // frmCreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 388);
            this.Controls.Add(this.comboUserType);
            this.Controls.Add(this.txtPasswordConfirmation);
            this.Controls.Add(this.lblPasswordConfirmation);
            this.Controls.Add(this.lblUserType);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreate);
            this.Name = "frmCreateUser";
            this.Text = "frmCreateUser";
            ((System.ComponentModel.ISupportInitialize)(this.compteJoueurBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.TextBox txtPasswordConfirmation;
        private System.Windows.Forms.Label lblPasswordConfirmation;
        private System.Windows.Forms.BindingSource compteJoueurBindingSource;
        private System.Windows.Forms.ComboBox comboUserType;
    }
}