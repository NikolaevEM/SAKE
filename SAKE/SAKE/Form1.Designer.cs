namespace SAKE
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
            this.FIO = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Number = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Tag = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FIO
            // 
            this.FIO.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FIO.Location = new System.Drawing.Point(12, 80);
            this.FIO.Name = "FIO";
            this.FIO.Size = new System.Drawing.Size(185, 358);
            this.FIO.TabIndex = 1;
            this.FIO.Text = "";
            this.FIO.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(473, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 66);
            this.button1.TabIndex = 2;
            this.button1.Text = "Экспортировать";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Number
            // 
            this.Number.Location = new System.Drawing.Point(203, 80);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(124, 358);
            this.Number.TabIndex = 3;
            this.Number.Text = "";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 68);
            this.label1.TabIndex = 4;
            this.label1.Text = "Вставьте сюда ФИО\r\nПример:\r\n\r\nИванов Иван Иванович\r\nПетров Петр Иванович\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(200, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 68);
            this.label2.TabIndex = 5;
            this.label2.Text = "Вставьте сюда номер телефона в соответствии с ФИО\r\nПример:\r\n\r\n+79644044044\r\n+7914" +
    "8800553";
            // 
            // Tag
            // 
            this.Tag.Location = new System.Drawing.Point(509, 80);
            this.Tag.Name = "Tag";
            this.Tag.Size = new System.Drawing.Size(167, 20);
            this.Tag.TabIndex = 6;
            this.Tag.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(506, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 52);
            this.label3.TabIndex = 7;
            this.label3.Text = "Вставьте сюда примечание к каждому контакту\r\nПример:\r\n\r\nАбитуриентИМИ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Tag);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FIO);
            this.Name = "Form1";
            this.Text = "САКЭ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox FIO;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox Number;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tag;
        private System.Windows.Forms.Label label3;
    }
}

