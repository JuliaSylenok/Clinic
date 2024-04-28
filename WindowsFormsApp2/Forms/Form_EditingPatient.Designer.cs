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
            this.labelName = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.labelService = new System.Windows.Forms.Label();
            this.dateTimePicker_Date = new System.Windows.Forms.DateTimePicker();
            this.comboBox_Category = new System.Windows.Forms.ComboBox();
            this.comboBox_Service = new System.Windows.Forms.ComboBox();
            this.comboBox_Time = new System.Windows.Forms.ComboBox();
            this.label = new System.Windows.Forms.Label();
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
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelName.Location = new System.Drawing.Point(8, 26);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(96, 23);
            this.labelName.TabIndex = 34;
            this.labelName.Text = "Пацієнт:";
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
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCategory.Location = new System.Drawing.Point(8, 57);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(295, 23);
            this.labelCategory.TabIndex = 43;
            this.labelCategory.Text = "Оберіть категорію послуги:";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(443, 113);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(218, 23);
            this.labelTime.TabIndex = 41;
            this.labelTime.Text = "Оберіть час запису:";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelData.Location = new System.Drawing.Point(443, 57);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(230, 23);
            this.labelData.TabIndex = 40;
            this.labelData.Text = "Оберіть дату запису:";
            // 
            // labelService
            // 
            this.labelService.AutoSize = true;
            this.labelService.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelService.Location = new System.Drawing.Point(8, 115);
            this.labelService.Name = "labelService";
            this.labelService.Size = new System.Drawing.Size(185, 23);
            this.labelService.TabIndex = 39;
            this.labelService.Text = "Оберіть послугу:";
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
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(17, 218);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(422, 23);
            this.label.TabIndex = 47;
            this.label.Text = "Оберіть послугу, яку бажаєте видалити";
            // 
            // Form_EditingPatient
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label);
            this.Controls.Add(this.comboBox_Time);
            this.Controls.Add(this.comboBox_Service);
            this.Controls.Add(this.comboBox_Category);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.labelService);
            this.Controls.Add(this.dateTimePicker_Date);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.labelName);
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

        //Закриття форми
        private System.Windows.Forms.Button btnClose;
        // Реалізує метод видалення запису користуваач на прийом
        private System.Windows.Forms.Button btn_DeleteAppointment;
        //Реалізує метод додавання коритсувача та його запису до списку коритсувачів та записів
        private System.Windows.Forms.Button btn_AddPatientWithAppointment;
       
        //Таблиця записів користувачів
        private System.Windows.Forms.DataGridView dgvAppointmentsOfPatients;
       
        //Повідомлення користувачам
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label labelService;

        //Поля які мають бути заповлені (Дата, ПІБ користувача, Категорія, Сервіс, Час)
        private System.Windows.Forms.DateTimePicker dateTimePicker_Date;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.ComboBox comboBox_Category;
        private System.Windows.Forms.ComboBox comboBox_Service;
        private System.Windows.Forms.ComboBox comboBox_Time;
    }
}