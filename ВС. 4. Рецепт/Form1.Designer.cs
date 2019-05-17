namespace ВС._4.Рецепт
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.txtBoxIDSearch = new System.Windows.Forms.TextBox();
            this.ClearResultsButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.InsertUpdateButton = new System.Windows.Forms.Button();
            this.ClearInsertButton = new System.Windows.Forms.Button();
            this.labelData = new System.Windows.Forms.Label();
            this.txtBoxCost = new System.Windows.Forms.TextBox();
            this.labelCost = new System.Windows.Forms.Label();
            this.txtBoxCure = new System.Windows.Forms.TextBox();
            this.labelCure = new System.Windows.Forms.Label();
            this.txtBoxNumber = new System.Windows.Forms.TextBox();
            this.labelNumber = new System.Windows.Forms.Label();
            this.txtBoxDoctor = new System.Windows.Forms.TextBox();
            this.labelDoctor = new System.Windows.Forms.Label();
            this.txtBoxAddress = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.txtBoxID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBoxIDDelete = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(105, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Приложение по выписке рецептов";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.UpdateButton);
            this.groupBox1.Controls.Add(this.txtBoxIDSearch);
            this.groupBox1.Controls.Add(this.ClearResultsButton);
            this.groupBox1.Controls.Add(this.SearchButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(36, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 241);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(400, 124);
            this.dataGridView1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Введите ID для поиска: ";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Enabled = false;
            this.UpdateButton.Location = new System.Drawing.Point(341, 212);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 6;
            this.UpdateButton.Text = "Обновить";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // txtBoxIDSearch
            // 
            this.txtBoxIDSearch.Location = new System.Drawing.Point(16, 42);
            this.txtBoxIDSearch.Name = "txtBoxIDSearch";
            this.txtBoxIDSearch.Size = new System.Drawing.Size(303, 20);
            this.txtBoxIDSearch.TabIndex = 0;
            // 
            // ClearResultsButton
            // 
            this.ClearResultsButton.Enabled = false;
            this.ClearResultsButton.Location = new System.Drawing.Point(260, 212);
            this.ClearResultsButton.Name = "ClearResultsButton";
            this.ClearResultsButton.Size = new System.Drawing.Size(75, 23);
            this.ClearResultsButton.TabIndex = 5;
            this.ClearResultsButton.Text = "Очистить";
            this.ClearResultsButton.UseVisualStyleBackColor = true;
            this.ClearResultsButton.Click += new System.EventHandler(this.ClearResultsButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(341, 39);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 4;
            this.SearchButton.Text = "Поиск";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Результат: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePicker);
            this.groupBox2.Controls.Add(this.InsertUpdateButton);
            this.groupBox2.Controls.Add(this.ClearInsertButton);
            this.groupBox2.Controls.Add(this.labelData);
            this.groupBox2.Controls.Add(this.txtBoxCost);
            this.groupBox2.Controls.Add(this.labelCost);
            this.groupBox2.Controls.Add(this.txtBoxCure);
            this.groupBox2.Controls.Add(this.labelCure);
            this.groupBox2.Controls.Add(this.txtBoxNumber);
            this.groupBox2.Controls.Add(this.labelNumber);
            this.groupBox2.Controls.Add(this.txtBoxDoctor);
            this.groupBox2.Controls.Add(this.labelDoctor);
            this.groupBox2.Controls.Add(this.txtBoxAddress);
            this.groupBox2.Controls.Add(this.labelAddress);
            this.groupBox2.Controls.Add(this.txtBoxName);
            this.groupBox2.Controls.Add(this.labelName);
            this.groupBox2.Controls.Add(this.txtBoxID);
            this.groupBox2.Controls.Add(this.labelID);
            this.groupBox2.Location = new System.Drawing.Point(36, 310);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(438, 268);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Добавить/Обновить";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(139, 208);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(196, 20);
            this.dateTimePicker.TabIndex = 15;
            // 
            // InsertUpdateButton
            // 
            this.InsertUpdateButton.Location = new System.Drawing.Point(297, 234);
            this.InsertUpdateButton.Name = "InsertUpdateButton";
            this.InsertUpdateButton.Size = new System.Drawing.Size(119, 23);
            this.InsertUpdateButton.TabIndex = 17;
            this.InsertUpdateButton.Text = "Добавить/Обновить";
            this.InsertUpdateButton.UseVisualStyleBackColor = true;
            this.InsertUpdateButton.Click += new System.EventHandler(this.InsertUpdateButton_Click);
            // 
            // ClearInsertButton
            // 
            this.ClearInsertButton.Location = new System.Drawing.Point(216, 234);
            this.ClearInsertButton.Name = "ClearInsertButton";
            this.ClearInsertButton.Size = new System.Drawing.Size(75, 23);
            this.ClearInsertButton.TabIndex = 16;
            this.ClearInsertButton.Text = "Очистить";
            this.ClearInsertButton.UseVisualStyleBackColor = true;
            this.ClearInsertButton.Click += new System.EventHandler(this.clearBox);
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(13, 211);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(33, 13);
            this.labelData.TabIndex = 14;
            this.labelData.Text = "Дата";
            // 
            // txtBoxCost
            // 
            this.txtBoxCost.Location = new System.Drawing.Point(139, 182);
            this.txtBoxCost.Name = "txtBoxCost";
            this.txtBoxCost.Size = new System.Drawing.Size(196, 20);
            this.txtBoxCost.TabIndex = 13;
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(13, 185);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(62, 13);
            this.labelCost.TabIndex = 12;
            this.labelCost.Text = "Стоимость";
            // 
            // txtBoxCure
            // 
            this.txtBoxCure.Location = new System.Drawing.Point(139, 156);
            this.txtBoxCure.Name = "txtBoxCure";
            this.txtBoxCure.Size = new System.Drawing.Size(196, 20);
            this.txtBoxCure.TabIndex = 11;
            // 
            // labelCure
            // 
            this.labelCure.AutoSize = true;
            this.labelCure.Location = new System.Drawing.Point(13, 159);
            this.labelCure.Name = "labelCure";
            this.labelCure.Size = new System.Drawing.Size(62, 13);
            this.labelCure.TabIndex = 10;
            this.labelCure.Text = "Лекарство";
            // 
            // txtBoxNumber
            // 
            this.txtBoxNumber.Location = new System.Drawing.Point(139, 130);
            this.txtBoxNumber.Name = "txtBoxNumber";
            this.txtBoxNumber.Size = new System.Drawing.Size(196, 20);
            this.txtBoxNumber.TabIndex = 9;
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(13, 133);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(93, 13);
            this.labelNumber.TabIndex = 8;
            this.labelNumber.Text = "Номер телефона";
            // 
            // txtBoxDoctor
            // 
            this.txtBoxDoctor.Location = new System.Drawing.Point(139, 104);
            this.txtBoxDoctor.Name = "txtBoxDoctor";
            this.txtBoxDoctor.Size = new System.Drawing.Size(196, 20);
            this.txtBoxDoctor.TabIndex = 7;
            // 
            // labelDoctor
            // 
            this.labelDoctor.AutoSize = true;
            this.labelDoctor.Location = new System.Drawing.Point(13, 107);
            this.labelDoctor.Name = "labelDoctor";
            this.labelDoctor.Size = new System.Drawing.Size(45, 13);
            this.labelDoctor.TabIndex = 6;
            this.labelDoctor.Text = "Доктор";
            // 
            // txtBoxAddress
            // 
            this.txtBoxAddress.Location = new System.Drawing.Point(139, 78);
            this.txtBoxAddress.Name = "txtBoxAddress";
            this.txtBoxAddress.Size = new System.Drawing.Size(196, 20);
            this.txtBoxAddress.TabIndex = 5;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(13, 81);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(76, 13);
            this.labelAddress.TabIndex = 4;
            this.labelAddress.Text = "Адрес аптеки";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(139, 52);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(196, 20);
            this.txtBoxName.TabIndex = 3;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(13, 55);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(95, 13);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Название аптеки";
            // 
            // txtBoxID
            // 
            this.txtBoxID.Location = new System.Drawing.Point(139, 26);
            this.txtBoxID.Name = "txtBoxID";
            this.txtBoxID.Size = new System.Drawing.Size(196, 20);
            this.txtBoxID.TabIndex = 1;
            this.txtBoxID.Click += new System.EventHandler(this.txtBoxID_Click);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(13, 29);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(18, 13);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "ID";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtBoxIDDelete);
            this.groupBox3.Controls.Add(this.DeleteButton);
            this.groupBox3.Location = new System.Drawing.Point(36, 585);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(438, 100);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Удалить";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(140, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Введите ID для удаления: ";
            // 
            // txtBoxIDDelete
            // 
            this.txtBoxIDDelete.Location = new System.Drawing.Point(21, 48);
            this.txtBoxIDDelete.Name = "txtBoxIDDelete";
            this.txtBoxIDDelete.Size = new System.Drawing.Size(303, 20);
            this.txtBoxIDDelete.TabIndex = 6;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(346, 45);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 7;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 691);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button UpdateButton;
        public System.Windows.Forms.TextBox txtBoxIDSearch;
        public System.Windows.Forms.Button ClearResultsButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.TextBox txtBoxCost;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.TextBox txtBoxCure;
        private System.Windows.Forms.Label labelCure;
        private System.Windows.Forms.TextBox txtBoxNumber;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.TextBox txtBoxDoctor;
        private System.Windows.Forms.Label labelDoctor;
        private System.Windows.Forms.TextBox txtBoxAddress;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox txtBoxID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Button InsertUpdateButton;
        private System.Windows.Forms.Button ClearInsertButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBoxIDDelete;
        private System.Windows.Forms.Button DeleteButton;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}

