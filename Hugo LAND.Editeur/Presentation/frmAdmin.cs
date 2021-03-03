using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hugo_LAND.Core.Models;
using System.Data.Entity;

namespace HugoLandEditeur.Presentation
{
    public partial class frmAdmin : Form
    {
        private HugoLANDContext context;

        public frmAdmin()
        {
            InitializeComponent();
            context = new HugoLANDContext();
            txtPassword.PasswordChar = '*';
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string resultat = CompteJoueursCRUD.ModifCompteJoueur(
                Int32.Parse(txtId.Text),
                txtPlayerName.Text,
                txtEmail.Text,
                txtFirstName.Text, 
                txtLastName.Text,
                TypeUtilisateur.Admin,
                txtPassword.Text);
            if (resultat == "SUCCESS")
            {
                MessageBox.Show("The admin has been modified", "Success!", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.Close();
            }
            else
                MessageBox.Show("An error has occured with the modification of the admin", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            context.CompteJoueurs.Load();
            compteJoueurBindingSource.DataSource = context.CompteJoueurs.ToList().Where(c => c.TypeUtilisateur == TypeUtilisateur.Admin);
        }
    }
}
