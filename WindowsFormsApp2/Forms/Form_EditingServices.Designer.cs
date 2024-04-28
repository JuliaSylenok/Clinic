namespace WindowsFormsApp2.Forms
{
    partial class Form_EditingServices
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
            this.dataGridView_Services = new System.Windows.Forms.DataGridView();
            this.btnAddService = new System.Windows.Forms.Button();
            this.btnEditingService = new System.Windows.Forms.Button();
            this.btnDeleteService = new System.Windows.Forms.Button();
            this.tb_EditingPrice = new System.Windows.Forms.TextBox();
            this.tb_EditingDescription = new System.Windows.Forms.TextBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelService = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.tb_EditingCategory = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Services)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.Location = new System.Drawing.Point(757, -4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(59, 33);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dataGridView_Services
            // 
            this.dataGridView_Services.AllowUserToAddRows = false;
            this.dataGridView_Services.AllowUserToDeleteRows = false;
            this.dataGridView_Services.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView_Services.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Services.Location = new System.Drawing.Point(23, 188);
            this.dataGridView_Services.Name = "dataGridView_Services";
            this.dataGridView_Services.ReadOnly = true;
            this.dataGridView_Services.RowHeadersWidth = 51;
            this.dataGridView_Services.RowTemplate.Height = 24;
            this.dataGridView_Services.Size = new System.Drawing.Size(754, 198);
            this.dataGridView_Services.TabIndex = 4;
            this.dataGridView_Services.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Services_CellClick);
            // 
            // btnAddService
            // 
            this.btnAddService.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnAddService.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.btnAddService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddService.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnAddService.ForeColor = System.Drawing.Color.White;
            this.btnAddService.Location = new System.Drawing.Point(645, 392);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(132, 43);
            this.btnAddService.TabIndex = 5;
            this.btnAddService.Text = "Додати";
            this.btnAddService.UseVisualStyleBackColor = false;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // btnEditingService
            // 
            this.btnEditingService.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnEditingService.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.btnEditingService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditingService.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnEditingService.ForeColor = System.Drawing.Color.White;
            this.btnEditingService.Location = new System.Drawing.Point(507, 392);
            this.btnEditingService.Name = "btnEditingService";
            this.btnEditingService.Size = new System.Drawing.Size(132, 43);
            this.btnEditingService.TabIndex = 6;
            this.btnEditingService.Text = "Редагувати";
            this.btnEditingService.UseVisualStyleBackColor = false;
            this.btnEditingService.Click += new System.EventHandler(this.btnEditingService_Click);
            // 
            // btnDeleteService
            // 
            this.btnDeleteService.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnDeleteService.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.btnDeleteService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteService.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnDeleteService.ForeColor = System.Drawing.Color.White;
            this.btnDeleteService.Location = new System.Drawing.Point(369, 392);
            this.btnDeleteService.Name = "btnDeleteService";
            this.btnDeleteService.Size = new System.Drawing.Size(132, 43);
            this.btnDeleteService.TabIndex = 7;
            this.btnDeleteService.Text = "Видалити";
            this.btnDeleteService.UseVisualStyleBackColor = false;
            this.btnDeleteService.Click += new System.EventHandler(this.btnDeleteService_Click);
            // 
            // tb_EditingPrice
            // 
            this.tb_EditingPrice.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_EditingPrice.Location = new System.Drawing.Point(298, 113);
            this.tb_EditingPrice.Name = "tb_EditingPrice";
            this.tb_EditingPrice.Size = new System.Drawing.Size(301, 28);
            this.tb_EditingPrice.TabIndex = 10;
            this.tb_EditingPrice.Text = "Введіть для редагування";
            this.tb_EditingPrice.Click += new System.EventHandler(this.tb_EditingPrice_Click);
            // 
            // tb_EditingDescription
            // 
            this.tb_EditingDescription.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_EditingDescription.Location = new System.Drawing.Point(298, 70);
            this.tb_EditingDescription.Name = "tb_EditingDescription";
            this.tb_EditingDescription.Size = new System.Drawing.Size(301, 28);
            this.tb_EditingDescription.TabIndex = 11;
            this.tb_EditingDescription.Text = "Введіть для редагування";
            this.tb_EditingDescription.Click += new System.EventHandler(this.tb_EditingDescription_Click);
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCategory.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelCategory.Location = new System.Drawing.Point(181, 27);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(114, 23);
            this.labelCategory.TabIndex = 13;
            this.labelCategory.Text = "Категорія:";
            // 
            // labelService
            // 
            this.labelService.AutoSize = true;
            this.labelService.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelService.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelService.Location = new System.Drawing.Point(195, 70);
            this.labelService.Name = "labelService";
            this.labelService.Size = new System.Drawing.Size(100, 23);
            this.labelService.TabIndex = 14;
            this.labelService.Text = "Послуга:";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelPrice.Location = new System.Drawing.Point(231, 113);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(61, 23);
            this.labelPrice.TabIndex = 16;
            this.labelPrice.Text = "Ціна:";
            // 
            // tb_EditingCategory
            // 
            this.tb_EditingCategory.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_EditingCategory.Location = new System.Drawing.Point(298, 27);
            this.tb_EditingCategory.Name = "tb_EditingCategory";
            this.tb_EditingCategory.Size = new System.Drawing.Size(301, 28);
            this.tb_EditingCategory.TabIndex = 19;
            this.tb_EditingCategory.Text = "Введіть для редагування";
            this.tb_EditingCategory.Click += new System.EventHandler(this.tb_EditingCategory_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label.Location = new System.Drawing.Point(19, 152);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(179, 23);
            this.label.TabIndex = 20;
            this.label.Text = "Оберіть послугу";
            // 
            // Form_EditingServices
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label);
            this.Controls.Add(this.tb_EditingCategory);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelService);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.tb_EditingDescription);
            this.Controls.Add(this.tb_EditingPrice);
            this.Controls.Add(this.btnDeleteService);
            this.Controls.Add(this.btnEditingService);
            this.Controls.Add(this.btnAddService);
            this.Controls.Add(this.dataGridView_Services);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_EditingServices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Editing";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Services)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //Закриття форми
        private System.Windows.Forms.Button btnClose;
        
        //Таблиця з наявними сервісами
        private System.Windows.Forms.DataGridView dataGridView_Services;
       
        //Додавання сервісу
        private System.Windows.Forms.Button btnAddService;
        
        //Редагування сервісу
        private System.Windows.Forms.Button btnEditingService;
        
        //Видалення сервісу
        private System.Windows.Forms.Button btnDeleteService;

        //Поля які має заповнити користува (Ціна, Категорія, Сервіс)
        private System.Windows.Forms.TextBox tb_EditingPrice;
        private System.Windows.Forms.TextBox tb_EditingCategory;
        private System.Windows.Forms.TextBox tb_EditingDescription;
        
        //Повідомлення користувачу
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelService;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label label;
    }
}