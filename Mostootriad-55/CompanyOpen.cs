using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Mostootriad_55
{
    public partial class CompanyOpen : Form
    {
        public CompanyOpen()
        {
            InitializeComponent();
        }
        public int ID;
        private void listBoxUpdate()
        {
            List<string> Company = new List<string>();
            //Добавление отсортированной коллекции городов в comboBox
            for (int i = 0; i < mdlData.colCompany.Count; i++)
            {
                Company.Add(mdlData.colCompany[i].Name);
                Company.Sort();
            }
            for (int i = 0; i < Company.Count; i++)
            {
                listBox1.Items.Add(Company[i]);
            }
        }
        private void CompanyOpen_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBoxUpdate();
            if (mdlData.colCompany.Count > 0)
            {
                listBox1.SetSelected(0, true);
            }
            if(mdlData.colCompany.Count <= 0) { button2.Enabled = false; button3.Enabled = false; }
        }
        private void listBox1_SelectedItem(object sender, EventArgs e)
        {
            // Получить текущий выбранный элемент в ListBox. 
            string curItem = listBox1.SelectedItem.ToString();
            for (int i = 1; i <= mdlData.colCompany.Count; i++)
            {
                if (mdlData.colCompany[i-1].Name == curItem)
                {
                    textBox1.Text = curItem;
                    textBox1.Text += Environment.NewLine + Environment.NewLine + "ИНН/КПП:" + Environment.NewLine + mdlData.colCompany[i - 1].ID_INN_KPP + Environment.NewLine + Environment.NewLine
                                  + "Юридический адрес:" + Environment.NewLine + mdlData.colCompany[i - 1].Address + Environment.NewLine + Environment.NewLine
                                  + "Телефон:" + Environment.NewLine + mdlData.colCompany[i - 1].Tel;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AddCompany Form = new AddCompany();
            Form.Owner = this;
            Form.ShowDialog();
            listBox1.Items.Clear();
            textBox1.Clear();
            listBoxUpdate();
            if (mdlData.colCompany.Count > 0)
            {
                listBox1.SetSelected(0, true);
            }
            if (mdlData.colCompany.Count > 0 && button2.Enabled != true && button3.Enabled != true)
            {
                button2.Enabled = true; button3.Enabled = true;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string curItem = listBox1.SelectedItem.ToString();
            for (int i = 1; i <= mdlData.colCompany.Count; i++)
            {
                if (mdlData.colCompany[i - 1].Name == curItem)
                {
                    mdlData.ConnectDataBase();
                    SqlCommand cmd = mdlData.cnn.CreateCommand();
                    try
                    {
                        cmd.CommandText = "DELETE FROM company WHERE Name = '" + curItem + "'";
                        cmd.ExecuteNonQuery();              
                        mdlData.colCompany.Remove(mdlData.colCompany[i - 1]);
                        //listBox1.Items.Remove(listBox1.SelectedItem);
                        MessageBox.Show("Компания удалена!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Data.EventHandlerCompany();
                        Data.EventHandlerCompanySellers();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ошибка Удаления. Прежде чем удалить компанию, необхадимо удалить все записи связанные с ней.", "Удаление компании", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }       
                    mdlData.cnn.Close();
                }               
            }
            CompanyOpen_Load(sender, e);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string comp = listBox1.SelectedItem.ToString();
            for (int i = 1; i <= mdlData.colCompany.Count; i++)
            {
                if (mdlData.colCompany[i - 1].Name == comp)
                {
                    ID = mdlData.colCompany[i - 1].ID;
                }
            }
            EditCompany FormEdit = new EditCompany();
            FormEdit.Owner = this;
            FormEdit.NameComp = comp;
            FormEdit.ID = ID;
            FormEdit.ShowDialog();
            listBox1.Items.Clear();
            listBoxUpdate();
            listBox1.SetSelected(0, true);
        }
    }
}
