namespace krnenavishy
{
    partial class MainDataForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backPageButton = new System.Windows.Forms.Button();
            this.allDataButton = new System.Windows.Forms.Button();
            this.nextPageButton = new System.Windows.Forms.Button();
            this.numberLabel = new System.Windows.Forms.Label();
            this.amountTB = new System.Windows.Forms.TextBox();
            this.searchInfoButton = new System.Windows.Forms.Button();
            this.amountOfLabel = new System.Windows.Forms.Label();
            this.mGenderButton = new System.Windows.Forms.Button();
            this.wGenderButton = new System.Windows.Forms.Button();
            this.genderLabel = new System.Windows.Forms.Label();
            this.wordCB = new System.Windows.Forms.ComboBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.nullGenderButton = new System.Windows.Forms.Button();
            this.sortLabel = new System.Windows.Forms.Label();
            this.surnameFilterButton = new System.Windows.Forms.Button();
            this.birthdayShowLabel = new System.Windows.Forms.Label();
            this.birthdayButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addUserLabel = new System.Windows.Forms.Label();
            this.openEditFormButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(694, 393);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // backPageButton
            // 
            this.backPageButton.Location = new System.Drawing.Point(12, 415);
            this.backPageButton.Name = "backPageButton";
            this.backPageButton.Size = new System.Drawing.Size(75, 23);
            this.backPageButton.TabIndex = 1;
            this.backPageButton.Text = "<=";
            this.backPageButton.UseVisualStyleBackColor = true;
            this.backPageButton.Click += new System.EventHandler(this.backPageButton_Click);
            // 
            // allDataButton
            // 
            this.allDataButton.Location = new System.Drawing.Point(94, 415);
            this.allDataButton.Name = "allDataButton";
            this.allDataButton.Size = new System.Drawing.Size(43, 23);
            this.allDataButton.TabIndex = 2;
            this.allDataButton.Text = "ALL";
            this.allDataButton.UseVisualStyleBackColor = true;
            this.allDataButton.Click += new System.EventHandler(this.allDataButton_Click);
            // 
            // nextPageButton
            // 
            this.nextPageButton.Location = new System.Drawing.Point(143, 415);
            this.nextPageButton.Name = "nextPageButton";
            this.nextPageButton.Size = new System.Drawing.Size(75, 23);
            this.nextPageButton.TabIndex = 3;
            this.nextPageButton.Text = "=>";
            this.nextPageButton.UseVisualStyleBackColor = true;
            this.nextPageButton.Click += new System.EventHandler(this.nextPageButton_Click);
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Location = new System.Drawing.Point(549, 420);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(53, 13);
            this.numberLabel.TabIndex = 4;
            this.numberLabel.Text = "Записей:";
            // 
            // amountTB
            // 
            this.amountTB.Location = new System.Drawing.Point(608, 417);
            this.amountTB.Name = "amountTB";
            this.amountTB.Size = new System.Drawing.Size(100, 20);
            this.amountTB.TabIndex = 5;
            // 
            // searchInfoButton
            // 
            this.searchInfoButton.Location = new System.Drawing.Point(714, 415);
            this.searchInfoButton.Name = "searchInfoButton";
            this.searchInfoButton.Size = new System.Drawing.Size(75, 23);
            this.searchInfoButton.TabIndex = 6;
            this.searchInfoButton.Text = "вывести";
            this.searchInfoButton.UseVisualStyleBackColor = true;
            this.searchInfoButton.Click += new System.EventHandler(this.searchInfoButton_Click);
            // 
            // amountOfLabel
            // 
            this.amountOfLabel.AutoSize = true;
            this.amountOfLabel.Location = new System.Drawing.Point(387, 420);
            this.amountOfLabel.Name = "amountOfLabel";
            this.amountOfLabel.Size = new System.Drawing.Size(12, 13);
            this.amountOfLabel.TabIndex = 7;
            this.amountOfLabel.Text = "/";
            // 
            // mGenderButton
            // 
            this.mGenderButton.Location = new System.Drawing.Point(711, 29);
            this.mGenderButton.Name = "mGenderButton";
            this.mGenderButton.Size = new System.Drawing.Size(36, 23);
            this.mGenderButton.TabIndex = 8;
            this.mGenderButton.Text = "М";
            this.mGenderButton.UseVisualStyleBackColor = true;
            this.mGenderButton.Click += new System.EventHandler(this.mGenderButton_Click);
            // 
            // wGenderButton
            // 
            this.wGenderButton.Location = new System.Drawing.Point(753, 29);
            this.wGenderButton.Name = "wGenderButton";
            this.wGenderButton.Size = new System.Drawing.Size(36, 23);
            this.wGenderButton.TabIndex = 9;
            this.wGenderButton.Text = "Ж";
            this.wGenderButton.UseVisualStyleBackColor = true;
            this.wGenderButton.Click += new System.EventHandler(this.wGenderButton_Click);
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(715, 13);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(70, 13);
            this.genderLabel.TabIndex = 10;
            this.genderLabel.Text = "Выбор пола:";
            // 
            // wordCB
            // 
            this.wordCB.FormattingEnabled = true;
            this.wordCB.Items.AddRange(new object[] {
            "ФИО",
            "почта",
            "телефон"});
            this.wordCB.Location = new System.Drawing.Point(711, 98);
            this.wordCB.Name = "wordCB";
            this.wordCB.Size = new System.Drawing.Size(78, 21);
            this.wordCB.TabIndex = 11;
            this.wordCB.Text = "Выберите";
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(708, 82);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(86, 13);
            this.searchLabel.TabIndex = 14;
            this.searchLabel.Text = "Поиск по слову";
            // 
            // searchTB
            // 
            this.searchTB.Location = new System.Drawing.Point(711, 125);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(78, 20);
            this.searchTB.TabIndex = 15;
            this.searchTB.Text = "Введите текст";
            this.searchTB.Click += new System.EventHandler(this.searchTB_Click);
            this.searchTB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchTB_KeyUp);
            // 
            // nullGenderButton
            // 
            this.nullGenderButton.Location = new System.Drawing.Point(711, 58);
            this.nullGenderButton.Name = "nullGenderButton";
            this.nullGenderButton.Size = new System.Drawing.Size(78, 23);
            this.nullGenderButton.TabIndex = 16;
            this.nullGenderButton.Text = "сбросить";
            this.nullGenderButton.UseVisualStyleBackColor = true;
            this.nullGenderButton.Click += new System.EventHandler(this.nullGenderButton_Click);
            // 
            // sortLabel
            // 
            this.sortLabel.AutoSize = true;
            this.sortLabel.Location = new System.Drawing.Point(709, 147);
            this.sortLabel.Name = "sortLabel";
            this.sortLabel.Size = new System.Drawing.Size(85, 13);
            this.sortLabel.TabIndex = 17;
            this.sortLabel.Text = "Сортировка по:";
            // 
            // surnameFilterButton
            // 
            this.surnameFilterButton.Location = new System.Drawing.Point(712, 163);
            this.surnameFilterButton.Name = "surnameFilterButton";
            this.surnameFilterButton.Size = new System.Drawing.Size(75, 24);
            this.surnameFilterButton.TabIndex = 18;
            this.surnameFilterButton.Text = "фамилии";
            this.surnameFilterButton.UseVisualStyleBackColor = true;
            this.surnameFilterButton.Click += new System.EventHandler(this.surnameFilterButton_Click);
            // 
            // birthdayShowLabel
            // 
            this.birthdayShowLabel.AutoSize = true;
            this.birthdayShowLabel.Location = new System.Drawing.Point(719, 190);
            this.birthdayShowLabel.Name = "birthdayShowLabel";
            this.birthdayShowLabel.Size = new System.Drawing.Size(59, 13);
            this.birthdayShowLabel.TabIndex = 20;
            this.birthdayShowLabel.Text = "Показать:";
            // 
            // birthdayButton
            // 
            this.birthdayButton.Location = new System.Drawing.Point(712, 206);
            this.birthdayButton.Name = "birthdayButton";
            this.birthdayButton.Size = new System.Drawing.Size(75, 34);
            this.birthdayButton.TabIndex = 21;
            this.birthdayButton.Text = "день рождения";
            this.birthdayButton.UseVisualStyleBackColor = true;
            this.birthdayButton.Click += new System.EventHandler(this.birthdayButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(712, 355);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 50);
            this.deleteButton.TabIndex = 22;
            this.deleteButton.Text = "удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addUserLabel
            // 
            this.addUserLabel.AutoSize = true;
            this.addUserLabel.Location = new System.Drawing.Point(715, 243);
            this.addUserLabel.Name = "addUserLabel";
            this.addUserLabel.Size = new System.Drawing.Size(68, 26);
            this.addUserLabel.TabIndex = 23;
            this.addUserLabel.Text = "Изменение \r\nданных:";
            this.addUserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openEditFormButton
            // 
            this.openEditFormButton.Location = new System.Drawing.Point(712, 272);
            this.openEditFormButton.Name = "openEditFormButton";
            this.openEditFormButton.Size = new System.Drawing.Size(75, 23);
            this.openEditFormButton.TabIndex = 24;
            this.openEditFormButton.Text = "перейти";
            this.openEditFormButton.UseVisualStyleBackColor = true;
            this.openEditFormButton.Click += new System.EventHandler(this.openEditFormButton_Click);
            // 
            // MainDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 446);
            this.Controls.Add(this.openEditFormButton);
            this.Controls.Add(this.addUserLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.birthdayButton);
            this.Controls.Add(this.birthdayShowLabel);
            this.Controls.Add(this.surnameFilterButton);
            this.Controls.Add(this.sortLabel);
            this.Controls.Add(this.nullGenderButton);
            this.Controls.Add(this.searchTB);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.wordCB);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.wGenderButton);
            this.Controls.Add(this.mGenderButton);
            this.Controls.Add(this.amountOfLabel);
            this.Controls.Add(this.searchInfoButton);
            this.Controls.Add(this.amountTB);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.nextPageButton);
            this.Controls.Add(this.allDataButton);
            this.Controls.Add(this.backPageButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainDataForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button backPageButton;
        private System.Windows.Forms.Button allDataButton;
        private System.Windows.Forms.Button nextPageButton;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.TextBox amountTB;
        private System.Windows.Forms.Button searchInfoButton;
        private System.Windows.Forms.Label amountOfLabel;
        private System.Windows.Forms.Button mGenderButton;
        private System.Windows.Forms.Button wGenderButton;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.ComboBox wordCB;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.Button nullGenderButton;
        private System.Windows.Forms.Label sortLabel;
        private System.Windows.Forms.Button surnameFilterButton;
        private System.Windows.Forms.Label birthdayShowLabel;
        private System.Windows.Forms.Button birthdayButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label addUserLabel;
        private System.Windows.Forms.Button openEditFormButton;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}

