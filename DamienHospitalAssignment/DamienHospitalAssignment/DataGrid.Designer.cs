
namespace DamienHospitalAssignment
{
    partial class DataGrid
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnSDoc = new System.Windows.Forms.Button();
            this.btnNurse = new System.Windows.Forms.Button();
            this.btnPartTime = new System.Windows.Forms.Button();
            this.btnPatient = new System.Windows.Forms.Button();
            this.lblDataCheck = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(28, 276);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 62;
            this.dgv.RowTemplate.Height = 28;
            this.dgv.Size = new System.Drawing.Size(775, 247);
            this.dgv.TabIndex = 0;
            // 
            // btnSDoc
            // 
            this.btnSDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSDoc.Location = new System.Drawing.Point(48, 113);
            this.btnSDoc.Name = "btnSDoc";
            this.btnSDoc.Size = new System.Drawing.Size(336, 64);
            this.btnSDoc.TabIndex = 1;
            this.btnSDoc.Text = "DOCTOR";
            this.btnSDoc.UseVisualStyleBackColor = true;
            this.btnSDoc.Click += new System.EventHandler(this.btnSDoc_Click);
            // 
            // btnNurse
            // 
            this.btnNurse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNurse.Location = new System.Drawing.Point(418, 113);
            this.btnNurse.Name = "btnNurse";
            this.btnNurse.Size = new System.Drawing.Size(363, 64);
            this.btnNurse.TabIndex = 2;
            this.btnNurse.Text = "NURSE";
            this.btnNurse.UseVisualStyleBackColor = true;
            this.btnNurse.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPartTime
            // 
            this.btnPartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartTime.Location = new System.Drawing.Point(48, 192);
            this.btnPartTime.Name = "btnPartTime";
            this.btnPartTime.Size = new System.Drawing.Size(336, 64);
            this.btnPartTime.TabIndex = 3;
            this.btnPartTime.Text = "PART-TIME";
            this.btnPartTime.UseVisualStyleBackColor = true;
            this.btnPartTime.Click += new System.EventHandler(this.btnPartTime_Click);
            // 
            // btnPatient
            // 
            this.btnPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatient.Location = new System.Drawing.Point(418, 192);
            this.btnPatient.Name = "btnPatient";
            this.btnPatient.Size = new System.Drawing.Size(363, 64);
            this.btnPatient.TabIndex = 4;
            this.btnPatient.Text = "PATIENT";
            this.btnPatient.UseVisualStyleBackColor = true;
            this.btnPatient.Click += new System.EventHandler(this.btnPatient_Click);
            // 
            // lblDataCheck
            // 
            this.lblDataCheck.AutoSize = true;
            this.lblDataCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataCheck.Location = new System.Drawing.Point(227, 31);
            this.lblDataCheck.Name = "lblDataCheck";
            this.lblDataCheck.Size = new System.Drawing.Size(370, 55);
            this.lblDataCheck.TabIndex = 5;
            this.lblDataCheck.Text = "Check the Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(307, 544);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 32);
            this.label1.TabIndex = 27;
            this.label1.Text = "THANK YOU";
            // 
            // DataGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 616);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDataCheck);
            this.Controls.Add(this.btnPatient);
            this.Controls.Add(this.btnPartTime);
            this.Controls.Add(this.btnNurse);
            this.Controls.Add(this.btnSDoc);
            this.Controls.Add(this.dgv);
            this.Name = "DataGrid";
            this.Text = " ";
            this.Load += new System.EventHandler(this.DataGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnSDoc;
        private System.Windows.Forms.Button btnNurse;
        private System.Windows.Forms.Button btnPartTime;
        private System.Windows.Forms.Button btnPatient;
        private System.Windows.Forms.Label lblDataCheck;
        private System.Windows.Forms.Label label1;
    }
}