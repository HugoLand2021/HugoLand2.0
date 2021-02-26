using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hugo_LAND.Core.Model;

namespace HugoLandEditeur
{
    public partial class frmLogin : Form
    {
        private bool EstConnecte =  false;
        private readonly frmMain mainForm;

        public frmLogin(frmMain mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (CompteJoueursCRUD.ValideJoueur(txtUserName.Text, txtPwd.Text) == "SUCCESS") {
                EstConnecte = true;
                mainForm.ConnectionReussie();
                this.Close();
            }
            else
                MessageBox.Show("Le nom ou mot de passe n'est pas bon!", "Erreur!", MessageBoxButtons.OK , MessageBoxIcon.Warning);
        }

        private void btnCancel_Click(object sender, EventArgs e) => Application.Exit();

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e) { 
            if (!EstConnecte)
                Application.Exit();
        }
    }
}
