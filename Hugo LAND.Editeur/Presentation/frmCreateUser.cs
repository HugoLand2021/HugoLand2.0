using Hugo_LAND.Core.Models;
using Hugo_LAND.Core.Validators;
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
        private readonly CreateUserValidator createUserValidator;
        public frmCreateUser()
        {
            InitializeComponent();
            createUserValidator = new CreateUserValidator();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateUser u = new CreateUser()
            {
                NomJoueur = txtUsername.Text,
                Courriel = txtEmail.Text,
                Prenom = txtFirstName.Text,
                Nom = txtLastName.Text,
                TypeUtilisateur = (TypeUtilisateur)comboUserType.SelectedValue, //AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAH ICIIIIIIIIIIIIIIIII REFAIRE
                MotDePasse = txtPassword.Text
            };

            var result = createUserValidator.Validate(u);

            if (!result.IsValid)
            {
                MessageBox.Show(string.Join("\n", result.Errors.ToList()), "Errors", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                string resultat = CompteJoueursCRUD.CreerJoueur(u.NomJoueur, u.Courriel, u.Prenom, u.Nom, (int)u.TypeUtilisateur, u.MotDePasse);
                if (resultat == "SUCCESS")
                {
                    MessageBox.Show("The user has been created", "Success!", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Close();
                }
                else
                    MessageBox.Show("An error has occured with the creation of the user", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
