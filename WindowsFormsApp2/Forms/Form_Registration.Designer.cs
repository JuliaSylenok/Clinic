namespace WindowsFormsApp2.Forms
{
    partial class Form_Registration
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
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelPatronymic = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.tbPatronymic = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.btnRegistration = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.labelPassword);
            this.groupBox.Controls.Add(this.labelPhone);
            this.groupBox.Controls.Add(this.labelSurname);
            this.groupBox.Controls.Add(this.labelPatronymic);
            this.groupBox.Controls.Add(this.tbPassword);
            this.groupBox.Controls.Add(this.tbPhone);
            this.groupBox.Controls.Add(this.tbSurname);
            this.groupBox.Controls.Add(this.tbPatronymic);
            this.groupBox.Controls.Add(this.tbName);
            this.groupBox.Controls.Add(this.labelName);
            this.groupBox.Controls.Add(this.btnRegistration);
            this.groupBox.Location = new System.Drawing.Point(108, 45);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(614, 397);
            this.groupBox.TabIndex = 2;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Реєстрація";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword.Location = new System.Drawing.Point(144, 285);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(90, 23);
            this.labelPassword.TabIndex = 8;
            this.labelPassword.Text = "Пароль:";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPhone.Location = new System.Drawing.Point(38, 204);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(195, 23);
            this.labelPhone.TabIndex = 8;
            this.labelPhone.Text = "Номер телефону:";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSurname.Location = new System.Drawing.Point(119, 155);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(112, 23);
            this.labelSurname.TabIndex = 8;
            this.labelSurname.Text = "Прізвище:";
            // 
            // labelPatronymic
            // 
            this.labelPatronymic.AutoSize = true;
            this.labelPatronymic.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPatronymic.Location = new System.Drawing.Point(96, 107);
            this.labelPatronymic.Name = "labelPatronymic";
            this.labelPatronymic.Size = new System.Drawing.Size(137, 23);
            this.labelPatronymic.TabIndex = 8;
            this.labelPatronymic.Text = "По батькові:";
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPassword.Location = new System.Drawing.Point(238, 285);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(268, 28);
            this.tbPassword.TabIndex = 7;
            this.tbPassword.Text = "Введіть";
            this.tbPassword.Click += new System.EventHandler(this.tbPassword_Click);
            // 
            // tbPhone
            // 
            this.tbPhone.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPhone.Location = new System.Drawing.Point(238, 204);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(268, 28);
            this.tbPhone.TabIndex = 6;
            this.tbPhone.Text = "+38(0ХХ)-ХХХХХХХ";
            this.tbPhone.Click += new System.EventHandler(this.tbPhone_Click);
            // 
            // tbSurname
            // 
            this.tbSurname.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSurname.Location = new System.Drawing.Point(238, 155);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(268, 28);
            this.tbSurname.TabIndex = 5;
            this.tbSurname.Text = "Введіть";
            this.tbSurname.Click += new System.EventHandler(this.tbSurname_Click);
            // 
            // tbPatronymic
            // 
            this.tbPatronymic.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPatronymic.Location = new System.Drawing.Point(238, 107);
            this.tbPatronymic.Name = "tbPatronymic";
            this.tbPatronymic.Size = new System.Drawing.Size(268, 28);
            this.tbPatronymic.TabIndex = 4;
            this.tbPatronymic.Text = "Введіть";
            this.tbPatronymic.Click += new System.EventHandler(this.tbPatronymic_Click);
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbName.Location = new System.Drawing.Point(238, 59);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(268, 28);
            this.tbName.TabIndex = 3;
            this.tbName.Text = "Введіть";
            this.tbName.Click += new System.EventHandler(this.tbName_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(180, 59);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(53, 23);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Ім\'я:";
            // 
            // btnRegistration
            // 
            this.btnRegistration.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnRegistration.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegistration.Location = new System.Drawing.Point(209, 339);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(202, 52);
            this.btnRegistration.TabIndex = 1;
            this.btnRegistration.Text = "Зареєструватися";
            this.btnRegistration.UseVisualStyleBackColor = false;
            this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.Location = new System.Drawing.Point(775, -6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(48, 44);
            this.btnClose.TabIndex = 36;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form_Registration
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(822, 483);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "\'";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        
        //Групує всі компоненти
        private System.Windows.Forms.GroupBox groupBox;

        //Повідоблення для користувача
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelPatronymic;
        private System.Windows.Forms.Label labelName;
        
        //Поля, які має заповнити користувач (ПІБ,номер телефону, пароль)
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.TextBox tbPatronymic;
        private System.Windows.Forms.TextBox tbName;
        //Кнопка яка реалізує мотод Register класу Guest
        private System.Windows.Forms.Button btnRegistration;
        //Закриття форми Form_Registration.cs
        private System.Windows.Forms.Button btnClose;
    }
}