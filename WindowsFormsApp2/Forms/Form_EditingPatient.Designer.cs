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
            this.button3 = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.dgvAppointmentsOfPatients = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.domainUpDown2 = new System.Windows.Forms.DomainUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.domainUpDown3 = new System.Windows.Forms.DomainUpDown();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
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
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(507, 186);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 43);
            this.button3.TabIndex = 20;
            this.button3.Text = "Видалити";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnAbout.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.Location = new System.Drawing.Point(645, 186);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(132, 43);
            this.btnAbout.TabIndex = 18;
            this.btnAbout.Text = "Додати";
            this.btnAbout.UseVisualStyleBackColor = false;
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
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic);
            this.textBox5.Location = new System.Drawing.Point(111, 25);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(293, 26);
            this.textBox5.TabIndex = 33;
            this.textBox5.Text = "ПІБ";
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
            // domainUpDown2
            // 
            this.domainUpDown2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.domainUpDown2.Location = new System.Drawing.Point(16, 82);
            this.domainUpDown2.Name = "domainUpDown2";
            this.domainUpDown2.Size = new System.Drawing.Size(388, 26);
            this.domainUpDown2.TabIndex = 42;
            this.domainUpDown2.Text = "Обрати";
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
            // domainUpDown3
            // 
            this.domainUpDown3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.domainUpDown3.Location = new System.Drawing.Point(16, 136);
            this.domainUpDown3.Name = "domainUpDown3";
            this.domainUpDown3.Size = new System.Drawing.Size(388, 26);
            this.domainUpDown3.TabIndex = 38;
            this.domainUpDown3.Text = "Обрати";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker2.Location = new System.Drawing.Point(12, 193);
            this.dateTimePicker2.MinDate = new System.DateTime(2024, 2, 17, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(392, 26);
            this.dateTimePicker2.TabIndex = 36;
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.domainUpDown1.Location = new System.Drawing.Point(414, 137);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(200, 26);
            this.domainUpDown1.TabIndex = 37;
            this.domainUpDown1.Text = "Обрати";
            // 
            // Form_EditingPatient
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.domainUpDown2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.domainUpDown3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.domainUpDown1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnAbout);
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.DataGridView dgvAppointmentsOfPatients;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DomainUpDown domainUpDown2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DomainUpDown domainUpDown3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
    }
}