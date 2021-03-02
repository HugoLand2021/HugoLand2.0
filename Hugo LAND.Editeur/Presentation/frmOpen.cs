using Hugo_LAND.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HugoLandEditeur.Presentation
{
    public partial class frmOpen : Form
    {

        private readonly HugoLANDContext context;

        public frmOpen()
        {
            InitializeComponent();
            context = new HugoLANDContext();
            
        }

        private void frmOpen_Load(object sender, EventArgs e)
        {
            context.Mondes.Load();
            mondeBindingSource.DataSource = context.Mondes.ToList();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            mondeBindingSource.MoveNext();

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            mondeBindingSource.MovePrevious();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            //mondeBindingSource.Current();
        }



        //private void Form1_Load(object sender, System.EventArgs e)
        //{
        //    categoryBindingSource.DataSource = dbContext.Categories.ToList();
        //}
    }
}
