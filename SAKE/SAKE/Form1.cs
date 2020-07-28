using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SAKE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            labelCountFIO.Text = "Кол-во строк: " + textFIO1.Text.Split('\n').Length.ToString();
        }
        private void textNumber2_TextChanged(object sender, EventArgs e)
        {
            labelCountNumber.Text = "Кол-во строк: " + textNumber2.Text.Split('\n').Length.ToString();
        }
        private void textGroup4_TextChanged(object sender, EventArgs e)
        {
            labelCountGroup.Text = "Кол-во строк: " + textGroup4.Text.Split('\n').Length.ToString();
        }

        private bool correct()
        {
            string[] splittedFIO = textFIO1.Text.Split('\n');
            string[] splittedNumber = textNumber2.Text.Split('\n');
            string[] splittedGroup = textGroup4.Text.Split('\n');
            
            labelCountFIO.Text = "Кол-во строк: " + splittedFIO.Length.ToString();
            labelCountNumber.Text = "Кол-во строк: " + splittedNumber.Length.ToString();
            labelCountGroup.Text = "Кол-во строк: " + splittedGroup.Length.ToString();

            if (splittedFIO.Length != splittedNumber.Length
                && splittedFIO.Length != splittedGroup.Length)
            {
                MessageBox.Show("ПРЕДУПРЕЖДЕНИЕ " + "Количество номеров и групп не совпадает с количеством ФИО\n"
                    + "Связь с разработчиком: +7(964)-417-97-97 (Еркен)");
                return true;
            }
            if (textFIO1.Text.Split('\n').Length != textNumber2.Text.Split('\n').Length)
            {
                MessageBox.Show("ПРЕДУПРЕЖДЕНИЕ " + "Количество номеров не совпадает с количеством ФИО\n"
                    + "Связь с разработчиком: +7(964)-417-97-97 (Еркен)");
                return true;
            }
            if (textFIO1.Text.Split('\n').Length != textGroup4.Text.Split('\n').Length)
            {
                MessageBox.Show("ПРЕДУПРЕЖДЕНИЕ " + "Количество групп не совпадает с количеством ФИО\n"
                    + "Связь с разработчиком: +7(964)-417-97-97 (Еркен)");
                return true;
            }

            return true;
        }

        private void export()
        {
            string[] stringFIO = textFIO1.Text.Split('\n');
            string[] stringNumber = textNumber2.Text.Split('\n');
            string[] stringGroup = textGroup4.Text.Split('\n');
            string stringTag = textTag3.Text;
            int lenFIO = stringFIO.Length;
            //FileStream fout = new FileStream("contactsBySAKE.txt", FileMode.Create);
            StreamWriter writer = new StreamWriter("contactsBySAKE.vcf");

            for (int i=0; i<lenFIO;i++)
            {
                try
                {
                    writer.Write("BEGIN:VCARD\nVERSION:3.0\nN:" + stringTag + ";"
                        + stringFIO[i] + ";" + stringGroup[i] + ";\nFN:" + stringTag + ' ' + stringFIO[i]
                        + "\nTEL;type=CELL;type=VOICE;waid=" + stringNumber[i] + ":" + stringNumber[i] + "\nEND:VCARD\n\n");
                } catch (Exception exception1)
                {
                    MessageBox.Show("ОШИБКА в обработке\nКонтакт "+stringFIO[i]+" не экспортирован\n\n"
                        + exception1 + ".\n\nСвязь с разработчиком: +7(964)-417-97-97 (Еркен)");
                }
            }
            writer.Close();

            labelError4.ForeColor = Color.Green;
            labelError4.Text = "УСПЕХ " + "контакты экспортированы";
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            try
            {
                if (correct()) //проверяет строки и отобр. их кол-во
                {
                    export(); 
                }
            } catch(Exception exception1)
            {
                labelError4.ForeColor = Color.Red;
                labelError4.Text = "ОШИБКА " + exception1 + ".\nСвязь с разработчиком: +7(964)-417-97-97 (Еркен)";
            }
            
        }

        private void buttonInstruction_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://forms.gle/RG7wQeKnNQ3VaV6D9");
        }

        private void buttonSuggestions_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://forms.gle/RG7wQeKnNQ3VaV6D9");
        }
    }
}
