namespace Programming_282_Project_Milestone_2.PresentationLayer
{
    partial class AddStudent
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStuNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDateofBirth = new System.Windows.Forms.DateTimePicker();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPath = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gbContainer = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.gbContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Wide Latin", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 47);
            this.label1.TabIndex = 6;
            this.label1.Text = "Add a Student";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.rbtnINF);
            this.groupBox1.Controls.Add(this.rbtnMAT);
            this.groupBox1.Controls.Add(this.rbtnWPR);
            this.groupBox1.Controls.Add(this.rbtnLPR);
            this.groupBox1.Controls.Add(this.rbtnPRG);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(610, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 184);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modules";
            // 
            // rbtnINF
            // 
            this.rbtnINF.AutoSize = true;
            this.rbtnINF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnINF.Location = new System.Drawing.Point(6, 30);
            this.rbtnINF.Name = "rbtnINF";
            this.rbtnINF.Size = new System.Drawing.Size(173, 24);
            this.rbtnINF.TabIndex = 4;
            this.rbtnINF.TabStop = true;
            this.rbtnINF.Text = "Information Systems";
            this.rbtnINF.UseVisualStyleBackColor = true;
            // 
            // rbtnMAT
            // 
            this.rbtnMAT.AutoSize = true;
            this.rbtnMAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMAT.Location = new System.Drawing.Point(6, 120);
            this.rbtnMAT.Name = "rbtnMAT";
            this.rbtnMAT.Size = new System.Drawing.Size(118, 24);
            this.rbtnMAT.TabIndex = 3;
            this.rbtnMAT.TabStop = true;
            this.rbtnMAT.Text = "Mathematics";
            this.rbtnMAT.UseVisualStyleBackColor = true;
            // 
            // rbtnWPR
            // 
            this.rbtnWPR.AutoSize = true;
            this.rbtnWPR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnWPR.Location = new System.Drawing.Point(6, 90);
            this.rbtnWPR.Name = "rbtnWPR";
            this.rbtnWPR.Size = new System.Drawing.Size(167, 24);
            this.rbtnWPR.TabIndex = 2;
            this.rbtnWPR.TabStop = true;
            this.rbtnWPR.Text = "Web Developement";
            this.rbtnWPR.UseVisualStyleBackColor = true;
            // 
            // rbtnLPR
            // 
            this.rbtnLPR.AutoSize = true;
            this.rbtnLPR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnLPR.Location = new System.Drawing.Point(6, 60);
            this.rbtnLPR.Name = "rbtnLPR";
            this.rbtnLPR.Size = new System.Drawing.Size(169, 24);
            this.rbtnLPR.TabIndex = 1;
            this.rbtnLPR.TabStop = true;
            this.rbtnLPR.Text = "Linear Programming";
            this.rbtnLPR.UseVisualStyleBackColor = true;
            // 
            // rbtnPRG
            // 
            this.rbtnPRG.AutoSize = true;
            this.rbtnPRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnPRG.Location = new System.Drawing.Point(6, 150);
            this.rbtnPRG.Name = "rbtnPRG";
            this.rbtnPRG.Size = new System.Drawing.Size(121, 24);
            this.rbtnPRG.TabIndex = 0;
            this.rbtnPRG.TabStop = true;
            this.rbtnPRG.Text = "Programming";
            this.rbtnPRG.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Red;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(418, 434);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(171, 58);
            this.btnBack.TabIndex = 42;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.Location = new System.Drawing.Point(224, 434);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(171, 58);
            this.btnAddStudent.TabIndex = 41;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(224, 323);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(367, 32);
            this.txtAddress.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(107, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 26);
            this.label8.TabIndex = 38;
            this.label8.Text = "Address:";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(224, 266);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(367, 32);
            this.txtPhone.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 26);
            this.label2.TabIndex = 28;
            this.label2.Text = "Student Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 26);
            this.label3.TabIndex = 30;
            this.label3.Text = "First Name:";
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.Location = new System.Drawing.Point(224, 152);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(367, 32);
            this.txtSurname.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(123, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 26);
            this.label7.TabIndex = 36;
            this.label7.Text = "Phone:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(224, 94);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(367, 32);
            this.txtName.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(99, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 26);
            this.label4.TabIndex = 32;
            this.label4.Text = "Surname:";
            // 
            // txtStuNumber
            // 
            this.txtStuNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStuNumber.Location = new System.Drawing.Point(224, 37);
            this.txtStuNumber.Name = "txtStuNumber";
            this.txtStuNumber.Size = new System.Drawing.Size(367, 32);
            this.txtStuNumber.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(63, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 26);
            this.label5.TabIndex = 34;
            this.label5.Text = "Date Of Birth:";
            // 
            // dtpDateofBirth
            // 
            this.dtpDateofBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateofBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateofBirth.Location = new System.Drawing.Point(224, 209);
            this.dtpDateofBirth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDateofBirth.Name = "dtpDateofBirth";
            this.dtpDateofBirth.Size = new System.Drawing.Size(206, 32);
            this.dtpDateofBirth.TabIndex = 43;
            // 
            // cbGender
            // 
            this.cbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbGender.Location = new System.Drawing.Point(436, 208);
            this.cbGender.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(154, 34);
            this.cbGender.TabIndex = 44;
            this.cbGender.Text = "Gender";
            // 
            // pbImage
            // 
            this.pbImage.BackColor = System.Drawing.Color.White;
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.Location = new System.Drawing.Point(13, 17);
            this.pbImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(177, 191);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 45;
            this.pbImage.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 392);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 26);
            this.label6.TabIndex = 47;
            this.label6.Text = "Picture (Optional):";
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Location = new System.Drawing.Point(224, 380);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(205, 38);
            this.btnUpload.TabIndex = 48;
            this.btnUpload.Text = "Upload Image";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 219);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 49;
            this.label9.Text = "Name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 249);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 50;
            this.label10.Text = "Path:";
            this.label10.Visible = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(57, 219);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(16, 13);
            this.lblName.TabIndex = 51;
            this.lblName.Text = "...";
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(42, 249);
            this.lblPath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(0, 13);
            this.lblPath.TabIndex = 52;
            this.lblPath.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Lavender;
            this.groupBox2.Controls.Add(this.pbImage);
            this.groupBox2.Controls.Add(this.lblPath);
            this.groupBox2.Controls.Add(this.lblName);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(610, 214);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(202, 281);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Student Image";
            // 
            // gbContainer
            // 
            this.gbContainer.BackColor = System.Drawing.Color.LightSkyBlue;
            this.gbContainer.Controls.Add(this.label2);
            this.gbContainer.Controls.Add(this.groupBox2);
            this.gbContainer.Controls.Add(this.label3);
            this.gbContainer.Controls.Add(this.btnUpload);
            this.gbContainer.Controls.Add(this.txtSurname);
            this.gbContainer.Controls.Add(this.label6);
            this.gbContainer.Controls.Add(this.label7);
            this.gbContainer.Controls.Add(this.cbGender);
            this.gbContainer.Controls.Add(this.txtPhone);
            this.gbContainer.Controls.Add(this.dtpDateofBirth);
            this.gbContainer.Controls.Add(this.txtName);
            this.gbContainer.Controls.Add(this.groupBox1);
            this.gbContainer.Controls.Add(this.label8);
            this.gbContainer.Controls.Add(this.label4);
            this.gbContainer.Controls.Add(this.btnBack);
            this.gbContainer.Controls.Add(this.txtAddress);
            this.gbContainer.Controls.Add(this.txtStuNumber);
            this.gbContainer.Controls.Add(this.label5);
            this.gbContainer.Controls.Add(this.btnAddStudent);
            this.gbContainer.Location = new System.Drawing.Point(24, 68);
            this.gbContainer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbContainer.Name = "gbContainer";
            this.gbContainer.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbContainer.Size = new System.Drawing.Size(868, 526);
            this.gbContainer.TabIndex = 54;
            this.gbContainer.TabStop = false;
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(921, 624);
            this.Controls.Add(this.gbContainer);
            this.Controls.Add(this.label1);
            this.Name = "AddStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddStudent";
            this.Load += new System.EventHandler(this.AddStudent_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbContainer.ResumeLayout(false);
            this.gbContainer.PerformLayout();
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
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStuNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDateofBirth;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gbContainer;
    }
}