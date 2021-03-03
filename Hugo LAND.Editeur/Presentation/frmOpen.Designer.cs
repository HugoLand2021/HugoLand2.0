
namespace HugoLandEditeur.Presentation
{
    partial class frmOpen
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
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label limiteXLabel;
            System.Windows.Forms.Label limiteYLabel;
            this.lblDescription = new System.Windows.Forms.Label();
            this.mondeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblId = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            descriptionLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            limiteXLabel = new System.Windows.Forms.Label();
            limiteYLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mondeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(43, 91);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(83, 17);
            descriptionLabel.TabIndex = 0;
            descriptionLabel.Text = "Description:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(43, 68);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(23, 17);
            idLabel.TabIndex = 2;
            idLabel.Text = "Id:";
            // 
            // limiteXLabel
            // 
            limiteXLabel.AutoSize = true;
            limiteXLabel.Location = new System.Drawing.Point(43, 114);
            limiteXLabel.Name = "limiteXLabel";
            limiteXLabel.Size = new System.Drawing.Size(62, 17);
            limiteXLabel.TabIndex = 4;
            limiteXLabel.Text = "Limite X:";
            // 
            // limiteYLabel
            // 
            limiteYLabel.AutoSize = true;
            limiteYLabel.Location = new System.Drawing.Point(43, 137);
            limiteYLabel.Name = "limiteYLabel";
            limiteYLabel.Size = new System.Drawing.Size(62, 17);
            limiteYLabel.TabIndex = 6;
            limiteYLabel.Text = "Limite Y:";
            // 
            // lblDescription
            // 
            this.lblDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mondeBindingSource, "Description", true));
            this.lblDescription.Location = new System.Drawing.Point(132, 91);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(100, 23);
            this.lblDescription.TabIndex = 1;
            // 
            // mondeBindingSource
            // 
            this.mondeBindingSource.DataSource = typeof(Hugo_LAND.Core.Models.Monde);
            // 
            // lblId
            // 
            this.lblId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mondeBindingSource, "Id", true));
            this.lblId.Location = new System.Drawing.Point(132, 68);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(100, 23);
            this.lblId.TabIndex = 3;
            // 
            // lblX
            // 
            this.lblX.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mondeBindingSource, "LimiteX", true));
            this.lblX.Location = new System.Drawing.Point(132, 114);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(100, 23);
            this.lblX.TabIndex = 5;
            // 
            // lblY
            // 
            this.lblY.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mondeBindingSource, "LimiteY", true));
            this.lblY.Location = new System.Drawing.Point(132, 137);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(100, 23);
            this.lblY.TabIndex = 7;
            // 
            // btnNext
            // 
            this.btnNext.Image = global::HugoLandEditeur.Properties.Resources.rightArrow;
            this.btnNext.Location = new System.Drawing.Point(157, 28);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 9;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Image = global::HugoLandEditeur.Properties.Resources.leftArrow;
            this.btnPrevious.Location = new System.Drawing.Point(46, 28);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 8;
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(46, 163);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(92, 32);
            this.btnSelect.TabIndex = 10;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(144, 163);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 32);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmOpen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 229);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.lblId);
            this.Controls.Add(limiteXLabel);
            this.Controls.Add(this.lblX);
            this.Controls.Add(limiteYLabel);
            this.Controls.Add(this.lblY);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmOpen";
            this.Text = "Selection de Monde";
            this.Load += new System.EventHandler(this.frmOpen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mondeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource mondeBindingSource;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnCancel;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}