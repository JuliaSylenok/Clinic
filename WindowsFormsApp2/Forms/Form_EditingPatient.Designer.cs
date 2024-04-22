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
            this.button4 = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointmentsOfPatients)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(645, 112);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(132, 55);
            this.button4.TabIndex = 21;
            this.button4.Text = "Зберегти зміни";
            this.button4.UseVisualStyleBackColor = false;
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
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(21, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 21);
            this.label6.TabIndex = 34;
            this.label6.Text = "Пацієнт:";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic);
            this.textBox_Name.Location = new System.Drawing.Point(111, 25);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(293, 26);
            this.textBox_Name.TabIndex = 33;
            this.textBox_Name.Text = "ПІБ";
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
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(19, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 21);
            this.label1.TabIndex = 43;
            this.label1.Text = "Оберіть категорію послуги:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(417, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 21);
            this.label3.TabIndex = 41;
            this.label3.Text = "Оберіть час запису:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(15, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 21);
            this.label5.TabIndex = 40;
            this.label5.Text = "Оберіть дату запису:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 21);
            this.label4.TabIndex = 39;
            this.label4.Text = "Оберіть послугу:";
            // 
            // dateTimePicker_Date
            // 
            this.dateTimePicker_Date.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker_Date.Location = new System.Drawing.Point(12, 193);
            this.dateTimePicker_Date.MinDate = new System.DateTime(2024, 2, 17, 0, 0, 0, 0);
            this.dateTimePicker_Date.Name = "dateTimePicker_Date";
            this.dateTimePicker_Date.Size = new System.Drawing.Size(392, 26);
            this.dateTimePicker_Date.TabIndex = 36;
            // 
            // comboBox_Category
            // 
            this.comboBox_Category.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic);
            this.comboBox_Category.FormattingEnabled = true;
            this.comboBox_Category.Location = new System.Drawing.Point(12, 83);
            this.comboBox_Category.Name = "comboBox_Category";
            this.comboBox_Category.Size = new System.Drawing.Size(392, 26);
            this.comboBox_Category.TabIndex = 44;
            // 
            // comboBox_Service
            // 
            this.comboBox_Service.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic);
            this.comboBox_Service.FormattingEnabled = true;
            this.comboBox_Service.Location = new System.Drawing.Point(12, 139);
            this.comboBox_Service.Name = "comboBox_Service";
            this.comboBox_Service.Size = new System.Drawing.Size(392, 26);
            this.comboBox_Service.TabIndex = 45;
            // 
            // comboBox_Time
            // 
            this.comboBox_Time.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic);
            this.comboBox_Time.FormattingEnabled = true;
            this.comboBox_Time.Location = new System.Drawing.Point(421, 141);
            this.comboBox_Time.Name = "comboBox_Time";
            this.comboBox_Time.Size = new System.Drawing.Size(188, 26);
            this.comboBox_Time.TabIndex = 46;
            // 
            // Form_EditingPatient
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_DeleteAppointment);
            this.Controls.Add(this.btn_AddPatientWithAppointment);
            this.Controls.Add(this.dgvAppointmentsOfPatients);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_EditingPatient";
            this.Text = "\'";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointmentsOfPatients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button4;
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
    }
}