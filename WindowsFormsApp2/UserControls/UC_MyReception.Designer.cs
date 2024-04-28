namespace WindowsFormsApp2.UserControls
{
    partial class UC_MyReception
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMyReception = new System.Windows.Forms.Panel();
            this.button_Exit = new System.Windows.Forms.Button();
            this.labelMyReception = new System.Windows.Forms.Label();
            this.btnMakeAppointment = new System.Windows.Forms.Button();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnEditAppiontment = new System.Windows.Forms.Button();
            this.panelYourReception = new System.Windows.Forms.Panel();
            this.labelYourReception = new System.Windows.Forms.Label();
            this.dgwMyAppointments = new System.Windows.Forms.DataGridView();
            this.panelMyReception.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelYourReception.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMyAppointments)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMyReception
            // 
            this.panelMyReception.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panelMyReception.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMyReception.Controls.Add(this.button_Exit);
            this.panelMyReception.Controls.Add(this.labelMyReception);
            this.panelMyReception.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMyReception.Location = new System.Drawing.Point(0, 0);
            this.panelMyReception.Name = "panelMyReception";
            this.panelMyReception.Size = new System.Drawing.Size(629, 45);
            this.panelMyReception.TabIndex = 0;
            // 
            // button_Exit
            // 
            this.button_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Exit.FlatAppearance.BorderSize = 0;
            this.button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Exit.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Exit.ForeColor = System.Drawing.Color.White;
            this.button_Exit.Location = new System.Drawing.Point(593, -1);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(35, 33);
            this.button_Exit.TabIndex = 5;
            this.button_Exit.Text = "X";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // labelMyReception
            // 
            this.labelMyReception.AutoSize = true;
            this.labelMyReception.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMyReception.ForeColor = System.Drawing.Color.White;
            this.labelMyReception.Location = new System.Drawing.Point(4, 6);
            this.labelMyReception.Name = "labelMyReception";
            this.labelMyReception.Size = new System.Drawing.Size(142, 27);
            this.labelMyReception.TabIndex = 1;
            this.labelMyReception.Text = "Мої записи";
            // 
            // btnMakeAppointment
            // 
            this.btnMakeAppointment.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnMakeAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMakeAppointment.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMakeAppointment.ForeColor = System.Drawing.Color.White;
            this.btnMakeAppointment.Location = new System.Drawing.Point(325, 6);
            this.btnMakeAppointment.Name = "btnMakeAppointment";
            this.btnMakeAppointment.Size = new System.Drawing.Size(280, 55);
            this.btnMakeAppointment.TabIndex = 4;
            this.btnMakeAppointment.Text = "Записатися на прийом до лікаря";
            this.btnMakeAppointment.UseVisualStyleBackColor = false;
            this.btnMakeAppointment.Click += new System.EventHandler(this.btnMakeAppointment_Click);
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.AliceBlue;
            this.panelButtons.Controls.Add(this.btnMakeAppointment);
            this.panelButtons.Controls.Add(this.btnEditAppiontment);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 408);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(629, 75);
            this.panelButtons.TabIndex = 1;
            // 
            // btnEditAppiontment
            // 
            this.btnEditAppiontment.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnEditAppiontment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditAppiontment.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditAppiontment.ForeColor = System.Drawing.Color.White;
            this.btnEditAppiontment.Location = new System.Drawing.Point(20, 6);
            this.btnEditAppiontment.Name = "btnEditAppiontment";
            this.btnEditAppiontment.Size = new System.Drawing.Size(258, 55);
            this.btnEditAppiontment.TabIndex = 5;
            this.btnEditAppiontment.Text = "Перенести/Відмінити запис";
            this.btnEditAppiontment.UseVisualStyleBackColor = false;
            this.btnEditAppiontment.Click += new System.EventHandler(this.btnEditAppiontment_Click);
            // 
            // panelYourReception
            // 
            this.panelYourReception.BackColor = System.Drawing.Color.AliceBlue;
            this.panelYourReception.Controls.Add(this.labelYourReception);
            this.panelYourReception.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelYourReception.Location = new System.Drawing.Point(0, 45);
            this.panelYourReception.Name = "panelYourReception";
            this.panelYourReception.Size = new System.Drawing.Size(629, 50);
            this.panelYourReception.TabIndex = 2;
            // 
            // labelYourReception
            // 
            this.labelYourReception.AutoSize = true;
            this.labelYourReception.Font = new System.Drawing.Font("Century Gothic", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelYourReception.ForeColor = System.Drawing.Color.Black;
            this.labelYourReception.Location = new System.Drawing.Point(16, 15);
            this.labelYourReception.Name = "labelYourReception";
            this.labelYourReception.Size = new System.Drawing.Size(232, 22);
            this.labelYourReception.TabIndex = 2;
            this.labelYourReception.Text = "Ваші записи на прийом:";
            // 
            // dgwMyAppointments
            // 
            this.dgwMyAppointments.AllowUserToAddRows = false;
            this.dgwMyAppointments.AllowUserToDeleteRows = false;
            this.dgwMyAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMyAppointments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwMyAppointments.Location = new System.Drawing.Point(0, 95);
            this.dgwMyAppointments.Name = "dgwMyAppointments";
            this.dgwMyAppointments.ReadOnly = true;
            this.dgwMyAppointments.RowHeadersWidth = 51;
            this.dgwMyAppointments.RowTemplate.Height = 24;
            this.dgwMyAppointments.Size = new System.Drawing.Size(629, 313);
            this.dgwMyAppointments.TabIndex = 3;
            // 
            // UC_MyReception
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.Controls.Add(this.dgwMyAppointments);
            this.Controls.Add(this.panelYourReception);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelMyReception);
            this.Name = "UC_MyReception";
            this.Size = new System.Drawing.Size(629, 483);
            this.panelMyReception.ResumeLayout(false);
            this.panelMyReception.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.panelYourReception.ResumeLayout(false);
            this.panelYourReception.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMyAppointments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        
        //Панель на якій розміщено labelMyReception
        private System.Windows.Forms.Panel panelMyReception;
        //Панель на якій розміщено кнопки btnMakeAppointment, btnEditAppiontment
        private System.Windows.Forms.Panel panelButtons;
        //Повідомлення з інформацію для користувача
        private System.Windows.Forms.Label labelMyReception;
        //Реалізує перехід між формами FormMain та Form_MakeAppointment 
        private System.Windows.Forms.Button btnMakeAppointment;
        //Реалізує перехід між формами FormMain та Form_EditingAppointment
        private System.Windows.Forms.Button btnEditAppiontment;
        //Панель на якій розміщено labelYourReception
        private System.Windows.Forms.Panel panelYourReception;
        //Повідомлення з інформацію для користувача
        private System.Windows.Forms.Label labelYourReception;
        //Таблиця з переліком користувацьких записів на прийом
        private System.Windows.Forms.DataGridView dgwMyAppointments;
        //Кнопка для виходу з програми
        private System.Windows.Forms.Button button_Exit;
    }
}
