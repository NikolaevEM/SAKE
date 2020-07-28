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
            this.textFIO1 = new System.Windows.Forms.RichTextBox();
            this.buttonExport = new System.Windows.Forms.Button();
            this.textNumber2 = new System.Windows.Forms.RichTextBox();
            this.labelFIO1 = new System.Windows.Forms.Label();
            this.labelNumber2 = new System.Windows.Forms.Label();
            this.textTag3 = new System.Windows.Forms.TextBox();
            this.labelTag3 = new System.Windows.Forms.Label();
            this.labelError4 = new System.Windows.Forms.Label();
            this.labelGroup4 = new System.Windows.Forms.Label();
            this.textGroup4 = new System.Windows.Forms.RichTextBox();
            this.labelCountFIO = new System.Windows.Forms.Label();
            this.labelCountNumber = new System.Windows.Forms.Label();
            this.labelCountGroup = new System.Windows.Forms.Label();
            this.labelWarningUnderExport = new System.Windows.Forms.Label();
            this.buttonInstruction = new System.Windows.Forms.Button();
            this.buttonSuggestions = new System.Windows.Forms.Button();
            this.buttonDir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textFIO1
            // 
            this.textFIO1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textFIO1.Location = new System.Drawing.Point(12, 107);
            this.textFIO1.Name = "textFIO1";
            this.textFIO1.Size = new System.Drawing.Size(185, 317);
            this.textFIO1.TabIndex = 1;
            this.textFIO1.Text = "";
            this.textFIO1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(547, 359);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(180, 66);
            this.buttonExport.TabIndex = 2;
            this.buttonExport.Text = "Экспортировать";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // textNumber2
            // 
            this.textNumber2.Location = new System.Drawing.Point(203, 107);
            this.textNumber2.Name = "textNumber2";
            this.textNumber2.Size = new System.Drawing.Size(124, 317);
            this.textNumber2.TabIndex = 3;
            this.textNumber2.Text = "";
            this.textNumber2.TextChanged += new System.EventHandler(this.textNumber2_TextChanged);
            // 
            // labelFIO1
            // 
            this.labelFIO1.Location = new System.Drawing.Point(12, 9);
            this.labelFIO1.Name = "labelFIO1";
            this.labelFIO1.Size = new System.Drawing.Size(185, 95);
            this.labelFIO1.TabIndex = 4;
            this.labelFIO1.Text = "Вставьте сюда ФИО\r\n\r\n\r\nПример:\r\n\r\nИванов Иван Иванович\r\nПетров Петр Иванович";
            this.labelFIO1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelNumber2
            // 
            this.labelNumber2.Location = new System.Drawing.Point(203, 9);
            this.labelNumber2.Name = "labelNumber2";
            this.labelNumber2.Size = new System.Drawing.Size(124, 95);
            this.labelNumber2.TabIndex = 5;
            this.labelNumber2.Text = "Вставьте сюда номер\r\nтелефона\r\nв соответствии с ФИО\r\nПример:\r\n\r\n+7(964)-404-40-4\r" +
    "\n8964404404";
            // 
            // textTag3
            // 
            this.textTag3.Location = new System.Drawing.Point(506, 107);
            this.textTag3.Name = "textTag3";
            this.textTag3.Size = new System.Drawing.Size(167, 20);
            this.textTag3.TabIndex = 6;
            this.textTag3.Text = "Абит";
            this.textTag3.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelTag3
            // 
            this.labelTag3.Location = new System.Drawing.Point(503, 9);
            this.labelTag3.Name = "labelTag3";
            this.labelTag3.Size = new System.Drawing.Size(252, 87);
            this.labelTag3.TabIndex = 7;
            this.labelTag3.Text = "Вставьте сюда примечание к каждому контакту:\r\n\r\n\r\nПример:\r\n\r\nАбитуриент";
            // 
            // labelError4
            // 
            this.labelError4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelError4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelError4.Location = new System.Drawing.Point(507, 138);
            this.labelError4.Name = "labelError4";
            this.labelError4.Size = new System.Drawing.Size(248, 180);
            this.labelError4.TabIndex = 8;
            this.labelError4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // labelGroup4
            // 
            this.labelGroup4.Location = new System.Drawing.Point(333, 9);
            this.labelGroup4.Name = "labelGroup4";
            this.labelGroup4.Size = new System.Drawing.Size(167, 95);
            this.labelGroup4.TabIndex = 10;
            this.labelGroup4.Text = "Вставьте сюда название группы\r\nв соответствии с ФИО\r\nПример:\r\n\r\nБА-ТЕСТ\r\nМ-ПРИМЕР" +
    "";
            this.labelGroup4.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textGroup4
            // 
            this.textGroup4.Location = new System.Drawing.Point(333, 107);
            this.textGroup4.Name = "textGroup4";
            this.textGroup4.Size = new System.Drawing.Size(167, 317);
            this.textGroup4.TabIndex = 11;
            this.textGroup4.Text = "";
            this.textGroup4.TextChanged += new System.EventHandler(this.textGroup4_TextChanged);
            // 
            // labelCountFIO
            // 
            this.labelCountFIO.AutoSize = true;
            this.labelCountFIO.Location = new System.Drawing.Point(12, 428);
            this.labelCountFIO.Name = "labelCountFIO";
            this.labelCountFIO.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelCountFIO.Size = new System.Drawing.Size(79, 13);
            this.labelCountFIO.TabIndex = 12;
            this.labelCountFIO.Text = "Кол-во строк: ";
            // 
            // labelCountNumber
            // 
            this.labelCountNumber.AutoSize = true;
            this.labelCountNumber.Location = new System.Drawing.Point(203, 428);
            this.labelCountNumber.Name = "labelCountNumber";
            this.labelCountNumber.Size = new System.Drawing.Size(79, 13);
            this.labelCountNumber.TabIndex = 13;
            this.labelCountNumber.Text = "Кол-во строк: ";
            // 
            // labelCountGroup
            // 
            this.labelCountGroup.AutoSize = true;
            this.labelCountGroup.Location = new System.Drawing.Point(333, 428);
            this.labelCountGroup.Name = "labelCountGroup";
            this.labelCountGroup.Size = new System.Drawing.Size(79, 13);
            this.labelCountGroup.TabIndex = 14;
            this.labelCountGroup.Text = "Кол-во строк: ";
            // 
            // labelWarningUnderExport
            // 
            this.labelWarningUnderExport.AutoSize = true;
            this.labelWarningUnderExport.Location = new System.Drawing.Point(533, 428);
            this.labelWarningUnderExport.Name = "labelWarningUnderExport";
            this.labelWarningUnderExport.Size = new System.Drawing.Size(211, 13);
            this.labelWarningUnderExport.TabIndex = 15;
            this.labelWarningUnderExport.Text = "Кол-ва строк должны совпадать с ФИО";
            // 
            // buttonInstruction
            // 
            this.buttonInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInstruction.Location = new System.Drawing.Point(644, 453);
            this.buttonInstruction.Name = "buttonInstruction";
            this.buttonInstruction.Size = new System.Drawing.Size(110, 25);
            this.buttonInstruction.TabIndex = 16;
            this.buttonInstruction.Text = "Инструкция";
            this.buttonInstruction.UseVisualStyleBackColor = true;
            this.buttonInstruction.Click += new System.EventHandler(this.buttonInstruction_Click);
            // 
            // buttonSuggestions
            // 
            this.buttonSuggestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSuggestions.Location = new System.Drawing.Point(12, 453);
            this.buttonSuggestions.Name = "buttonSuggestions";
            this.buttonSuggestions.Size = new System.Drawing.Size(133, 25);
            this.buttonSuggestions.TabIndex = 17;
            this.buttonSuggestions.Text = "Предложения, отзывы";
            this.buttonSuggestions.UseVisualStyleBackColor = true;
            this.buttonSuggestions.Click += new System.EventHandler(this.buttonSuggestions_Click);
            // 
            // buttonDir
            // 
            this.buttonDir.Location = new System.Drawing.Point(547, 334);
            this.buttonDir.Name = "buttonDir";
            this.buttonDir.Size = new System.Drawing.Size(180, 20);
            this.buttonDir.TabIndex = 18;
            this.buttonDir.Text = "Открыть папку с файлом";
            this.buttonDir.UseVisualStyleBackColor = true;
            this.buttonDir.Click += new System.EventHandler(this.buttonDir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 490);
            this.Controls.Add(this.buttonDir);
            this.Controls.Add(this.buttonSuggestions);
            this.Controls.Add(this.buttonInstruction);
            this.Controls.Add(this.labelWarningUnderExport);
            this.Controls.Add(this.labelCountGroup);
            this.Controls.Add(this.labelCountNumber);
            this.Controls.Add(this.labelCountFIO);
            this.Controls.Add(this.textGroup4);
            this.Controls.Add(this.labelGroup4);
            this.Controls.Add(this.labelError4);
            this.Controls.Add(this.labelTag3);
            this.Controls.Add(this.textTag3);
            this.Controls.Add(this.labelNumber2);
            this.Controls.Add(this.labelFIO1);
            this.Controls.Add(this.textNumber2);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.textFIO1);
            this.Name = "Form1";
            this.Text = "САКЭ 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox textFIO1;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.RichTextBox textNumber2;
        private System.Windows.Forms.Label labelFIO1;
        private System.Windows.Forms.Label labelNumber2;
        private System.Windows.Forms.Label labelTag3;
        private System.Windows.Forms.Label labelError4;
        private System.Windows.Forms.TextBox textTag3;
        private System.Windows.Forms.Label labelGroup4;
        private System.Windows.Forms.RichTextBox textGroup4;
        private System.Windows.Forms.Label labelCountFIO;
        private System.Windows.Forms.Label labelCountNumber;
        private System.Windows.Forms.Label labelCountGroup;
        private System.Windows.Forms.Label labelWarningUnderExport;
        private System.Windows.Forms.Button buttonInstruction;
        private System.Windows.Forms.Button buttonSuggestions;
        private System.Windows.Forms.Button buttonDir;
    }
}

