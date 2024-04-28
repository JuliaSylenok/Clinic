namespace WindowsFormsApp2.UserControls
{
    partial class UC_Editing
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
            this.panelEditing = new System.Windows.Forms.Panel();
            this.button_Exit = new System.Windows.Forms.Button();
            this.labelEditing = new System.Windows.Forms.Label();
            this.panelService = new System.Windows.Forms.Panel();
            this.btnService = new System.Windows.Forms.Button();
            this.labelService = new System.Windows.Forms.Label();
            this.panelEditPatient = new System.Windows.Forms.Panel();
            this.btnEditPatient = new System.Windows.Forms.Button();
            this.labelEditPatient = new System.Windows.Forms.Label();
            this.panelEditing.SuspendLayout();
            this.panelService.SuspendLayout();
            this.panelEditPatient.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEditing
            // 
            this.panelEditing.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panelEditing.Controls.Add(this.button_Exit);
            this.panelEditing.Controls.Add(this.labelEditing);
            this.panelEditing.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEditing.Location = new System.Drawing.Point(0, 0);
            this.panelEditing.Name = "panelEditing";
            this.panelEditing.Size = new System.Drawing.Size(629, 61);
            this.panelEditing.TabIndex = 0;
            // 
            // button_Exit
            // 
            this.button_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Exit.FlatAppearance.BorderSize = 0;
            this.button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Exit.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Exit.ForeColor = System.Drawing.Color.White;
            this.button_Exit.Location = new System.Drawing.Point(594, 0);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(35, 33);
            this.button_Exit.TabIndex = 5;
            this.button_Exit.Text = "X";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // labelEditing
            // 
            this.labelEditing.AutoSize = true;
            this.labelEditing.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEditing.ForeColor = System.Drawing.Color.White;
            this.labelEditing.Location = new System.Drawing.Point(12, 18);
            this.labelEditing.Name = "labelEditing";
            this.labelEditing.Size = new System.Drawing.Size(159, 27);
            this.labelEditing.TabIndex = 0;
            this.labelEditing.Text = "Редагування";
            // 
            // panelService
            // 
            this.panelService.BackColor = System.Drawing.Color.AliceBlue;
            this.panelService.Controls.Add(this.btnService);
            this.panelService.Controls.Add(this.labelService);
            this.panelService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelService.Location = new System.Drawing.Point(0, 61);
            this.panelService.Name = "panelService";
            this.panelService.Size = new System.Drawing.Size(629, 422);
            this.panelService.TabIndex = 1;
            // 
            // btnService
            // 
            this.btnService.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnService.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.btnService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnService.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnService.ForeColor = System.Drawing.Color.White;
            this.btnService.Location = new System.Drawing.Point(218, 104);
            this.btnService.Name = "btnService";
            this.btnService.Size = new System.Drawing.Size(190, 56);
            this.btnService.TabIndex = 2;
            this.btnService.Text = "Редагувати";
            this.btnService.UseVisualStyleBackColor = false;
            this.btnService.Click += new System.EventHandler(this.btnService_Click);
            // 
            // labelService
            // 
            this.labelService.AutoSize = true;
            this.labelService.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelService.Location = new System.Drawing.Point(95, 57);
            this.labelService.Name = "labelService";
            this.labelService.Size = new System.Drawing.Size(470, 23);
            this.labelService.TabIndex = 1;
            this.labelService.Text = "Редагувати послуги, що надаються клінікою";
            // 
            // panelEditPatient
            // 
            this.panelEditPatient.BackColor = System.Drawing.Color.AliceBlue;
            this.panelEditPatient.Controls.Add(this.btnEditPatient);
            this.panelEditPatient.Controls.Add(this.labelEditPatient);
            this.panelEditPatient.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEditPatient.Location = new System.Drawing.Point(0, 252);
            this.panelEditPatient.Name = "panelEditPatient";
            this.panelEditPatient.Size = new System.Drawing.Size(629, 231);
            this.panelEditPatient.TabIndex = 3;
            // 
            // btnEditPatient
            // 
            this.btnEditPatient.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnEditPatient.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.btnEditPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditPatient.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnEditPatient.ForeColor = System.Drawing.Color.White;
            this.btnEditPatient.Location = new System.Drawing.Point(218, 111);
            this.btnEditPatient.Name = "btnEditPatient";
            this.btnEditPatient.Size = new System.Drawing.Size(190, 56);
            this.btnEditPatient.TabIndex = 3;
            this.btnEditPatient.Text = "Редагувати";
            this.btnEditPatient.UseVisualStyleBackColor = false;
            this.btnEditPatient.Click += new System.EventHandler(this.btnEditPatient_Click);
            // 
            // labelEditPatient
            // 
            this.labelEditPatient.AutoSize = true;
            this.labelEditPatient.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEditPatient.Location = new System.Drawing.Point(158, 65);
            this.labelEditPatient.Name = "labelEditPatient";
            this.labelEditPatient.Size = new System.Drawing.Size(305, 23);
            this.labelEditPatient.TabIndex = 2;
            this.labelEditPatient.Text = "Редагувати записи пацієнтів";
            // 
            // UC_Editing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelEditPatient);
            this.Controls.Add(this.panelService);
            this.Controls.Add(this.panelEditing);
            this.Name = "UC_Editing";
            this.Size = new System.Drawing.Size(629, 483);
            this.panelEditing.ResumeLayout(false);
            this.panelEditing.PerformLayout();
            this.panelService.ResumeLayout(false);
            this.panelService.PerformLayout();
            this.panelEditPatient.ResumeLayout(false);
            this.panelEditPatient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        
        //Паннелі, що містять інформацію для користувача
        private System.Windows.Forms.Panel panelEditing;
        private System.Windows.Forms.Panel panelService;
        private System.Windows.Forms.Panel panelEditPatient;
        //Првіломлення для користувача
        private System.Windows.Forms.Label labelEditing;
        private System.Windows.Forms.Label labelService;
        private System.Windows.Forms.Label labelEditPatient;
        //Кнопка, що реалізує перехід на форму Form_EditingServices
        private System.Windows.Forms.Button btnService;
        //Кнопка, що реалізує перехід на форму Form_EditingPatient
        private System.Windows.Forms.Button btnEditPatient;
        //Кнопка для закриття програми
        private System.Windows.Forms.Button button_Exit;
    }
}
