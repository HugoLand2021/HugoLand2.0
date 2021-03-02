using Hugo_LAND.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HugoLandEditeur.Presentation
{
    public partial class frmCreateUser : Form
    {
        public frmCreateUser()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string resultat = CompteJoueursCRUD.CreerJoueur(
                txtUsername.Text,
                txtEmail.Text,
                txtFirstName.Text, txtLastName.Text, /*A REVOIR ICI C'EST PAS CA*/int.Parse(comboUserType.Text),
                txtPassword.Text);
            if (resultat == "SUCCESS")
            {
                MessageBox.Show("The user has been created", "Success!", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.Close();
            }
            else
                MessageBox.Show("An error has occured with the creation of the user", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
