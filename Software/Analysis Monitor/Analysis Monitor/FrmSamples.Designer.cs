namespace Analysis_Monitor
{
    partial class FrmSamples
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
            this.dgvSamples = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddSample = new System.Windows.Forms.Button();
            this.lblSampleList = new System.Windows.Forms.Label();
            this.txtSearchIdPatient = new System.Windows.Forms.TextBox();
            this.lblSearchIdPatient = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSamples)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSamples
            // 
            this.dgvSamples.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSamples.Location = new System.Drawing.Point(15, 133);
            this.dgvSamples.Name = "dgvSamples";
            this.dgvSamples.RowHeadersWidth = 51;
            this.dgvSamples.RowTemplate.Height = 24;
            this.dgvSamples.Size = new System.Drawing.Size(967, 342);
            this.dgvSamples.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(30, 507);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 34);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Obriši";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(186, 508);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(87, 33);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Uredi";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAddSample
            // 
            this.btnAddSample.Location = new System.Drawing.Point(833, 508);
            this.btnAddSample.Name = "btnAddSample";
            this.btnAddSample.Size = new System.Drawing.Size(149, 33);
            this.btnAddSample.TabIndex = 3;
            this.btnAddSample.Text = "Dodaj uzorak";
            this.btnAddSample.UseVisualStyleBackColor = true;
            this.btnAddSample.Click += new System.EventHandler(this.btnAddSample_Click);
            // 
            // lblSampleList
            // 
            this.lblSampleList.AutoSize = true;
            this.lblSampleList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblSampleList.Location = new System.Drawing.Point(398, 25);
            this.lblSampleList.Name = "lblSampleList";
            this.lblSampleList.Size = new System.Drawing.Size(221, 29);
            this.lblSampleList.TabIndex = 4;
            this.lblSampleList.Text = "Evidentirani uzorci";
            // 
            // txtSearchIdPatient
            // 
            this.txtSearchIdPatient.Location = new System.Drawing.Point(179, 67);
            this.txtSearchIdPatient.Name = "txtSearchIdPatient";
            this.txtSearchIdPatient.Size = new System.Drawing.Size(100, 22);
            this.txtSearchIdPatient.TabIndex = 5;
            // 
            // lblSearchIdPatient
            // 
            this.lblSearchIdPatient.AutoSize = true;
            this.lblSearchIdPatient.Location = new System.Drawing.Point(38, 71);
            this.lblSearchIdPatient.Name = "lblSearchIdPatient";
            this.lblSearchIdPatient.Size = new System.Drawing.Size(132, 16);
            this.lblSearchIdPatient.TabIndex = 6;
            this.lblSearchIdPatient.Text = "Pretraži po IdPatient: ";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(233, 97);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 28);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Pretraži";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(795, 72);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(117, 36);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Osvježi popis";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // FrmSamples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 556);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblSearchIdPatient);
            this.Controls.Add(this.txtSearchIdPatient);
            this.Controls.Add(this.lblSampleList);
            this.Controls.Add(this.btnAddSample);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvSamples);
            this.Name = "FrmSamples";
            this.Text = "FrmSamples";
            this.Load += new System.EventHandler(this.FrmSamples_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSamples)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSamples;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAddSample;
        private System.Windows.Forms.Label lblSampleList;
        private System.Windows.Forms.TextBox txtSearchIdPatient;
        private System.Windows.Forms.Label lblSearchIdPatient;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRefresh;
    }
}