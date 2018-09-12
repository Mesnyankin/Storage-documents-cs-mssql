using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Mostootriad_55
{
    public partial class AddCompany : Form
    {
        public AddCompany()
        {
            InitializeComponent();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAddCompany_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Пожалуйста заполните все поля отмеченные звездочкой.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            for (int j = 0; j < mdlData.colCompany.Count; j++)
            {
                if (textBox1.Text == mdlData.colCompany[j].Name)
                {
                    MessageBox.Show("Такая компания уже существует! Пожалуйста введите другое имя.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            try
            {
                //Добавление в коллекцию
                mdlData.GrnNumberID = "";
                clsCompany Cmp = new clsCompany();
                mdlData.colCompany.Add(Cmp);
                int i = mdlData.colCompany.Count;
                mdlData.GenNumberID();
                for (int k = 0; k < mdlData.colCompany.Count; k++)
                {
                    if (mdlData.colCompany[k].ID == Convert.ToInt32(mdlData.GrnNumberID))
                    {
                        mdlData.GrnNumberID = "";
                        mdlData.GenNumberID();
                        k = 0;
                    }
                    else { continue; }
                }
                mdlData.colCompany[i - 1].ID = Convert.ToInt32(mdlData.GrnNumberID);
                mdlData.colCompany[i - 1].ID_INN_KPP = textBox2.Text;
                mdlData.colCompany[i - 1].Name = textBox1.Text;
                mdlData.colCompany[i - 1].Address = textBox3.Text;
                mdlData.colCompany[i - 1].Tel = textBox4.Text;
                //Запись в БД
                mdlData.ready = true;
                mdlData.ConnectDataBase();
                SqlCommand cmd = mdlData.cnn.CreateCommand();
                cmd.CommandText = "INSERT INTO company(ID,ID_INN_KPP,Name,Address,Tel) VALUES ('" + mdlData.colCompany[i - 1].ID + 
                                                                       "','" + mdlData.colCompany[i - 1].ID_INN_KPP +
                                                                        "','" + mdlData.colCompany[i - 1].Name +
                                                                         "','" + mdlData.colCompany[i - 1].Address +
                                                                          "','" + mdlData.colCompany[i - 1].Tel + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Компания добавлена", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Data.EventHandlerCompany();
                Data.EventHandlerCompanySellers();
                //mdlData.StatusAdd = true;
                mdlData.cnn.Close();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Не удалось добавить объект", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void AddCompany_Load(object sender, EventArgs e)
        {

        }
    }
}
