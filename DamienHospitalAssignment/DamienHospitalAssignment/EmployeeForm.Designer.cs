
namespace DamienHospitalAssignment
{
    partial class EmployeeForm
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
            this.grpboxPatientForm = new System.Windows.Forms.GroupBox();
            this.txtempid = new System.Windows.Forms.TextBox();
            this.lblempid = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.txtPh = new System.Windows.Forms.TextBox();
            this.lblPh = new System.Windows.Forms.Label();
            this.cboCy = new System.Windows.Forms.ComboBox();
            this.txtaddr = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblStafftype = new System.Windows.Forms.Label();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.lblhours = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.rdoPT = new System.Windows.Forms.RadioButton();
            this.rdoNur = new System.Windows.Forms.RadioButton();
            this.rdoDoc = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.cbospeci = new System.Windows.Forms.ComboBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblspeci = new System.Windows.Forms.Label();
            this.lblcy = new System.Windows.Forms.Label();
            this.lbladdr = new System.Windows.Forms.Label();
            this.lblage = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.grpboxPatientForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpboxPatientForm
            // 
            this.grpboxPatientForm.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grpboxPatientForm.Controls.Add(this.txtempid);
            this.grpboxPatientForm.Controls.Add(this.lblempid);
            this.grpboxPatientForm.Controls.Add(this.txtemail);
            this.grpboxPatientForm.Controls.Add(this.lblemail);
            this.grpboxPatientForm.Controls.Add(this.txtPh);
            this.grpboxPatientForm.Controls.Add(this.lblPh);
            this.grpboxPatientForm.Controls.Add(this.cboCy);
            this.grpboxPatientForm.Controls.Add(this.txtaddr);
            this.grpboxPatientForm.Controls.Add(this.btnBack);
            this.grpboxPatientForm.Controls.Add(this.lblStafftype);
            this.grpboxPatientForm.Controls.Add(this.txtHours);
            this.grpboxPatientForm.Controls.Add(this.lblhours);
            this.grpboxPatientForm.Controls.Add(this.txtSalary);
            this.grpboxPatientForm.Controls.Add(this.lblSalary);
            this.grpboxPatientForm.Controls.Add(this.rdoPT);
            this.grpboxPatientForm.Controls.Add(this.rdoNur);
            this.grpboxPatientForm.Controls.Add(this.rdoDoc);
            this.grpboxPatientForm.Controls.Add(this.btnAdd);
            this.grpboxPatientForm.Controls.Add(this.btnNext);
            this.grpboxPatientForm.Controls.Add(this.cbospeci);
            this.grpboxPatientForm.Controls.Add(this.txtage);
            this.grpboxPatientForm.Controls.Add(this.txtname);
            this.grpboxPatientForm.Controls.Add(this.lblspeci);
            this.grpboxPatientForm.Controls.Add(this.lblcy);
            this.grpboxPatientForm.Controls.Add(this.lbladdr);
            this.grpboxPatientForm.Controls.Add(this.lblage);
            this.grpboxPatientForm.Controls.Add(this.lblname);
            this.grpboxPatientForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxPatientForm.Location = new System.Drawing.Point(30, 23);
            this.grpboxPatientForm.Name = "grpboxPatientForm";
            this.grpboxPatientForm.Size = new System.Drawing.Size(736, 666);
            this.grpboxPatientForm.TabIndex = 1;
            this.grpboxPatientForm.TabStop = false;
            this.grpboxPatientForm.Text = "STAFF FORM";
            this.grpboxPatientForm.Enter += new System.EventHandler(this.grpboxPatientForm_Enter);
            // 
            // txtempid
            // 
            this.txtempid.Location = new System.Drawing.Point(282, 394);
            this.txtempid.Name = "txtempid";
            this.txtempid.Size = new System.Drawing.Size(355, 30);
            this.txtempid.TabIndex = 32;
            // 
            // lblempid
            // 
            this.lblempid.AutoSize = true;
            this.lblempid.Location = new System.Drawing.Point(107, 394);
            this.lblempid.Name = "lblempid";
            this.lblempid.Size = new System.Drawing.Size(134, 25);
            this.lblempid.TabIndex = 31;
            this.lblempid.Text = "Employee ID";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(282, 350);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(355, 30);
            this.txtemail.TabIndex = 30;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(107, 350);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(65, 25);
            this.lblemail.TabIndex = 29;
            this.lblemail.Text = "Email";
            // 
            // txtPh
            // 
            this.txtPh.Location = new System.Drawing.Point(282, 303);
            this.txtPh.Name = "txtPh";
            this.txtPh.Size = new System.Drawing.Size(355, 30);
            this.txtPh.TabIndex = 28;
            // 
            // lblPh
            // 
            this.lblPh.AutoSize = true;
            this.lblPh.Location = new System.Drawing.Point(107, 303);
            this.lblPh.Name = "lblPh";
            this.lblPh.Size = new System.Drawing.Size(74, 25);
            this.lblPh.TabIndex = 27;
            this.lblPh.Text = "Phone";
            // 
            // cboCy
            // 
            this.cboCy.FormattingEnabled = true;
            this.cboCy.Location = new System.Drawing.Point(282, 254);
            this.cboCy.Name = "cboCy";
            this.cboCy.Size = new System.Drawing.Size(355, 33);
            this.cboCy.TabIndex = 26;
            // 
            // txtaddr
            // 
            this.txtaddr.Location = new System.Drawing.Point(282, 208);
            this.txtaddr.Name = "txtaddr";
            this.txtaddr.Size = new System.Drawing.Size(355, 30);
            this.txtaddr.TabIndex = 25;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Matura MT Script Capitals", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(112, 592);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(84, 52);
            this.btnBack.TabIndex = 24;
            this.btnBack.Text = "<<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblStafftype
            // 
            this.lblStafftype.AutoSize = true;
            this.lblStafftype.Location = new System.Drawing.Point(87, 61);
            this.lblStafftype.Name = "lblStafftype";
            this.lblStafftype.Size = new System.Drawing.Size(179, 25);
            this.lblStafftype.TabIndex = 23;
            this.lblStafftype.Text = "Select Staff Type";
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(282, 531);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(355, 30);
            this.txtHours.TabIndex = 22;
            // 
            // lblhours
            // 
            this.lblhours.AutoSize = true;
            this.lblhours.Location = new System.Drawing.Point(107, 531);
            this.lblhours.Name = "lblhours";
            this.lblhours.Size = new System.Drawing.Size(69, 25);
            this.lblhours.TabIndex = 21;
            this.lblhours.Text = "Hours";
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(282, 485);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(355, 30);
            this.txtSalary.TabIndex = 20;
            this.txtSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(107, 485);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(74, 25);
            this.lblSalary.TabIndex = 19;
            this.lblSalary.Text = "Salary";
            // 
            // rdoPT
            // 
            this.rdoPT.AutoSize = true;
            this.rdoPT.Location = new System.Drawing.Point(541, 59);
            this.rdoPT.Name = "rdoPT";
            this.rdoPT.Size = new System.Drawing.Size(132, 29);
            this.rdoPT.TabIndex = 18;
            this.rdoPT.TabStop = true;
            this.rdoPT.Text = "Part-Time";
            this.rdoPT.UseVisualStyleBackColor = true;
            this.rdoPT.CheckedChanged += new System.EventHandler(this.rdoPT_CheckedChanged);
            // 
            // rdoNur
            // 
            this.rdoNur.AutoSize = true;
            this.rdoNur.Location = new System.Drawing.Point(418, 59);
            this.rdoNur.Name = "rdoNur";
            this.rdoNur.Size = new System.Drawing.Size(94, 29);
            this.rdoNur.TabIndex = 17;
            this.rdoNur.TabStop = true;
            this.rdoNur.Text = "Nurse";
            this.rdoNur.UseVisualStyleBackColor = true;
            this.rdoNur.CheckedChanged += new System.EventHandler(this.rdoNur_CheckedChanged);
            // 
            // rdoDoc
            // 
            this.rdoDoc.AutoSize = true;
            this.rdoDoc.Location = new System.Drawing.Point(288, 59);
            this.rdoDoc.Name = "rdoDoc";
            this.rdoDoc.Size = new System.Drawing.Size(100, 29);
            this.rdoDoc.TabIndex = 16;
            this.rdoDoc.Text = "Doctor";
            this.rdoDoc.UseVisualStyleBackColor = true;
            this.rdoDoc.CheckedChanged += new System.EventHandler(this.rdoDoc_CheckedChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(282, 589);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(212, 52);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Matura MT Script Capitals", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(553, 589);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(84, 52);
            this.btnNext.TabIndex = 14;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // cbospeci
            // 
            this.cbospeci.FormattingEnabled = true;
            this.cbospeci.Location = new System.Drawing.Point(282, 438);
            this.cbospeci.Name = "cbospeci";
            this.cbospeci.Size = new System.Drawing.Size(355, 33);
            this.cbospeci.TabIndex = 12;
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(282, 162);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(355, 30);
            this.txtage.TabIndex = 7;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(280, 115);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(355, 30);
            this.txtname.TabIndex = 6;
            // 
            // lblspeci
            // 
            this.lblspeci.AutoSize = true;
            this.lblspeci.Location = new System.Drawing.Point(107, 438);
            this.lblspeci.Name = "lblspeci";
            this.lblspeci.Size = new System.Drawing.Size(106, 25);
            this.lblspeci.TabIndex = 4;
            this.lblspeci.Text = "Speciality";
            // 
            // lblcy
            // 
            this.lblcy.AutoSize = true;
            this.lblcy.Location = new System.Drawing.Point(107, 257);
            this.lblcy.Name = "lblcy";
            this.lblcy.Size = new System.Drawing.Size(81, 25);
            this.lblcy.TabIndex = 3;
            this.lblcy.Text = "County";
            // 
            // lbladdr
            // 
            this.lbladdr.AutoSize = true;
            this.lbladdr.Location = new System.Drawing.Point(107, 209);
            this.lbladdr.Name = "lbladdr";
            this.lbladdr.Size = new System.Drawing.Size(92, 25);
            this.lbladdr.TabIndex = 2;
            this.lbladdr.Text = "Address";
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Location = new System.Drawing.Point(107, 162);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(51, 25);
            this.lblage.TabIndex = 1;
            this.lblage.Text = "Age";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(105, 115);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(68, 25);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Name";
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DamienHospitalAssignment.Properties.Resources.hospital_building_modern_parking_lot_59693686;
            this.ClientSize = new System.Drawing.Size(792, 711);
            this.Controls.Add(this.grpboxPatientForm);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.grpboxPatientForm.ResumeLayout(false);
            this.grpboxPatientForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpboxPatientForm;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ComboBox cbospeci;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblspeci;
        private System.Windows.Forms.Label lblcy;
        private System.Windows.Forms.Label lbladdr;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.RadioButton rdoDoc;
        private System.Windows.Forms.RadioButton rdoPT;
        private System.Windows.Forms.RadioButton rdoNur;
        private System.Windows.Forms.Label lblStafftype;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.Label lblhours;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtaddr;
        private System.Windows.Forms.TextBox txtempid;
        private System.Windows.Forms.Label lblempid;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.TextBox txtPh;
        private System.Windows.Forms.Label lblPh;
        private System.Windows.Forms.ComboBox cboCy;
    }
}