namespace Task1_Singleton_Proxy
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
            this.listBoxOrder = new System.Windows.Forms.ListBox();
            this.textBoxEmployeeSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAwardPercentage = new System.Windows.Forms.TextBox();
            this.buttonAddToOrder = new System.Windows.Forms.Button();
            this.buttonPrintOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxOrder
            // 
            this.listBoxOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxOrder.FormattingEnabled = true;
            this.listBoxOrder.ItemHeight = 20;
            this.listBoxOrder.Location = new System.Drawing.Point(247, 12);
            this.listBoxOrder.Name = "listBoxOrder";
            this.listBoxOrder.Size = new System.Drawing.Size(405, 304);
            this.listBoxOrder.TabIndex = 0;
            // 
            // textBoxEmployeeSurname
            // 
            this.textBoxEmployeeSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEmployeeSurname.Location = new System.Drawing.Point(17, 37);
            this.textBoxEmployeeSurname.Name = "textBoxEmployeeSurname";
            this.textBoxEmployeeSurname.Size = new System.Drawing.Size(224, 30);
            this.textBoxEmployeeSurname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter employee surname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter award percentage";
            // 
            // textBoxAwardPercentage
            // 
            this.textBoxAwardPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAwardPercentage.Location = new System.Drawing.Point(17, 110);
            this.textBoxAwardPercentage.Name = "textBoxAwardPercentage";
            this.textBoxAwardPercentage.Size = new System.Drawing.Size(224, 30);
            this.textBoxAwardPercentage.TabIndex = 3;
            // 
            // buttonAddToOrder
            // 
            this.buttonAddToOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddToOrder.Location = new System.Drawing.Point(17, 232);
            this.buttonAddToOrder.Name = "buttonAddToOrder";
            this.buttonAddToOrder.Size = new System.Drawing.Size(224, 41);
            this.buttonAddToOrder.TabIndex = 5;
            this.buttonAddToOrder.Text = "Add to order";
            this.buttonAddToOrder.UseVisualStyleBackColor = true;
            this.buttonAddToOrder.Click += new System.EventHandler(this.buttonAddToOrder_Click);
            // 
            // buttonPrintOrder
            // 
            this.buttonPrintOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPrintOrder.Location = new System.Drawing.Point(17, 279);
            this.buttonPrintOrder.Name = "buttonPrintOrder";
            this.buttonPrintOrder.Size = new System.Drawing.Size(224, 41);
            this.buttonPrintOrder.TabIndex = 6;
            this.buttonPrintOrder.Text = "Print order";
            this.buttonPrintOrder.UseVisualStyleBackColor = true;
            this.buttonPrintOrder.Click += new System.EventHandler(this.buttonPrintOrder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 338);
            this.Controls.Add(this.buttonPrintOrder);
            this.Controls.Add(this.buttonAddToOrder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxAwardPercentage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxEmployeeSurname);
            this.Controls.Add(this.listBoxOrder);
            this.Name = "Form1";
            this.Text = "Order";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxOrder;
        private System.Windows.Forms.TextBox textBoxEmployeeSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAwardPercentage;
        private System.Windows.Forms.Button buttonAddToOrder;
        private System.Windows.Forms.Button buttonPrintOrder;
    }
}

