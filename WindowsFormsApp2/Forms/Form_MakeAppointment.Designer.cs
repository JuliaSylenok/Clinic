namespace WindowsFormsApp2.Forms
{
    partial class Form_MakeAppointment
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.comboBox_Time = new System.Windows.Forms.ComboBox();
            this.comboBox_Service = new System.Windows.Forms.ComboBox();
            this.comboBox_Category = new System.Windows.Forms.ComboBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.btn_Appoinment = new System.Windows.Forms.Button();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.label_Service = new System.Windows.Forms.Label();
            this.dateTimePicker_Date = new System.Windows.Forms.DateTimePicker();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.comboBox_Time);
            this.groupBox.Controls.Add(this.comboBox_Service);
            this.groupBox.Controls.Add(this.comboBox_Category);
            this.groupBox.Controls.Add(this.labelCategory);
            this.groupBox.Controls.Add(this.btn_Appoinment);
            this.groupBox.Controls.Add(this.labelTime);
            this.groupBox.Controls.Add(this.labelData);
            this.groupBox.Controls.Add(this.label_Service);
            this.groupBox.Controls.Add(this.dateTimePicker_Date);
            this.groupBox.Location = new System.Drawing.Point(69, 41);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(684, 379);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Запис до лікаря";
            // 
            // comboBox_Time
            // 
            this.comboBox_Time.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic);
            this.comboBox_Time.FormattingEnabled = true;
            this.comboBox_Time.Location = new System.Drawing.Point(149, 264);
            this.comboBox_Time.Name = "comboBox_Time";
            this.comboBox_Time.Size = new System.Drawing.Size(388, 26);
            this.comboBox_Time.TabIndex = 22;
            // 
            // comboBox_Service
            // 
            this.comboBox_Service.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic);
            this.comboBox_Service.FormattingEnabled = true;
            this.comboBox_Service.Location = new System.Drawing.Point(149, 127);
            this.comboBox_Service.Name = "comboBox_Service";
            this.comboBox_Service.Size = new System.Drawing.Size(388, 26);
            this.comboBox_Service.TabIndex = 21;
            // 
            // comboBox_Category
            // 
            this.comboBox_Category.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic);
            this.comboBox_Category.FormattingEnabled = true;
            this.comboBox_Category.Location = new System.Drawing.Point(149, 61);
            this.comboBox_Category.Name = "comboBox_Category";
            this.comboBox_Category.Size = new System.Drawing.Size(388, 26);
            this.comboBox_Category.TabIndex = 20;
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCategory.Location = new System.Drawing.Point(152, 37);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(258, 21);
            this.labelCategory.TabIndex = 14;
            this.labelCategory.Text = "Оберіть категорію послуги:";
            // 
            // btn_Appoinment
            // 
            this.btn_Appoinment.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_Appoinment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Appoinment.Location = new System.Drawing.Point(238, 318);
            this.btn_Appoinment.Name = "btn_Appoinment";
            this.btn_Appoinment.Size = new System.Drawing.Size(202, 52);
            this.btn_Appoinment.TabIndex = 8;
            this.btn_Appoinment.Text = "Записатися";
            this.btn_Appoinment.UseVisualStyleBackColor = false;
            this.btn_Appoinment.Click += new System.EventHandler(this.btn_Appoinment_Click);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(152, 240);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(192, 21);
            this.labelTime.TabIndex = 12;
            this.labelTime.Text = "Оберіть час запису:";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelData.Location = new System.Drawing.Point(152, 169);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(201, 21);
            this.labelData.TabIndex = 11;
            this.labelData.Text = "Оберіть дату запису:";
            // 
            // label_Service
            // 
            this.label_Service.AutoSize = true;
            this.label_Service.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Service.Location = new System.Drawing.Point(152, 103);
            this.label_Service.Name = "label_Service";
            this.label_Service.Size = new System.Drawing.Size(399, 21);
            this.label_Service.TabIndex = 10;
            this.label_Service.Text = "Оберіть послугу на яку хочете записатися:\r\n";
            // 
            // dateTimePicker_Date
            // 
            this.dateTimePicker_Date.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker_Date.Location = new System.Drawing.Point(149, 194);
            this.dateTimePicker_Date.MinDate = new System.DateTime(2024, 2, 17, 0, 0, 0, 0);
            this.dateTimePicker_Date.Name = "dateTimePicker_Date";
            this.dateTimePicker_Date.Size = new System.Drawing.Size(388, 26);
            this.dateTimePicker_Date.TabIndex = 6;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.Location = new System.Drawing.Point(767, -2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(59, 33);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form_MakeAppointment
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(822, 483);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_MakeAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_MakeAppointment";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion


        //Групує всі компоненти
        private System.Windows.Forms.GroupBox groupBox;
        //Закриття форми
        private System.Windows.Forms.Button btnClose;

        private System.Windows.Forms.Button btn_Appoinment;

        //Повідоблення для користувача
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label label_Service;
       
        //Поля які має заповнити користува (Категорія/Послуга/Дата/Час)
        private System.Windows.Forms.DateTimePicker dateTimePicker_Date;
        private System.Windows.Forms.ComboBox comboBox_Time;
        private System.Windows.Forms.ComboBox comboBox_Service;
        private System.Windows.Forms.ComboBox comboBox_Category;
    }
}