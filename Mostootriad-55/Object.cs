using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Mostootriad_55
{
    public partial class Object : Form
    {
        public Object()
        {
            InitializeComponent();
        }
        public int ID;
        private void listboxUpdate()
        {
            List<string> Object = new List<string>();
            //Добавление отсортированной коллекции объектов в comboBox
            for (int i = 0; i < mdlData.colObject.Count; i++)
            {
                Object.Add(mdlData.colObject[i].Name);
                Object.Sort();
            }
            for (int i = 0; i < Object.Count; i++)
            {
                listBox1.Items.Add(Object[i]);
            }
        }
        private void Object_Load(object sender, EventArgs e)
        {
            listboxUpdate();
            if (mdlData.colObject.Count > 0)
            {
                listBox1.SetSelected(0, true);
            }
            if (mdlData.colObject.Count <= 0) { button1.Enabled = false; button2.Enabled = false; }
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            string obj = listBox1.SelectedItem.ToString();
            for (int i = 1; i <= mdlData.colObject.Count; i++)
            {
                if (mdlData.colObject[i - 1].Name == obj)
                {
                    ID = mdlData.colObject[i - 1].ID;
                }
            }
            EditObject FormEdit = new EditObject();
            FormEdit.Owner = this;
            FormEdit.NameObj = obj;
            FormEdit.ID = ID;
            FormEdit.ShowDialog();         
            listBox1.Items.Clear();
            listboxUpdate();
            listBox1.SetSelected(0, true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string obj = listBox1.SelectedItem.ToString();
            for (int i = 1; i <= mdlData.colObject.Count; i++)
            {
                if (mdlData.colObject[i - 1].Name == obj)
                {
                    mdlData.ConnectDataBase();
                    SqlCommand cmd = mdlData.cnn.CreateCommand();
                    try
                    {
                        cmd.CommandText = "DELETE FROM object WHERE Name = '" + obj + "'";
                        cmd.ExecuteNonQuery();
                        mdlData.colObject.Remove(mdlData.colObject[i-1]);
                        listBox1.Items.Remove(listBox1.SelectedItem);
                        MessageBox.Show("Объект удален!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ошибка Удаления. Прежде чем удалить объект, необхадимо удалить все записи связанные с ним.", "Удаление объекта", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    mdlData.cnn.Close();
                }
            }
            if (mdlData.colObject.Count > 0)
            {
                listBox1.SetSelected(0, true);
            }
            if (mdlData.colObject.Count <= 0) { button1.Enabled = false; button2.Enabled = false; }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            AddObject Form = new AddObject();
            Form.Owner = this;
            Form.ShowDialog();
            listBox1.Items.Clear();
            listboxUpdate();
            if (mdlData.colObject.Count > 0)
            {
                listBox1.SetSelected(0, true);
            }
            if (mdlData.colObject.Count > 0 && button1.Enabled != true && button2.Enabled != true)
            {
                button1.Enabled = true; button2.Enabled = true;
            }
        }
    }
}
