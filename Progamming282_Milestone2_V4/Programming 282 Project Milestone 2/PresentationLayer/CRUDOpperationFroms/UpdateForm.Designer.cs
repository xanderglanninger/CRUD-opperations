namespace Programming_282_Project_Milestone_2.PresentationLayer.CRUDOpperationFroms
{
    partial class UpdateForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnINF = new System.Windows.Forms.RadioButton();
            this.rbtnMAT = new System.Windows.Forms.RadioButton();
            this.rbtnWPR = new System.Windows.Forms.RadioButton();
            this.rbtnLPR = new System.Windows.Forms.RadioButton();
            this.rbtnPRG = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStuNum = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dtpDateofBirth = new System.Windows.Forms.DateTimePicker();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvModules = new System.Windows.Forms.DataGridView();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.lblPath = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gbInserts = new System.Windows.Forms.GroupBox();
            this.gbDGV = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModules)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.gbInserts.SuspendLayout();
            this.gbDGV.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Wide Latin", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(649, 58);
            this.label1.TabIndex = 21;
            this.label1.Text = "Update Student";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.rbtnINF);
            this.groupBox1.Controls.Add(this.rbtnMAT);
            this.groupBox1.Controls.Add(this.rbtnWPR);
            this.groupBox1.Controls.Add(this.rbtnLPR);
            this.groupBox1.Controls.Add(this.rbtnPRG);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(600, 135);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(240, 266);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modules";
            // 
            // rbtnINF
            // 
            this.rbtnINF.AutoSize = true;
            this.rbtnINF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnINF.Location = new System.Drawing.Point(8, 48);
            this.rbtnINF.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnINF.Name = "rbtnINF";
            this.rbtnINF.Size = new System.Drawing.Size(210, 29);
            this.rbtnINF.TabIndex = 4;
            this.rbtnINF.TabStop = true;
            this.rbtnINF.Text = "Information Systems";
            this.rbtnINF.UseVisualStyleBackColor = true;
            // 
            // rbtnMAT
            // 
            this.rbtnMAT.AutoSize = true;
            this.rbtnMAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMAT.Location = new System.Drawing.Point(8, 159);
            this.rbtnMAT.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnMAT.Name = "rbtnMAT";
            this.rbtnMAT.Size = new System.Drawing.Size(144, 29);
            this.rbtnMAT.TabIndex = 3;
            this.rbtnMAT.TabStop = true;
            this.rbtnMAT.Text = "Mathematics";
            this.rbtnMAT.UseVisualStyleBackColor = true;
            // 
            // rbtnWPR
            // 
            this.rbtnWPR.AutoSize = true;
            this.rbtnWPR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnWPR.Location = new System.Drawing.Point(8, 122);
            this.rbtnWPR.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnWPR.Name = "rbtnWPR";
            this.rbtnWPR.Size = new System.Drawing.Size(206, 29);
            this.rbtnWPR.TabIndex = 2;
            this.rbtnWPR.TabStop = true;
            this.rbtnWPR.Text = "Web Developement";
            this.rbtnWPR.UseVisualStyleBackColor = true;
            // 
            // rbtnLPR
            // 
            this.rbtnLPR.AutoSize = true;
            this.rbtnLPR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnLPR.Location = new System.Drawing.Point(8, 85);
            this.rbtnLPR.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnLPR.Name = "rbtnLPR";
            this.rbtnLPR.Size = new System.Drawing.Size(208, 29);
            this.rbtnLPR.TabIndex = 1;
            this.rbtnLPR.TabStop = true;
            this.rbtnLPR.Text = "Linear Programming";
            this.rbtnLPR.UseVisualStyleBackColor = true;
            // 
            // rbtnPRG
            // 
            this.rbtnPRG.AutoSize = true;
            this.rbtnPRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnPRG.Location = new System.Drawing.Point(8, 196);
            this.rbtnPRG.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnPRG.Name = "rbtnPRG";
            this.rbtnPRG.Size = new System.Drawing.Size(149, 29);
            this.rbtnPRG.TabIndex = 0;
            this.rbtnPRG.TabStop = true;
            this.rbtnPRG.Text = "Programming";
            this.rbtnPRG.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(118, 317);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 25);
            this.label8.TabIndex = 37;
            this.label8.Text = "Address:";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(229, 312);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(344, 30);
            this.txtAddress.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(134, 263);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 25);
            this.label7.TabIndex = 35;
            this.label7.Text = "Phone:";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(229, 258);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(344, 30);
            this.txtPhone.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(80, 210);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 25);
            this.label5.TabIndex = 33;
            this.label5.Text = "Date Of Birth:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(111, 157);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 31;
            this.label4.Text = "Surname:";
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.Location = new System.Drawing.Point(229, 152);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(4);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(344, 30);
            this.txtSurname.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(97, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "First Name:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(229, 98);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(344, 30);
            this.txtName.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 25);
            this.label2.TabIndex = 27;
            this.label2.Text = "Student Number:";
            // 
            // txtStuNum
            // 
            this.txtStuNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStuNum.Location = new System.Drawing.Point(229, 44);
            this.txtStuNum.Margin = new System.Windows.Forms.Padding(4);
            this.txtStuNum.Name = "txtStuNum";
            this.txtStuNum.Size = new System.Drawing.Size(344, 30);
            this.txtStuNum.TabIndex = 26;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(600, 44);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(245, 65);
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.Text = "Update Student";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Red;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(866, 44);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(258, 63);
            this.btnBack.TabIndex = 41;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dtpDateofBirth
            // 
            this.dtpDateofBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateofBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateofBirth.Location = new System.Drawing.Point(229, 205);
            this.dtpDateofBirth.Name = "dtpDateofBirth";
            this.dtpDateofBirth.Size = new System.Drawing.Size(160, 30);
            this.dtpDateofBirth.TabIndex = 42;
            // 
            // cbGender
            // 
            this.cbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbGender.Location = new System.Drawing.Point(410, 202);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(163, 33);
            this.cbGender.TabIndex = 43;
            this.cbGender.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 25);
            this.label6.TabIndex = 47;
            this.label6.Text = "Students:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(575, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 25);
            this.label9.TabIndex = 46;
            this.label9.Text = "Modules:";
            // 
            // dgvModules
            // 
            this.dgvModules.BackgroundColor = System.Drawing.Color.White;
            this.dgvModules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModules.Location = new System.Drawing.Point(580, 68);
            this.dgvModules.Margin = new System.Windows.Forms.Padding(4);
            this.dgvModules.Name = "dgvModules";
            this.dgvModules.RowHeadersWidth = 51;
            this.dgvModules.Size = new System.Drawing.Size(519, 205);
            this.dgvModules.TabIndex = 45;
            // 
            // dgvStudents
            // 
            this.dgvStudents.BackgroundColor = System.Drawing.Color.White;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(29, 68);
            this.dgvStudents.Margin = new System.Windows.Forms.Padding(4);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.RowHeadersWidth = 51;
            this.dgvStudents.Size = new System.Drawing.Size(516, 205);
            this.dgvStudents.TabIndex = 44;
            this.dgvStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellContentClick);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(60, 236);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(0, 16);
            this.lblPath.TabIndex = 57;
            this.lblPath.Visible = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(70, 209);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(16, 16);
            this.lblName.TabIndex = 56;
            this.lblName.Text = "...";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 236);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 16);
            this.label10.TabIndex = 55;
            this.label10.Text = "Path:";
            this.label10.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 209);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 16);
            this.label11.TabIndex = 54;
            this.label11.Text = "Name:";
            // 
            // pbImage
            // 
            this.pbImage.BackColor = System.Drawing.Color.White;
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.Location = new System.Drawing.Point(44, 21);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(170, 170);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 53;
            this.pbImage.TabStop = false;
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Location = new System.Drawing.Point(229, 365);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(141, 36);
            this.btnUpload.TabIndex = 59;
            this.btnUpload.Text = "Upload Image";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(33, 371);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(170, 25);
            this.label12.TabIndex = 58;
            this.label12.Text = "Picture (Optional):";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Lavender;
            this.groupBox2.Controls.Add(this.pbImage);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.lblPath);
            this.groupBox2.Controls.Add(this.lblName);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(866, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 266);
            this.groupBox2.TabIndex = 60;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Student Image";
            // 
            // gbInserts
            // 
            this.gbInserts.BackColor = System.Drawing.Color.LightSkyBlue;
            this.gbInserts.Controls.Add(this.label2);
            this.gbInserts.Controls.Add(this.groupBox2);
            this.gbInserts.Controls.Add(this.txtStuNum);
            this.gbInserts.Controls.Add(this.btnUpload);
            this.gbInserts.Controls.Add(this.txtName);
            this.gbInserts.Controls.Add(this.label12);
            this.gbInserts.Controls.Add(this.label3);
            this.gbInserts.Controls.Add(this.txtSurname);
            this.gbInserts.Controls.Add(this.label4);
            this.gbInserts.Controls.Add(this.label5);
            this.gbInserts.Controls.Add(this.txtPhone);
            this.gbInserts.Controls.Add(this.cbGender);
            this.gbInserts.Controls.Add(this.label7);
            this.gbInserts.Controls.Add(this.dtpDateofBirth);
            this.gbInserts.Controls.Add(this.txtAddress);
            this.gbInserts.Controls.Add(this.btnBack);
            this.gbInserts.Controls.Add(this.label8);
            this.gbInserts.Controls.Add(this.btnUpdate);
            this.gbInserts.Controls.Add(this.groupBox1);
            this.gbInserts.Location = new System.Drawing.Point(31, 98);
            this.gbInserts.Name = "gbInserts";
            this.gbInserts.Size = new System.Drawing.Size(1159, 412);
            this.gbInserts.TabIndex = 61;
            this.gbInserts.TabStop = false;
            // 
            // gbDGV
            // 
            this.gbDGV.BackColor = System.Drawing.Color.LightSkyBlue;
            this.gbDGV.Controls.Add(this.label6);
            this.gbDGV.Controls.Add(this.dgvStudents);
            this.gbDGV.Controls.Add(this.label9);
            this.gbDGV.Controls.Add(this.dgvModules);
            this.gbDGV.Location = new System.Drawing.Point(31, 525);
            this.gbDGV.Name = "gbDGV";
            this.gbDGV.Size = new System.Drawing.Size(1159, 299);
            this.gbDGV.TabIndex = 62;
            this.gbDGV.TabStop = false;
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(1232, 849);
            this.Controls.Add(this.gbDGV);
            this.Controls.Add(this.gbInserts);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateForm";
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModules)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbInserts.ResumeLayout(false);
            this.gbInserts.PerformLayout();
            this.gbDGV.ResumeLayout(false);
            this.gbDGV.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnINF;
        private System.Windows.Forms.RadioButton rbtnMAT;
        private System.Windows.Forms.RadioButton rbtnWPR;
        private System.Windows.Forms.RadioButton rbtnLPR;
        private System.Windows.Forms.RadioButton rbtnPRG;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStuNum;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DateTimePicker dtpDateofBirth;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvModules;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gbInserts;
        private System.Windows.Forms.GroupBox gbDGV;
    }
}