namespace Analysis_Monitor
{
    partial class FrmSampleEvidention
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
            this.txtPatientId = new System.Windows.Forms.TextBox();
            this.lblPatientId = new System.Windows.Forms.Label();
            this.cboSampleType = new System.Windows.Forms.ComboBox();
            this.lblSampleType = new System.Windows.Forms.Label();
            this.txtSampleInfo = new System.Windows.Forms.TextBox();
            this.lblSampleInfo = new System.Windows.Forms.Label();
            this.txtTimeOfReceipt = new System.Windows.Forms.TextBox();
            this.lblTimeOfReceipt = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblRecipient = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cboIdEmployee = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtPatientId
            // 
            this.txtPatientId.Enabled = false;
            this.txtPatientId.Location = new System.Drawing.Point(352, 76);
            this.txtPatientId.Name = "txtPatientId";
            this.txtPatientId.Size = new System.Drawing.Size(171, 22);
            this.txtPatientId.TabIndex = 2;
            // 
            // lblPatientId
            // 
            this.lblPatientId.AutoSize = true;
            this.lblPatientId.Location = new System.Drawing.Point(248, 82);
            this.lblPatientId.Name = "lblPatientId";
            this.lblPatientId.Size = new System.Drawing.Size(84, 16);
            this.lblPatientId.TabIndex = 3;
            this.lblPatientId.Text = "ID pacijenta :";
            // 
            // cboSampleType
            // 
            this.cboSampleType.FormattingEnabled = true;
            this.cboSampleType.Location = new System.Drawing.Point(352, 190);
            this.cboSampleType.Name = "cboSampleType";
            this.cboSampleType.Size = new System.Drawing.Size(171, 24);
            this.cboSampleType.TabIndex = 4;
            // 
            // lblSampleType
            // 
            this.lblSampleType.AutoSize = true;
            this.lblSampleType.Location = new System.Drawing.Point(252, 193);
            this.lblSampleType.Name = "lblSampleType";
            this.lblSampleType.Size = new System.Drawing.Size(84, 16);
            this.lblSampleType.TabIndex = 5;
            this.lblSampleType.Text = "Vrsta uzorka:";
            // 
            // txtSampleInfo
            // 
            this.txtSampleInfo.Location = new System.Drawing.Point(352, 234);
            this.txtSampleInfo.Multiline = true;
            this.txtSampleInfo.Name = "txtSampleInfo";
            this.txtSampleInfo.Size = new System.Drawing.Size(326, 117);
            this.txtSampleInfo.TabIndex = 6;
            // 
            // lblSampleInfo
            // 
            this.lblSampleInfo.AutoSize = true;
            this.lblSampleInfo.Location = new System.Drawing.Point(252, 237);
            this.lblSampleInfo.Name = "lblSampleInfo";
            this.lblSampleInfo.Size = new System.Drawing.Size(81, 16);
            this.lblSampleInfo.TabIndex = 7;
            this.lblSampleInfo.Text = "Opis uzorka:";
            // 
            // txtTimeOfReceipt
            // 
            this.txtTimeOfReceipt.Enabled = false;
            this.txtTimeOfReceipt.Location = new System.Drawing.Point(352, 114);
            this.txtTimeOfReceipt.Name = "txtTimeOfReceipt";
            this.txtTimeOfReceipt.Size = new System.Drawing.Size(171, 22);
            this.txtTimeOfReceipt.TabIndex = 8;
            // 
            // lblTimeOfReceipt
            // 
            this.lblTimeOfReceipt.AutoSize = true;
            this.lblTimeOfReceipt.Location = new System.Drawing.Point(165, 117);
            this.lblTimeOfReceipt.Name = "lblTimeOfReceipt";
            this.lblTimeOfReceipt.Size = new System.Drawing.Size(171, 16);
            this.lblTimeOfReceipt.TabIndex = 9;
            this.lblTimeOfReceipt.Text = "Datum i vrijeme zaprimanja:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(563, 374);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 33);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblRecipient
            // 
            this.lblRecipient.AutoSize = true;
            this.lblRecipient.Location = new System.Drawing.Point(257, 155);
            this.lblRecipient.Name = "lblRecipient";
            this.lblRecipient.Size = new System.Drawing.Size(77, 16);
            this.lblRecipient.TabIndex = 12;
            this.lblRecipient.Text = "Zaprimatelj:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(352, 374);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 33);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cboIdEmployee
            // 
            this.cboIdEmployee.FormattingEnabled = true;
            this.cboIdEmployee.Location = new System.Drawing.Point(352, 152);
            this.cboIdEmployee.Name = "cboIdEmployee";
            this.cboIdEmployee.Size = new System.Drawing.Size(171, 24);
            this.cboIdEmployee.TabIndex = 14;
            // 
            // FrmSampleEvidention
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 509);
            this.Controls.Add(this.cboIdEmployee);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblRecipient);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblTimeOfReceipt);
            this.Controls.Add(this.txtTimeOfReceipt);
            this.Controls.Add(this.lblSampleInfo);
            this.Controls.Add(this.txtSampleInfo);
            this.Controls.Add(this.lblSampleType);
            this.Controls.Add(this.cboSampleType);
            this.Controls.Add(this.lblPatientId);
            this.Controls.Add(this.txtPatientId);
            this.Name = "FrmSampleEvidention";
            this.Text = "Evidencija uzorka";
            this.Load += new System.EventHandler(this.FrmSampleEvidention_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPatientId;
        private System.Windows.Forms.Label lblPatientId;
        private System.Windows.Forms.ComboBox cboSampleType;
        private System.Windows.Forms.Label lblSampleType;
        private System.Windows.Forms.TextBox txtSampleInfo;
        private System.Windows.Forms.Label lblSampleInfo;
        private System.Windows.Forms.TextBox txtTimeOfReceipt;
        private System.Windows.Forms.Label lblTimeOfReceipt;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblRecipient;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cboIdEmployee;
    }
}