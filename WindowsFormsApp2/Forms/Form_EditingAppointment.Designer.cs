namespace WindowsFormsApp2.Forms
{
    partial class Form_EditingAppointment
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCancelAppointment = new System.Windows.Forms.Button();
            this.btnRescheduleAppointment = new System.Windows.Forms.Button();
            this.dgwMyAppointments = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerData = new System.Windows.Forms.DateTimePicker();
            this.comboBox_Time = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMyAppointments)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.Location = new System.Drawing.Point(759, -6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(59, 33);
            this.btnClose.TabIndex = 52;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCancelAppointment
            // 
            this.btnCancelAppointment.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnCancelAppointment.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.btnCancelAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelAppointment.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnCancelAppointment.ForeColor = System.Drawing.Color.White;
            this.btnCancelAppointment.Location = new System.Drawing.Point(549, 169);
            this.btnCancelAppointment.Name = "btnCancelAppointment";
            this.btnCancelAppointment.Size = new System.Drawing.Size(228, 43);
            this.btnCancelAppointment.TabIndex = 38;
            this.btnCancelAppointment.Text = "Видалити запис";
            this.btnCancelAppointment.UseVisualStyleBackColor = false;
            this.btnCancelAppointment.Click += new System.EventHandler(this.btnCancelAppointment_Click);
            // 
            // btnRescheduleAppointment
            // 
            this.btnRescheduleAppointment.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnRescheduleAppointment.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.btnRescheduleAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRescheduleAppointment.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnRescheduleAppointment.ForeColor = System.Drawing.Color.White;
            this.btnRescheduleAppointment.Location = new System.Drawing.Point(32, 169);
            this.btnRescheduleAppointment.Name = "btnRescheduleAppointment";
            this.btnRescheduleAppointment.Size = new System.Drawing.Size(228, 43);
            this.btnRescheduleAppointment.TabIndex = 37;
            this.btnRescheduleAppointment.Text = "Перенести запис";
            this.btnRescheduleAppointment.UseVisualStyleBackColor = false;
            this.btnRescheduleAppointment.Click += new System.EventHandler(this.btnRescheduleAppointment_Click);
            // 
            // dgwMyAppointments
            // 
            this.dgwMyAppointments.AllowUserToAddRows = false;
            this.dgwMyAppointments.AllowUserToDeleteRows = false;
            this.dgwMyAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMyAppointments.Location = new System.Drawing.Point(23, 258);
            this.dgwMyAppointments.Name = "dgwMyAppointments";
            this.dgwMyAppointments.ReadOnly = true;
            this.dgwMyAppointments.RowHeadersWidth = 51;
            this.dgwMyAppointments.RowTemplate.Height = 24;
            this.dgwMyAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwMyAppointments.Size = new System.Drawing.Size(754, 175);
            this.dgwMyAppointments.TabIndex = 36;
            this.dgwMyAppointments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwMyAppointments_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(35, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(399, 23);
            this.label3.TabIndex = 56;
            this.label3.Text = "Оберіть час, на який хочете пенести:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(35, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(425, 23);
            this.label5.TabIndex = 55;
            this.label5.Text = "Оберіть дату, на яку хочете перенести:";
            // 
            // dateTimePickerData
            // 
            this.dateTimePickerData.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerData.Location = new System.Drawing.Point(39, 50);
            this.dateTimePickerData.MinDate = new System.DateTime(2024, 2, 17, 0, 0, 0, 0);
            this.dateTimePickerData.Name = "dateTimePickerData";
            this.dateTimePickerData.Size = new System.Drawing.Size(421, 28);
            this.dateTimePickerData.TabIndex = 53;
            // 
            // comboBox_Time
            // 
            this.comboBox_Time.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_Time.FormattingEnabled = true;
            this.comboBox_Time.Location = new System.Drawing.Point(39, 119);
            this.comboBox_Time.Name = "comboBox_Time";
            this.comboBox_Time.Size = new System.Drawing.Size(421, 29);
            this.comboBox_Time.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(28, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(494, 23);
            this.label1.TabIndex = 58;
            this.label1.Text = "Оберіть запис, який хочете пенести/видалити:";
            // 
            // Form_EditingAppointment
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Time);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePickerData);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCancelAppointment);
            this.Controls.Add(this.btnRescheduleAppointment);
            this.Controls.Add(this.dgwMyAppointments);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_EditingAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "\'";
            ((System.ComponentModel.ISupportInitialize)(this.dgwMyAppointments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCancelAppointment;
        private System.Windows.Forms.Button btnRescheduleAppointment;
        private System.Windows.Forms.DataGridView dgwMyAppointments;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerData;
        private System.Windows.Forms.ComboBox comboBox_Time;
        private System.Windows.Forms.Label label1;
    }
}