using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Mostootriad_55
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
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
        private void button4_Click(object sender, EventArgs e)
        {
            mdlData.CountScanDocument = 0;
            this.Close();
        }
        private void AddCustomer_Load(object sender, EventArgs e)
        {
            List<string> Object = new List<string>();
            List<string> Company = new List<string>();
            //comboBox1.Items.Add(""); comboBox2.Items.Add(""); comboBox3.Items.Add("");
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
            if (textBox3.Text == "" || textBox4.Text == "" || comboBox1.Text==""||comboBox2.Text==""||comboBox3.Text==""/*||textBox7_url.Text==""*/)
            {
                MessageBox.Show("Пожалуйста заполните все поля отмеченные звездочкой.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //Добавление в коллекцию
            try
            {
                mdlData.GrnNumberID = "";
                clsCustomer Cust = new clsCustomer();
                mdlData.colCustomer.Add(Cust);
                int i = mdlData.colCustomer.Count;
                mdlData.GenNumberID();
                for (int k = 0; k < mdlData.colCustomer.Count; k++)
                {
                    if (mdlData.colCustomer[k].ID == Convert.ToInt32(mdlData.GrnNumberID))
                    {
                        mdlData.GrnNumberID = "";
                        mdlData.GenNumberID();
                        k = 0;
                    }
                    else { continue; }
                }

                mdlData.colCustomer[i - 1].ID = Convert.ToInt32(mdlData.GrnNumberID);
                for (int j = 0; j < mdlData.colObject.Count; j++)
                {
                    if (mdlData.colObject[j].Name == comboBox3.Text)
                    {
                        mdlData.colCustomer[i - 1].ObjectN = mdlData.colObject[j].ID;
                    }
                }            
                for (int j = 0; j < mdlData.colCompany.Count; j++)
                {
                    if (mdlData.colCompany[j].Name == comboBox1.Text)
                    {
                        mdlData.colCustomer[i - 1].Client = mdlData.colCompany[j].ID;
                    }
                    if (mdlData.colCompany[j].Name == comboBox2.Text)
                    {
                        mdlData.colCustomer[i - 1].Performer = mdlData.colCompany[j].ID;
                    }
                }
                mdlData.colCustomer[i - 1].ContractNumber = textBox3.Text;
                mdlData.colCustomer[i - 1].dateDoc = textBox4.Text;
                string DirObject = mdlData.colCustomer[i - 1].ObjectN.ToString();
                string PdfFileKc = System.IO.Path.GetFileName(textBox5_url.Text);//КС
                string PdfFileInvoice = System.IO.Path.GetFileName(textBox6_url.Text);//счет-фактура
                string PdfFileDog = System.IO.Path.GetFileName(textBox7_url.Text);//договор
                string pathFrom;
                if (textBox7_url.Text != "")
                {
                    pathFrom = mdlData.path + @"\" + DirObject + @"\customer\" + PdfFileDog;
                    mdlData.colCustomer[i - 1].pdf_dog = pathFrom;
                    File.Copy(textBox7_url.Text, pathFrom, true);
                }
                if (textBox6_url.Text != "")
                {
                    pathFrom = mdlData.path + @"\" + DirObject + @"\customer\" + PdfFileInvoice;
                    mdlData.colCustomer[i - 1].pdf_invoice = pathFrom;
                    File.Copy(textBox6_url.Text, pathFrom, true);
                }
                if (textBox5_url.Text != "")
                {
                    pathFrom = mdlData.path + @"\" + DirObject + @"\customer\" + PdfFileKc;
                    mdlData.colCustomer[i - 1].pdf_kc = pathFrom;
                    File.Copy(textBox5_url.Text, pathFrom, true);
                }
                mdlData.colCustomer[i - 1].note = textBox5.Text;
                //Запись в БД
                mdlData.ready = true;
                mdlData.ConnectDataBase();
                SqlCommand cmd = mdlData.cnn.CreateCommand();
                cmd.CommandText = "INSERT INTO customer(ID,ObjectN,Client,Performer,ContractNumber,dateDoc,pdf_kc,pdf_invoice,pdf_dog,note) VALUES ('" + mdlData.colCustomer[i - 1].ID +
                                                                       "','" + mdlData.colCustomer[i - 1].ObjectN +
                                                                        "','" + mdlData.colCustomer[i - 1].Client +
                                                                         "','" + mdlData.colCustomer[i - 1].Performer +
                                                                         "','" + mdlData.colCustomer[i - 1].ContractNumber +
                                                                         "','" + mdlData.colCustomer[i - 1].dateDoc +
                                                                         "','" + mdlData.colCustomer[i - 1].pdf_kc +
                                                                         "','" + mdlData.colCustomer[i - 1].pdf_invoice +
                                                                         "','" + mdlData.colCustomer[i - 1].pdf_dog +
                                                                          "','" + mdlData.colCustomer[i - 1].note + "')";
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
                //this.Close();
            }
        }
        //выбор даты
        public void SetText(string text)
        {
            textBox4.Text = text;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            frmKalendar fKalen = new frmKalendar(this);
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
        private void button7_Click(object sender, EventArgs e)
        {
            string path = textBox6_url.Text;
            mdlData.selectFolderFile(path);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string path = textBox7_url.Text;
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
        }
    }
}
