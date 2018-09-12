using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Mostootriad_55
{
    public partial class EditCompany : Form
    {
        public int ID;
        public string NameComp;
        public EditCompany()
        {
            InitializeComponent();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnEditCompany_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Пожалуйста заполните все поля.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            for (int j = 0; j < mdlData.colCompany.Count; j++)
            {
                if (textBox1.Text == mdlData.colCompany[j].Name && NameComp != mdlData.colCompany[j].Name)
                {
                    MessageBox.Show("Такая компания уже существует! Пожалуйста введите другое имя.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }               
            }
            try
            {
                for (int i = 0; i < mdlData.colCompany.Count; i++)
                {
                    if (mdlData.colCompany[i].ID == ID)
                    {
                        mdlData.colCompany[i].Name = textBox1.Text;
                        mdlData.colCompany[i].ID_INN_KPP = textBox2.Text;
                        mdlData.colCompany[i].Address = textBox3.Text;
                        mdlData.colCompany[i].Tel = textBox4.Text;
                    }
                }
                //Запись в БД
                mdlData.ready = true;
                mdlData.ConnectDataBase();
                SqlCommand cmd = mdlData.cnn.CreateCommand();
                cmd.CommandText = "UPDATE company SET Name = '" + textBox1.Text +
                                                      "', ID_INN_KPP = '" + textBox2.Text +
                                                      "', Address ='" + textBox3.Text +
                                                      "', Tel ='" + textBox4.Text +
                                                      "' where ID = '" + ID + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Данные о компании изменены", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //mdlData.StatusAdd = true;
                mdlData.cnn.Close();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Не удалось изменить данные о компании", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void EditCompany_Load(object sender, EventArgs e)
        {
            textBox1.Text = NameComp;
            for (int i = 0; i < mdlData.colCompany.Count; i++)
            {
                if (mdlData.colCompany[i].ID == ID)
                {
                    textBox2.Text = mdlData.colCompany[i].ID_INN_KPP;
                    textBox3.Text = mdlData.colCompany[i].Address;
                    textBox4.Text = mdlData.colCompany[i].Tel;
                }
            }
        }
    }
}
