using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Mostootriad_55
{
    public partial class EditObject : Form
    {
        public int ID;
        public string NameObj;
        public EditObject()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void AddObject_Load(object sender, EventArgs e)
        {
            textBox1.Text = NameObj;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Пожалуйста заполните все поля.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            for (int j = 0; j < mdlData.colObject.Count; j++)
            {
                if (textBox1.Text == mdlData.colObject[j].Name)
                {
                    MessageBox.Show("Такой объект уже существует! Пожалуйста введите другое имя.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            try
            {
                for (int i = 0; i < mdlData.colObject.Count; i++)
                {
                    if (mdlData.colObject[i].ID == ID)
                    {
                        mdlData.colObject[i].Name = textBox1.Text;
                    }
                }
                //Запись в БД
                mdlData.ready = true;
                mdlData.ConnectDataBase();
                SqlCommand cmd = mdlData.cnn.CreateCommand();
                cmd.CommandText = "UPDATE object SET Name = '" + textBox1.Text + "' where ID = '" + ID + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Объект изменен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //mdlData.StatusAdd = true;
                mdlData.cnn.Close();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Не удалось изменить объект", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}
