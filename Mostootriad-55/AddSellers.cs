using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Mostootriad_55
{
    public partial class AddSellers : Form
    {
        public AddSellers()
        {
            InitializeComponent();
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            Data.EventHandlerScan = new Data.MyEventScan(ScanDocuments);
        }
        void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = comboBox2.SelectedItem.ToString();
            for (int i = 0; i < mdlData.colCompany.Count; i++)
            {
                if (mdlData.colCompany[i].Name == selectedState)
                {
                    textBox2.Text = mdlData.colCompany[i].ID_INN_KPP;
                }
            }
        }
        void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = comboBox1.SelectedItem.ToString();
            for (int i = 0; i < mdlData.colCompany.Count; i++)
            {
                if (mdlData.colCompany[i].Name == selectedState)
                {
                    textBox1.Text = mdlData.colCompany[i].ID_INN_KPP;
                }
            }
        }
        private void button1_url_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Выберите файл";
            openFileDialog1.Filter = "Текстовые файлы|*.pdf";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox5_url.Text = openFileDialog1.FileName;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Выберите файл";
            openFileDialog1.Filter = "Текстовые файлы|*.pdf";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox6_url.Text = openFileDialog1.FileName;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Выберите файл";
            openFileDialog1.Filter = "Текстовые файлы|*.pdf";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox7_url.Text = openFileDialog1.FileName;
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Выберите файл";
            openFileDialog1.Filter = "Текстовые файлы|*.pdf";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox6.Text = openFileDialog1.FileName;
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Выберите файл";
            openFileDialog1.Filter = "Текстовые файлы|*.pdf";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox7.Text = openFileDialog1.FileName;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void AddSellers_Load(object sender, EventArgs e)
        {
            List<string> Object = new List<string>();
            List<string> Company = new List<string>();
            //Добавление отсортированной коллекции объектов в comboBox
            for (int i = 0; i < mdlData.colObject.Count; i++)
            {
                Object.Add(mdlData.colObject[i].Name);
                Object.Sort();
            }
            for (int i = 0; i < Object.Count; i++)
            {
                comboBox3.Items.Add(Object[i]);
            }
            //Добавление отсортированной коллекции городов в comboBox
            for (int i = 0; i < mdlData.colCompany.Count; i++)
            {
                Company.Add(mdlData.colCompany[i].Name);
                Company.Sort();
            }
            for (int i = 0; i < Company.Count; i++)
            {
                comboBox1.Items.Add(Company[i]);
                comboBox2.Items.Add(Company[i]);
            }
            if (mdlData.ScanDocRadioBtn > 0)
            {
                ScanDocuments();
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "" || textBox4.Text == "" || comboBox1.Text == "" || comboBox2.Text == "" || comboBox3.Text == "" /*|| textBox7_url.Text == ""*/)
            {
                MessageBox.Show("Пожалуйста заполните все поля отмеченные звездочкой.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //Добавление в коллекцию
            try
            {
                mdlData.GrnNumberID = "";
                clsSellers Sel = new clsSellers();
                mdlData.colSellers.Add(Sel);
                int i = mdlData.colSellers.Count;
                mdlData.GenNumberID();
                for (int k = 0; k < mdlData.colSellers.Count; k++)
                {
                    if (mdlData.colSellers[k].ID == Convert.ToInt32(mdlData.GrnNumberID))
                    {
                        mdlData.GrnNumberID = "";
                        mdlData.GenNumberID();
                        k = 0;
                    }
                    else { continue; }
                }
                mdlData.colSellers[i - 1].TypeContract = comboBox4.Text;
                mdlData.colSellers[i - 1].ID = Convert.ToInt32(mdlData.GrnNumberID);
                for (int j = 0; j < mdlData.colObject.Count; j++)
                {
                    if (mdlData.colObject[j].Name == comboBox3.Text)
                    {
                        mdlData.colSellers[i - 1].ObjectN = mdlData.colObject[j].ID;
                    }
                }
                for (int j = 0; j < mdlData.colCompany.Count; j++)
                {
                    if (mdlData.colCompany[j].Name == comboBox1.Text)
                    {
                        mdlData.colSellers[i - 1].Client = mdlData.colCompany[j].ID;
                    }
                    if (mdlData.colCompany[j].Name == comboBox2.Text)
                    {
                        mdlData.colSellers[i - 1].Performer = mdlData.colCompany[j].ID;
                    }
                }
                mdlData.colSellers[i - 1].ContractNumber = textBox3.Text;
                mdlData.colSellers[i - 1].dateDoc = textBox4.Text;

                string DirObject = mdlData.colSellers[i - 1].ObjectN.ToString();
                string PdfFileKc = System.IO.Path.GetFileName(textBox5_url.Text);//КС
                string PdfFileInvoice = System.IO.Path.GetFileName(textBox6_url.Text);//счет-фактура
                string PdfFileDog = System.IO.Path.GetFileName(textBox7_url.Text);//договор
                string PdfFileСonsignment = System.IO.Path.GetFileName(textBox6.Text);//Накладные
                string PdfFileAct = System.IO.Path.GetFileName(textBox7.Text);//Фкты
                string pathFrom;
                if (textBox7_url.Text != "")
                {
                    pathFrom = mdlData.path + @"\" + DirObject + @"\sellers\" + PdfFileDog;
                    mdlData.colSellers[i - 1].pdf_dog = pathFrom;
                    File.Copy(textBox7_url.Text, pathFrom, true);
                }
                if (textBox6_url.Text != "")
                {
                    pathFrom = mdlData.path + @"\" + DirObject + @"\sellers\" + PdfFileInvoice;
                    mdlData.colSellers[i - 1].pdf_invoice = pathFrom;
                    File.Copy(textBox6_url.Text, pathFrom, true);
                }
                if (textBox5_url.Text != "")
                {
                    pathFrom = mdlData.path + @"\" + DirObject + @"\sellers\" + PdfFileKc;
                    mdlData.colSellers[i - 1].pdf_kc = pathFrom;
                    File.Copy(textBox5_url.Text, pathFrom, true);
                }
                if (textBox6.Text != "")
                {
                    pathFrom = mdlData.path + @"\" + DirObject + @"\sellers\" + PdfFileСonsignment;
                    mdlData.colSellers[i - 1].pdf_consignment = pathFrom;
                    File.Copy(textBox6.Text, pathFrom, true);
                }
                if (textBox7.Text != "")
                {
                    pathFrom = mdlData.path + @"\" + DirObject + @"\sellers\" + PdfFileAct;
                    mdlData.colSellers[i - 1].pdf_act = pathFrom;
                    File.Copy(textBox7.Text, pathFrom, true);
                }
                mdlData.colSellers[i - 1].note = textBox5.Text;
                //Запись в БД
                mdlData.ready = true;
                mdlData.ConnectDataBase();
                SqlCommand cmd = mdlData.cnn.CreateCommand();
                cmd.CommandText = "INSERT INTO sellers(ID,ObjectN,Client,Performer,TypeContract,ContractNumber,dateDoc,pdf_kc,pdf_invoice,pdf_dog,pdf_consignment,pdf_act,note) VALUES ('" + mdlData.colSellers[i - 1].ID +
                                                                       "','" + mdlData.colSellers[i - 1].ObjectN +
                                                                        "','" + mdlData.colSellers[i - 1].Client +
                                                                         "','" + mdlData.colSellers[i - 1].Performer +
                                                                         "','" + mdlData.colSellers[i - 1].TypeContract +
                                                                         "','" + mdlData.colSellers[i - 1].ContractNumber +
                                                                         "','" + mdlData.colSellers[i - 1].dateDoc +
                                                                         "','" + mdlData.colSellers[i - 1].pdf_kc +
                                                                         "','" + mdlData.colSellers[i - 1].pdf_invoice +
                                                                         "','" + mdlData.colSellers[i - 1].pdf_dog +
                                                                         "','" + mdlData.colSellers[i - 1].pdf_consignment +
                                                                         "','" + mdlData.colSellers[i - 1].pdf_act +
                                                                         "','" + mdlData.colSellers[i - 1].note + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Запись добавлена", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mdlData.StatusAdd = true;
                mdlData.cnn.Close();
                addI.Value = i;
                addI.Value_ObjectN = comboBox3.Text;
                addI.Value_Client = comboBox1.Text;
                addI.Value_Performer = comboBox2.Text;
                mdlData.CountScanDocument = 0;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось добавить объект: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //выбор даты
        public void SetText(string text)
        {
            textBox4.Text = text;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            frmKalendar2 fKalen = new frmKalendar2(this);
            fKalen.Owner = this;
            fKalen.ShowDialog();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Specify that the link was visited.
            this.linkLabel1.LinkVisited = true;

            // Navigate to a URL.
            System.Diagnostics.Process.Start("https://smallpdf.com/ru/merge-pdf");
        }
        private void button8_Click(object sender, EventArgs e)
        {
            string path = textBox5_url.Text;
            mdlData.selectFolderFile(path);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string path = textBox6_url.Text;
            mdlData.selectFolderFile(path);
        }
        private void button10_Click(object sender, EventArgs e)
        {
            string path = textBox7_url.Text;
            mdlData.selectFolderFile(path);
        }
        private void button11_Click(object sender, EventArgs e)
        {
            string path = textBox6.Text;
            mdlData.selectFolderFile(path);
        }
        private void button12_Click(object sender, EventArgs e)
        {
            string path = textBox7.Text;
            mdlData.selectFolderFile(path);
        }
        //Сканирование документов
        private void ScanDocuments()
        {
            string imagePath = mdlData.ScanImage();
            if (mdlData.ScanDocRadioBtn == 1)
            {
                textBox5_url.Text = imagePath;
            }
            if (mdlData.ScanDocRadioBtn == 2)
            {
                textBox6_url.Text = imagePath;
            }
            if (mdlData.ScanDocRadioBtn == 3)
            {
                textBox7_url.Text = imagePath;
            }
            if (mdlData.ScanDocRadioBtn == 4)
            {
                textBox6.Text = imagePath;
            }
            if (mdlData.ScanDocRadioBtn == 5)
            {
                textBox7.Text = imagePath;
            }
        }
    }
}
