using System;
using System.Windows.Forms;
using System.IO;

namespace Mostootriad_55
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }
        public string path;
        private void Setting_Load(object sender, EventArgs e)
        {
            try
            {
                FileStream file = new FileStream("config.txt", FileMode.Open, FileAccess.Read);
                StreamReader myreader = new StreamReader(file);
                textBox1.Text = myreader.ReadLine();
                textBox2.Text = myreader.ReadLine();
                string RadioBtn = myreader.ReadLine();
                mdlData.RadioBtn = Convert.ToBoolean(RadioBtn);
                if (mdlData.RadioBtn == true)
                {
                    radioButton1.Checked = false;
                    radioButton2.Checked = true;
                    textBox3.Text = myreader.ReadLine();
                    textBox4.Text = myreader.ReadLine();
                }
                if (mdlData.RadioBtn == false)
                {
                    radioButton1.Checked = true;
                    radioButton2.Checked = false;
                }
                path = myreader.ReadLine();
                myreader.Close(); file.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Incorrect config file or file does not exist!", "Saved Config File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //bool IntSecurity;
            //radioButton2.Visible=false;
            mdlData.RadioBtn = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            label3.Enabled = false;
            label4.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            mdlData.RadioBtn = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Объявляем файловую переменную
            FileInfo file = new FileInfo(@"config.txt");
            file.Delete();
            FileStream fileNew = new FileStream("config.txt", FileMode.Create, FileAccess.ReadWrite);
            StreamWriter toWriteText = new StreamWriter(fileNew);
            //Объявляем класс для записи в файл
            try
            {
                //Переписываем содержимое. Если файла не существует он создастся
                toWriteText.WriteLine(textBox1.Text);
                toWriteText.WriteLine(textBox2.Text);
                if (mdlData.RadioBtn == true)
                {
                    radioButton2.Checked = true;
                    toWriteText.WriteLine("true");
                    toWriteText.WriteLine(textBox3.Text);
                    toWriteText.WriteLine(textBox4.Text);
                }
                if (mdlData.RadioBtn == false)
                {
                    radioButton1.Checked = true;
                    toWriteText.WriteLine("false");
                }
                toWriteText.WriteLine(path);
                // Закрываем файл
                toWriteText.Close();
                MessageBox.Show("Настройки сохранены в файл " + file, "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Настройки сохранены в файл " + file, "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }    
    }
}
