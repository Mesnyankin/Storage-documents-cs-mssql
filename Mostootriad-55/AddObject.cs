using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Mostootriad_55
{
    public partial class AddObject : Form
    {
        public AddObject()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddObject_Load(object sender, EventArgs e)
        {

        }
        private void CreateDirectory(string colObject)
        {
            string subdir = colObject;
            DirectoryInfo dirInfo = new DirectoryInfo(mdlData.path);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
            dirInfo.CreateSubdirectory(subdir);

            string pathObject = mdlData.path + @"\" + subdir;
            DirectoryInfo dirObjectInfo = new DirectoryInfo(pathObject);
            string subdir_Custimer = "customer";
            string subdir_Sellers = "sellers";
            if (!dirObjectInfo.Exists)
            {
                dirObjectInfo.Create();
            }
            dirObjectInfo.CreateSubdirectory(subdir_Custimer);
            dirObjectInfo.CreateSubdirectory(subdir_Sellers);
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
                //Добавление в коллекцию
                mdlData.GrnNumberID = "";
                clsObject Obj = new clsObject();
                mdlData.colObject.Add(Obj);
                int i = mdlData.colObject.Count;
                mdlData.GenNumberID();
                    for (int k = 0; k < mdlData.colObject.Count; k++)
                    {
                        if (mdlData.colObject[k].ID == Convert.ToInt32(mdlData.GrnNumberID))
                        {
                            mdlData.GrnNumberID = "";
                            mdlData.GenNumberID();
                            k = 0;
                        }
                        else { continue; }
                    }
                mdlData.colObject[i - 1].ID = Convert.ToInt32(mdlData.GrnNumberID);
                mdlData.colObject[i - 1].Name = textBox1.Text;
                //Запись в БД
                mdlData.ready = true;
                mdlData.ConnectDataBase();
                SqlCommand cmd = mdlData.cnn.CreateCommand();
                cmd.CommandText = "INSERT INTO object(ID,Name) VALUES ('" + mdlData.colObject[i-1].ID + "','" + mdlData.colObject[i-1].Name + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Объект добавлен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mdlData.ObjectDir = mdlData.colObject[i - 1].ID.ToString();
                CreateDirectory(mdlData.ObjectDir);
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
    }
}
