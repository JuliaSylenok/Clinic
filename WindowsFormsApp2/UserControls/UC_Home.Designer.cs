namespace WindowsFormsApp2.UserControls
{
    partial class UC_Home
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.button_Exit = new System.Windows.Forms.Button();
            this.labelMain = new System.Windows.Forms.Label();
            this.labelServices = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.panelServices = new System.Windows.Forms.Panel();
            this.dataGridViewServices = new System.Windows.Forms.DataGridView();
            this.panelMain.SuspendLayout();
            this.panelServices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServices)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panelMain.Controls.Add(this.button_Exit);
            this.panelMain.Controls.Add(this.labelMain);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(629, 57);
            this.panelMain.TabIndex = 1;
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
            this.button_Exit.TabIndex = 4;
            this.button_Exit.Text = "X";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // labelMain
            // 
            this.labelMain.AutoSize = true;
            this.labelMain.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMain.ForeColor = System.Drawing.Color.White;
            this.labelMain.Location = new System.Drawing.Point(3, 12);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(107, 27);
            this.labelMain.TabIndex = 1;
            this.labelMain.Text = "Головна";
            // 
            // labelServices
            // 
            this.labelServices.AutoSize = true;
            this.labelServices.Font = new System.Drawing.Font("Century Gothic", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelServices.ForeColor = System.Drawing.Color.Black;
            this.labelServices.Location = new System.Drawing.Point(4, 10);
            this.labelServices.Name = "labelServices";
            this.labelServices.Size = new System.Drawing.Size(376, 22);
            this.labelServices.TabIndex = 0;
            this.labelServices.Text = "Список послуг, що надаються клінікою";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.AliceBlue;
            this.panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel.Location = new System.Drawing.Point(0, 432);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(629, 51);
            this.panel.TabIndex = 2;
            // 
            // panelServices
            // 
            this.panelServices.BackColor = System.Drawing.Color.AliceBlue;
            this.panelServices.Controls.Add(this.labelServices);
            this.panelServices.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelServices.Location = new System.Drawing.Point(0, 57);
            this.panelServices.Name = "panelServices";
            this.panelServices.Size = new System.Drawing.Size(629, 42);
            this.panelServices.TabIndex = 3;
            // 
            // dataGridViewServices
            // 
            this.dataGridViewServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewServices.Location = new System.Drawing.Point(8, 105);
            this.dataGridViewServices.Name = "dataGridViewServices";
            this.dataGridViewServices.RowHeadersWidth = 51;
            this.dataGridViewServices.RowTemplate.Height = 24;
            this.dataGridViewServices.Size = new System.Drawing.Size(452, 227);
            this.dataGridViewServices.TabIndex = 4;
            // 
            // UC_Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridViewServices);
            this.Controls.Add(this.panelServices);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "UC_Home";
            this.Size = new System.Drawing.Size(629, 483);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelServices.ResumeLayout(false);
            this.panelServices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        
        //Панелі, що містять інформацію для користувача
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panel;
        //Повідомлення для користувача
        private System.Windows.Forms.Label labelServices;
        private System.Windows.Forms.Label labelMain;
        //Панель, що містить DataGridView
        private System.Windows.Forms.Panel panelServices;
        //Копка для закриття програми
        private System.Windows.Forms.Button button_Exit;
        //Таблиця в якій відображаються наявні сервіси
        private System.Windows.Forms.DataGridView dataGridViewServices;
    }
}
