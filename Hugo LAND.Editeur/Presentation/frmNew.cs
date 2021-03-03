using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HugoLandEditeur
{
    public partial class frmNew : Form
    {
        private int m_Width;
        private int m_Height;
        private string m_Description;
        public frmNew()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
            m_Width = 32;
            m_Height = 32;
        }

        // Width
        public int MapWidth
        {
            get
            {
                return m_Width;
            }
            set
            {
                m_Width = value;
            }
        }

        // Height
        public int MapHeight
        {
            get
            {
                return m_Height;
            }
            set
            {
                m_Height = value;
            }
        }

        public string MapDescritpion
        {
            get
            {
                return m_Description;
            }
            set
            {
                m_Description = value;
            }
        }


        private void UpdateUI()
        {
            int val1 = 0, val2 = 0;
            string val3 = "";
            btnOK.Enabled = ValidateInput(ref val1, ref val2, ref val3);
        }

        private bool ValidateInput(ref int nWidth, ref int nHeight, ref string nDescription)
        {
            String strValue = txtDescription.Text.Trim();
            nDescription = strValue;

            strValue = txtWidth.Text.Trim();
            int nValue = Convert.ToInt32(strValue, 10);
            nWidth = nValue;

            strValue = txtHeight.Text.Trim();
            nValue = Convert.ToInt32(strValue, 10);
            nHeight = nValue;

            // Validate Height
            if (nHeight < 8 || nHeight > 64000)
                return false;

            // Validate Width
            if (nWidth < 8 || nWidth > 64000)
                return false;

            if (nDescription.Length < 3 || nDescription.Length > 50)
                return false;

            return true;
        }

        private void btnOK_Click(object sender, System.EventArgs e)
        {
            int width = 0, height = 0;
            string description = "";

            if (ValidateInput(ref width, ref height, ref description))
            {
                m_Width = width;
                m_Height = height;
                m_Description = description;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void txtWidth_TextChanged(object sender, System.EventArgs e)
        {
            UpdateUI();
        }

        private void txtHeight_TextChanged(object sender, System.EventArgs e)
        {
            UpdateUI();
        }
    }
}
