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
using Hugo_LAND.Core.Validators;

namespace HugoLandEditeur.Presentation
{
    public partial class frmAdmin : Form
    {
        private HugoLANDContext context;
        private readonly ModifAdminValidator ModifAdminValidator;
        public frmAdmin()
        {
            InitializeComponent();
            context = new HugoLANDContext();
            ModifAdminValidator = new ModifAdminValidator();

            txtPassword.PasswordChar = '*';
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            ModifAdmin u = new ModifAdmin()
            {
                NomJoueur = txtPlayerName.Text,
                Nom = txtFirstName.Text,
                Prenom = txtLastName.Text,
                Courriel = txtEmail.Text,
                MotDePasse = txtPassword.Text
            };

            var result = ModifAdminValidator.Validate(u);

            if (!result.IsValid)
            {
                MessageBox.Show(string.Join("\n", result.Errors.ToList()), "Errors", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
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
