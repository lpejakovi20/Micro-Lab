namespace Analysis_Monitor
{
    partial class FrmPatientSearch
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblOib = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(217, 92);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Pretraži";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(170, 52);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(96, 22);
            this.txtID.TabIndex = 1;
            // 
            // lblOib
            // 
            this.lblOib.AutoSize = true;
            this.lblOib.Location = new System.Drawing.Point(74, 54);
            this.lblOib.Name = "lblOib";
            this.lblOib.Size = new System.Drawing.Size(90, 16);
            this.lblOib.TabIndex = 2;
            this.lblOib.Text = "OIB pacijenta:";
            // 
            // FrmPatientSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 159);
            this.Controls.Add(this.lblOib);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnSearch);
            this.Name = "FrmPatientSearch";
            this.Text = "PretraživanjePacijenta";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblOib;
    }
}

