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
            this.txtSampleId = new System.Windows.Forms.TextBox();
            this.lblSampleId = new System.Windows.Forms.Label();
            this.txtPatientId = new System.Windows.Forms.TextBox();
            this.lblPatientId = new System.Windows.Forms.Label();
            this.cboSampleType = new System.Windows.Forms.ComboBox();
            this.lblSampleType = new System.Windows.Forms.Label();
            this.txtSampleInfo = new System.Windows.Forms.TextBox();
            this.lblSampleInfo = new System.Windows.Forms.Label();
            this.txtTimeOfReceipt = new System.Windows.Forms.TextBox();
            this.lblTimeOfReceipt = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtRecipient = new System.Windows.Forms.TextBox();
            this.lblRecipient = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSampleId
            // 
            this.txtSampleId.Enabled = false;
            this.txtSampleId.Location = new System.Drawing.Point(357, 83);
            this.txtSampleId.Name = "txtSampleId";
            this.txtSampleId.ReadOnly = true;
            this.txtSampleId.Size = new System.Drawing.Size(171, 22);
            this.txtSampleId.TabIndex = 0;
            // 
            // lblSampleId
            // 
            this.lblSampleId.AutoSize = true;
            this.lblSampleId.Location = new System.Drawing.Point(279, 86);
            this.lblSampleId.Name = "lblSampleId";
            this.lblSampleId.Size = new System.Drawing.Size(56, 16);
            this.lblSampleId.TabIndex = 1;
            this.lblSampleId.Text = "Uzorak: ";
            // 
            // txtPatientId
            // 
            this.txtPatientId.Enabled = false;
            this.txtPatientId.Location = new System.Drawing.Point(357, 123);
            this.txtPatientId.Name = "txtPatientId";
            this.txtPatientId.Size = new System.Drawing.Size(171, 22);
            this.txtPatientId.TabIndex = 2;
            // 
            // lblPatientId
            // 
            this.lblPatientId.AutoSize = true;
            this.lblPatientId.Location = new System.Drawing.Point(277, 129);
            this.lblPatientId.Name = "lblPatientId";
            this.lblPatientId.Size = new System.Drawing.Size(61, 16);
            this.lblPatientId.TabIndex = 3;
            this.lblPatientId.Text = "Pacijent :";
            // 
            // cboSampleType
            // 
            this.cboSampleType.FormattingEnabled = true;
            this.cboSampleType.Location = new System.Drawing.Point(357, 237);
            this.cboSampleType.Name = "cboSampleType";
            this.cboSampleType.Size = new System.Drawing.Size(171, 24);
            this.cboSampleType.TabIndex = 4;
            // 
            // lblSampleType
            // 
            this.lblSampleType.AutoSize = true;
            this.lblSampleType.Location = new System.Drawing.Point(257, 240);
            this.lblSampleType.Name = "lblSampleType";
            this.lblSampleType.Size = new System.Drawing.Size(84, 16);
            this.lblSampleType.TabIndex = 5;
            this.lblSampleType.Text = "Vrsta uzorka:";
            // 
            // txtSampleInfo
            // 
            this.txtSampleInfo.Location = new System.Drawing.Point(357, 281);
            this.txtSampleInfo.Multiline = true;
            this.txtSampleInfo.Name = "txtSampleInfo";
            this.txtSampleInfo.Size = new System.Drawing.Size(326, 117);
            this.txtSampleInfo.TabIndex = 6;
            // 
            // lblSampleInfo
            // 
            this.lblSampleInfo.AutoSize = true;
            this.lblSampleInfo.Location = new System.Drawing.Point(257, 284);
            this.lblSampleInfo.Name = "lblSampleInfo";
            this.lblSampleInfo.Size = new System.Drawing.Size(81, 16);
            this.lblSampleInfo.TabIndex = 7;
            this.lblSampleInfo.Text = "Opis uzorka:";
            // 
            // txtTimeOfReceipt
            // 
            this.txtTimeOfReceipt.Location = new System.Drawing.Point(357, 161);
            this.txtTimeOfReceipt.Name = "txtTimeOfReceipt";
            this.txtTimeOfReceipt.Size = new System.Drawing.Size(171, 22);
            this.txtTimeOfReceipt.TabIndex = 8;
            // 
            // lblTimeOfReceipt
            // 
            this.lblTimeOfReceipt.AutoSize = true;
            this.lblTimeOfReceipt.Location = new System.Drawing.Point(170, 164);
            this.lblTimeOfReceipt.Name = "lblTimeOfReceipt";
            this.lblTimeOfReceipt.Size = new System.Drawing.Size(171, 16);
            this.lblTimeOfReceipt.TabIndex = 9;
            this.lblTimeOfReceipt.Text = "Datum i vrijeme zaprimanja:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(568, 421);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 33);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtRecipient
            // 
            this.txtRecipient.Location = new System.Drawing.Point(357, 200);
            this.txtRecipient.Name = "txtRecipient";
            this.txtRecipient.Size = new System.Drawing.Size(171, 22);
            this.txtRecipient.TabIndex = 11;
            // 
            // lblRecipient
            // 
            this.lblRecipient.AutoSize = true;
            this.lblRecipient.Location = new System.Drawing.Point(257, 202);
            this.lblRecipient.Name = "lblRecipient";
            this.lblRecipient.Size = new System.Drawing.Size(77, 16);
            this.lblRecipient.TabIndex = 12;
            this.lblRecipient.Text = "Zaprimatelj:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(357, 421);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 33);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmSampleEvidention
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 509);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblRecipient);
            this.Controls.Add(this.txtRecipient);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblTimeOfReceipt);
            this.Controls.Add(this.txtTimeOfReceipt);
            this.Controls.Add(this.lblSampleInfo);
            this.Controls.Add(this.txtSampleInfo);
            this.Controls.Add(this.lblSampleType);
            this.Controls.Add(this.cboSampleType);
            this.Controls.Add(this.lblPatientId);
            this.Controls.Add(this.txtPatientId);
            this.Controls.Add(this.lblSampleId);
            this.Controls.Add(this.txtSampleId);
            this.Name = "FrmSampleEvidention";
            this.Text = "Evidencija uzorka";
            this.Load += new System.EventHandler(this.FrmSampleEvidention_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSampleId;
        private System.Windows.Forms.Label lblSampleId;
        private System.Windows.Forms.TextBox txtPatientId;
        private System.Windows.Forms.Label lblPatientId;
        private System.Windows.Forms.ComboBox cboSampleType;
        private System.Windows.Forms.Label lblSampleType;
        private System.Windows.Forms.TextBox txtSampleInfo;
        private System.Windows.Forms.Label lblSampleInfo;
        private System.Windows.Forms.TextBox txtTimeOfReceipt;
        private System.Windows.Forms.Label lblTimeOfReceipt;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtRecipient;
        private System.Windows.Forms.Label lblRecipient;
        private System.Windows.Forms.Button btnCancel;
    }
}