namespace Task2_Repository
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
            this.dataGridViewDogs = new System.Windows.Forms.DataGridView();
            this.dataGridViewCats = new System.Windows.Forms.DataGridView();
            this.labelDogs = new System.Windows.Forms.Label();
            this.labelCats = new System.Windows.Forms.Label();
            this.comboBoxRepository = new System.Windows.Forms.ComboBox();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.comboBoxChooseRepository = new System.Windows.Forms.ComboBox();
            this.comboBoxOperation = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCats)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDogs
            // 
            this.dataGridViewDogs.AllowUserToAddRows = false;
            this.dataGridViewDogs.AllowUserToDeleteRows = false;
            this.dataGridViewDogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDogs.Location = new System.Drawing.Point(12, 37);
            this.dataGridViewDogs.Name = "dataGridViewDogs";
            this.dataGridViewDogs.RowTemplate.Height = 24;
            this.dataGridViewDogs.Size = new System.Drawing.Size(469, 190);
            this.dataGridViewDogs.TabIndex = 0;
            // 
            // dataGridViewCats
            // 
            this.dataGridViewCats.AllowUserToAddRows = false;
            this.dataGridViewCats.AllowUserToDeleteRows = false;
            this.dataGridViewCats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCats.Location = new System.Drawing.Point(12, 271);
            this.dataGridViewCats.Name = "dataGridViewCats";
            this.dataGridViewCats.RowTemplate.Height = 24;
            this.dataGridViewCats.Size = new System.Drawing.Size(469, 190);
            this.dataGridViewCats.TabIndex = 1;
            // 
            // labelDogs
            // 
            this.labelDogs.AutoSize = true;
            this.labelDogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDogs.Location = new System.Drawing.Point(201, 9);
            this.labelDogs.Name = "labelDogs";
            this.labelDogs.Size = new System.Drawing.Size(58, 25);
            this.labelDogs.TabIndex = 2;
            this.labelDogs.Text = "Dogs";
            // 
            // labelCats
            // 
            this.labelCats.AutoSize = true;
            this.labelCats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCats.Location = new System.Drawing.Point(201, 243);
            this.labelCats.Name = "labelCats";
            this.labelCats.Size = new System.Drawing.Size(53, 25);
            this.labelCats.TabIndex = 3;
            this.labelCats.Text = "Cats";
            // 
            // comboBoxRepository
            // 
            this.comboBoxRepository.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxRepository.FormattingEnabled = true;
            this.comboBoxRepository.Location = new System.Drawing.Point(487, 62);
            this.comboBoxRepository.Name = "comboBoxRepository";
            this.comboBoxRepository.Size = new System.Drawing.Size(267, 33);
            this.comboBoxRepository.TabIndex = 4;
            // 
            // buttonOpen
            // 
            this.buttonOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpen.Location = new System.Drawing.Point(487, 101);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(267, 44);
            this.buttonOpen.TabIndex = 5;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // comboBoxChooseRepository
            // 
            this.comboBoxChooseRepository.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxChooseRepository.FormattingEnabled = true;
            this.comboBoxChooseRepository.Location = new System.Drawing.Point(487, 176);
            this.comboBoxChooseRepository.Name = "comboBoxChooseRepository";
            this.comboBoxChooseRepository.Size = new System.Drawing.Size(267, 33);
            this.comboBoxChooseRepository.TabIndex = 6;
            this.comboBoxChooseRepository.TextChanged += new System.EventHandler(this.comboBoxChooseRepository_TextChanged);
            // 
            // comboBoxOperation
            // 
            this.comboBoxOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxOperation.FormattingEnabled = true;
            this.comboBoxOperation.Location = new System.Drawing.Point(487, 240);
            this.comboBoxOperation.Name = "comboBoxOperation";
            this.comboBoxOperation.Size = new System.Drawing.Size(267, 33);
            this.comboBoxOperation.TabIndex = 7;
            this.comboBoxOperation.SelectedIndexChanged += new System.EventHandler(this.comboBoxOperation_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(487, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select sourse for repositories";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(516, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Select type repositories";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(538, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Select operation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(562, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Enter data";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(567, 304);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 30);
            this.textBox1.TabIndex = 14;
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(482, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(482, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Name";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(567, 340);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(187, 30);
            this.textBox2.TabIndex = 16;
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(482, 379);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "Weight";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(567, 376);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(187, 30);
            this.textBox3.TabIndex = 18;
            this.textBox3.Leave += new System.EventHandler(this.textBox3_Leave);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(487, 417);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(267, 44);
            this.buttonSave.TabIndex = 20;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 473);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxOperation);
            this.Controls.Add(this.comboBoxChooseRepository);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.comboBoxRepository);
            this.Controls.Add(this.labelCats);
            this.Controls.Add(this.labelDogs);
            this.Controls.Add(this.dataGridViewCats);
            this.Controls.Add(this.dataGridViewDogs);
            this.Name = "Form1";
            this.Text = "Repository";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDogs;
        private System.Windows.Forms.DataGridView dataGridViewCats;
        private System.Windows.Forms.Label labelDogs;
        private System.Windows.Forms.Label labelCats;
        private System.Windows.Forms.ComboBox comboBoxRepository;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.ComboBox comboBoxChooseRepository;
        private System.Windows.Forms.ComboBox comboBoxOperation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buttonSave;
    }
}

