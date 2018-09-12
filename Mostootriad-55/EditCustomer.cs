using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Mostootriad_55
{
    public partial class EditCustomer : Form
    {
        public string NameObj, NameClient, NamePerformer, DateTimeS;
        public string url5, url6, url7;
        public int ID;
        public int ObjectID, ClientID, PerformerID;
        public string pdf_dog, pdf_invoice, pdf_kc;
        public EditCustomer()
        {
            InitializeComponent();
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
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
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Specify that the link was visited.
            this.linkLabel1.LinkVisited = true;

            // Navigate to a URL.
            System.Diagnostics.Process.Start("https://smallpdf.com/ru/merge-pdf");
        }
        private void button6_Click(object sender, EventArgs e)
        {
            string path = textBox7_url.Text;
            mdlData.selectFolderFile(path);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            string path = textBox6_url.Text;
            mdlData.selectFolderFile(path);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            string path = textBox5_url.Text;
            mdlData.selectFolderFile(path);
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
            this.Close();
        }
        private void EditCustomer_Load(object sender, EventArgs e)
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
            comboBox1.Text = NameClient;
            comboBox2.Text = NamePerformer;
            comboBox3.Text = NameObj;
            for (int j = 0; j < mdlData.colCustomer.Count; j++)
            {
                if (mdlData.colCustomer[j].ID == ID)
                {
                    textBox5_url.Text = mdlData.colCustomer[j].pdf_kc; url5 = textBox5_url.Text;
                    textBox6_url.Text = mdlData.colCustomer[j].pdf_invoice; url6 = textBox6_url.Text;
                    textBox7_url.Text = mdlData.colCustomer[j].pdf_dog; url7 = textBox7_url.Text;
                    textBox3.Text = mdlData.colCustomer[j].ContractNumber;
                    textBox4.Text = Convert.ToDateTime(mdlData.colCustomer[j].dateDoc).ToString("dd'.'MM'.'yy");
                    //DateTimeS = Convert.ToDateTime(mdlData.colCustomer[j].dateDoc).ToString("dd'.'MM'.'yy");
                    textBox5.Text = mdlData.colCustomer[j].note;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Сохранить изменения?", "Внимание",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;
            else
            {
                if (textBox3.Text == "" || textBox4.Text == "" || comboBox1.Text == "" || comboBox2.Text == "" || comboBox3.Text == "" /*|| textBox7_url.Text == ""*/)
                {
                    MessageBox.Show("Пожалуйста заполните все поля отмеченные звездочкой.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                //Сохранение изменений в коллекцию
                try
                {
                    int i = mdlData.colCustomer.Count;
                    for (int j = 0; j < mdlData.colObject.Count; j++)
                    {
                        if (mdlData.colObject[j].Name == comboBox3.Text)
                        {
                            ObjectID = mdlData.colObject[j].ID;
                        }
                    }
                    for (int j = 0; j < mdlData.colCompany.Count; j++)
                    {
                        if (mdlData.colCompany[j].Name == comboBox1.Text)
                        {
                            ClientID = mdlData.colCompany[j].ID;
                        }
                        if (mdlData.colCompany[j].Name == comboBox2.Text)
                        {
                            PerformerID = mdlData.colCompany[j].ID;
                        }
                    }
                    string DirObject = ObjectID.ToString();
                    string PdfFileKc = System.IO.Path.GetFileName(textBox5_url.Text);//КС
                    string PdfFileInvoice = System.IO.Path.GetFileName(textBox6_url.Text);//счет-фактура
                    string PdfFileDog = System.IO.Path.GetFileName(textBox7_url.Text);//договор
                    string pathFrom;
                    if (url7 != textBox7_url.Text && textBox7_url.Text != "")
                    {
                        pathFrom = mdlData.path + @"\" + DirObject + @"\customer\" + PdfFileDog;
                        pdf_dog = pathFrom;
                        File.Copy(textBox7_url.Text, pathFrom, true);
                    }
                    else { pdf_dog = textBox7_url.Text; }
                    if (url6 != textBox6_url.Text && textBox6_url.Text != "")
                    {
                        pathFrom = mdlData.path + @"\" + DirObject + @"\customer\" + PdfFileInvoice;
                        pdf_invoice = pathFrom;
                        File.Copy(textBox6_url.Text, pathFrom, true);
                    }
                    else { pdf_invoice = textBox6_url.Text; }
                    if (url5 != textBox5_url.Text && textBox5_url.Text != "")
                    {
                        pathFrom = mdlData.path + @"\" + DirObject + @"\customer\" + PdfFileKc;
                        pdf_kc = pathFrom;
                        File.Copy(textBox5_url.Text, pathFrom, true);
                    }
                    else { pdf_kc = textBox5_url.Text; }
                    //Запись в коллекцию
                    for (int j = 0; j < mdlData.colCustomer.Count; j++)
                    {
                        if (mdlData.colCustomer[j].ID == ID)
                        {
                            mdlData.colCustomer[j].ObjectN = ObjectID;
                            mdlData.colCustomer[j].Client = ClientID;
                            mdlData.colCustomer[j].Performer = PerformerID;
                            mdlData.colCustomer[j].ContractNumber = textBox3.Text;
                            mdlData.colCustomer[j].pdf_kc = pdf_kc;
                            mdlData.colCustomer[j].pdf_invoice = pdf_invoice;
                            mdlData.colCustomer[j].pdf_dog = pdf_dog;
                            mdlData.colCustomer[j].dateDoc = textBox4.Text;
                            mdlData.colCustomer[j].note = textBox5.Text;
                        }
                    }
                    //Запись в БД
                    mdlData.ready = true;
                    mdlData.ConnectDataBase();
                    SqlCommand cmd = mdlData.cnn.CreateCommand();
                    cmd.CommandText = "UPDATE customer SET ObjectN = '" + ObjectID +
                                                        "', Client = '" + ClientID +
                                                        "', Performer ='" + PerformerID +
                                                        "', ContractNumber ='" + textBox3.Text +
                                                        "', dateDoc = '" + textBox4.Text +
                                                        "', pdf_kc = '" + pdf_kc +
                                                        "', pdf_invoice = '" + pdf_invoice +
                                                        "', pdf_dog = '" + pdf_dog +
                                                        "', note = '" + textBox5.Text +
                                                        "' where ID = '" + ID + "'";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Данные сохранены!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //mdlData.StatusAdd = true;
                    mdlData.statusEdit = true;
                    mdlData.cnn.Close();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не удалось сохранить изменения: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //выбор даты
        public void SetText(string text)
        {
            textBox4.Text = text;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            frmKalendarEdit fKalen = new frmKalendarEdit(this);
            fKalen.Owner = this;
            fKalen.ShowDialog();
        }
    }
}
