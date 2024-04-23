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
            this.button4 = new System.Windows.Forms.Button();
            this.tb_EditingPrice = new System.Windows.Forms.TextBox();
            this.tb_EditingDescription = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tb_EditingCategory = new System.Windows.Forms.TextBox();
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
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(645, 65);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(132, 58);
            this.button4.TabIndex = 8;
            this.button4.Text = "Зберегти зміни";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // tb_EditingPrice
            // 
            this.tb_EditingPrice.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_EditingPrice.Location = new System.Drawing.Point(432, 137);
            this.tb_EditingPrice.Name = "tb_EditingPrice";
            this.tb_EditingPrice.Size = new System.Drawing.Size(100, 28);
            this.tb_EditingPrice.TabIndex = 10;
            // 
            // tb_EditingDescription
            // 
            this.tb_EditingDescription.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_EditingDescription.Location = new System.Drawing.Point(231, 65);
            this.tb_EditingDescription.Name = "tb_EditingDescription";
            this.tb_EditingDescription.Size = new System.Drawing.Size(301, 28);
            this.tb_EditingDescription.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(231, 103);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(301, 28);
            this.textBox3.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(114, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Категорія:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(128, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Послуга:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(155, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Лікар:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(365, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "Ціна:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(102, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 23);
            this.label5.TabIndex = 18;
            this.label5.Text = "ID послуги:";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(231, 138);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 28);
            this.textBox4.TabIndex = 17;
            // 
            // tb_EditingCategory
            // 
            this.tb_EditingCategory.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_EditingCategory.Location = new System.Drawing.Point(231, 27);
            this.tb_EditingCategory.Name = "tb_EditingCategory";
            this.tb_EditingCategory.Size = new System.Drawing.Size(301, 28);
            this.tb_EditingCategory.TabIndex = 19;
            // 
            // Form_EditingServices
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_EditingCategory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.tb_EditingDescription);
            this.Controls.Add(this.tb_EditingPrice);
            this.Controls.Add(this.button4);
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

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dataGridView_Services;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.Button btnEditingService;
        private System.Windows.Forms.Button btnDeleteService;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox tb_EditingPrice;
        private System.Windows.Forms.TextBox tb_EditingDescription;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox tb_EditingCategory;
    }
}