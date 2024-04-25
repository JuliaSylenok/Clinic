namespace WindowsFormsApp2.Forms
{
    partial class Form_EditingPatient
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
            this.btn_DeleteAppointment = new System.Windows.Forms.Button();
            this.btn_AddPatientWithAppointment = new System.Windows.Forms.Button();
            this.dgvAppointmentsOfPatients = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker_Date = new System.Windows.Forms.DateTimePicker();
            this.comboBox_Category = new System.Windows.Forms.ComboBox();
            this.comboBox_Service = new System.Windows.Forms.ComboBox();
            this.comboBox_Time = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointmentsOfPatients)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_DeleteAppointment
            // 
            this.btn_DeleteAppointment.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_DeleteAppointment.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_DeleteAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeleteAppointment.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.btn_DeleteAppointment.ForeColor = System.Drawing.Color.White;
            this.btn_DeleteAppointment.Location = new System.Drawing.Point(507, 186);
            this.btn_DeleteAppointment.Name = "btn_DeleteAppointment";
            this.btn_DeleteAppointment.Size = new System.Drawing.Size(132, 43);
            this.btn_DeleteAppointment.TabIndex = 20;
            this.btn_DeleteAppointment.Text = "Видалити";
            this.btn_DeleteAppointment.UseVisualStyleBackColor = false;
            this.btn_DeleteAppointment.Click += new System.EventHandler(this.btn_DeleteAppointment_Click);
            // 
            // btn_AddPatientWithAppointment
            // 
            this.btn_AddPatientWithAppointment.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_AddPatientWithAppointment.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_AddPatientWithAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddPatientWithAppointment.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.btn_AddPatientWithAppointment.ForeColor = System.Drawing.Color.White;
            this.btn_AddPatientWithAppointment.Location = new System.Drawing.Point(645, 186);
            this.btn_AddPatientWithAppointment.Name = "btn_AddPatientWithAppointment";
            this.btn_AddPatientWithAppointment.Size = new System.Drawing.Size(132, 43);
            this.btn_AddPatientWithAppointment.TabIndex = 18;
            this.btn_AddPatientWithAppointment.Text = "Додати";
            this.btn_AddPatientWithAppointment.UseVisualStyleBackColor = false;
            this.btn_AddPatientWithAppointment.Click += new System.EventHandler(this.btn_AddPatientWithAppointment_Click);
            // 
            // dgvAppointmentsOfPatients
            // 
            this.dgvAppointmentsOfPatients.AllowUserToAddRows = false;
            this.dgvAppointmentsOfPatients.AllowUserToDeleteRows = false;
            this.dgvAppointmentsOfPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointmentsOfPatients.Location = new System.Drawing.Point(21, 244);
            this.dgvAppointmentsOfPatients.Name = "dgvAppointmentsOfPatients";
            this.dgvAppointmentsOfPatients.ReadOnly = true;
            this.dgvAppointmentsOfPatients.RowHeadersWidth = 51;
            this.dgvAppointmentsOfPatients.RowTemplate.Height = 24;
            this.dgvAppointmentsOfPatients.Size = new System.Drawing.Size(754, 175);
            this.dgvAppointmentsOfPatients.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(8, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 23);
            this.label6.TabIndex = 34;
            this.label6.Text = "Пацієнт:";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Name.Location = new System.Drawing.Point(111, 25);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(293, 28);
            this.textBox_Name.TabIndex = 33;
            this.textBox_Name.Text = "ПІБ";
            this.textBox_Name.Click += new System.EventHandler(this.textBox_Name_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.Location = new System.Drawing.Point(759, -3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(59, 33);
            this.btnClose.TabIndex = 35;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 23);
            this.label1.TabIndex = 43;
            this.label1.Text = "Оберіть категорію послуги:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(443, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 23);
            this.label3.TabIndex = 41;
            this.label3.Text = "Оберіть час запису:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(443, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 23);
            this.label5.TabIndex = 40;
            this.label5.Text = "Оберіть дату запису:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(8, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 23);
            this.label4.TabIndex = 39;
            this.label4.Text = "Оберіть послугу:";
            // 
            // dateTimePicker_Date
            // 
            this.dateTimePicker_Date.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker_Date.Location = new System.Drawing.Point(447, 84);
            this.dateTimePicker_Date.MinDate = new System.DateTime(2024, 2, 17, 0, 0, 0, 0);
            this.dateTimePicker_Date.Name = "dateTimePicker_Date";
            this.dateTimePicker_Date.Size = new System.Drawing.Size(314, 28);
            this.dateTimePicker_Date.TabIndex = 36;
            // 
            // comboBox_Category
            // 
            this.comboBox_Category.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_Category.FormattingEnabled = true;
            this.comboBox_Category.Location = new System.Drawing.Point(12, 83);
            this.comboBox_Category.Name = "comboBox_Category";
            this.comboBox_Category.Size = new System.Drawing.Size(392, 29);
            this.comboBox_Category.TabIndex = 44;
            this.comboBox_Category.SelectedIndexChanged += new System.EventHandler(this.comboBox_Category_SelectedIndexChanged);
            // 
            // comboBox_Service
            // 
            this.comboBox_Service.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_Service.FormattingEnabled = true;
            this.comboBox_Service.Location = new System.Drawing.Point(12, 139);
            this.comboBox_Service.Name = "comboBox_Service";
            this.comboBox_Service.Size = new System.Drawing.Size(392, 29);
            this.comboBox_Service.TabIndex = 45;
            this.comboBox_Service.SelectedIndexChanged += new System.EventHandler(this.comboBox_Service_SelectedIndexChanged);
            // 
            // comboBox_Time
            // 
            this.comboBox_Time.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_Time.FormattingEnabled = true;
            this.comboBox_Time.Location = new System.Drawing.Point(447, 139);
            this.comboBox_Time.Name = "comboBox_Time";
            this.comboBox_Time.Size = new System.Drawing.Size(314, 29);
            this.comboBox_Time.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(17, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(422, 23);
            this.label2.TabIndex = 47;
            this.label2.Text = "Оберіть послугу, яку бажаєте видалити";
            // 
            // Form_EditingPatient
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_Time);
            this.Controls.Add(this.comboBox_Service);
            this.Controls.Add(this.comboBox_Category);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker_Date);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.btn_DeleteAppointment);
            this.Controls.Add(this.btn_AddPatientWithAppointment);
            this.Controls.Add(this.dgvAppointmentsOfPatients);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_EditingPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "\'";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointmentsOfPatients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_DeleteAppointment;
        private System.Windows.Forms.Button btn_AddPatientWithAppointment;
        private System.Windows.Forms.DataGridView dgvAppointmentsOfPatients;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Date;
        private System.Windows.Forms.ComboBox comboBox_Category;
        private System.Windows.Forms.ComboBox comboBox_Service;
        private System.Windows.Forms.ComboBox comboBox_Time;
        private System.Windows.Forms.Label label2;
    }
}