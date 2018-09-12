using System;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Mostootriad_55
{
    public partial class frmSettingFolder : Form
    {
        public frmSettingFolder()
        {
            InitializeComponent();
        }
        public string server, path;
        public string bd, user, pass;

        private void button1_Click(object sender, EventArgs e)
        {
            string path = textBox1.Text;
            mdlData.ConnectDataBase();
            SqlCommand cmd = mdlData.cnn.CreateCommand();
            try
            {
                if (mdlData.path != path)
                {
                    cmd.CommandText = "UPDATE customer SET pdf_kc = REPLACE(pdf_kc,'" + mdlData.path + "', '" + path + "'), pdf_dog = REPLACE(pdf_dog,'" 
                                                                            + mdlData.path + "', '" + path + "'), pdf_invoice = REPLACE(pdf_invoice,'" 
                                                                            + mdlData.path + "', '" + path + "') WHERE pdf_kc LIKE '" 
                                                                            + mdlData.path + "%' or pdf_dog LIKE '" 
                                                                            + mdlData.path + "%' or pdf_invoice LIKE '" 
                                                                            + mdlData.path + "%'";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "UPDATE sellers SET pdf_kc = REPLACE(pdf_kc,'" + mdlData.path + "', '" + path + "'), pdf_dog = REPLACE(pdf_dog,'"
                                                                           + mdlData.path + "', '" + path + "'), pdf_invoice = REPLACE(pdf_invoice,'" 
                                                                           + mdlData.path + "', '" + path + "'), pdf_consignment = REPLACE(pdf_consignment,'" 
                                                                           + mdlData.path + "', '" + path + "'), pdf_act = REPLACE(pdf_act,'" 
                                                                           + mdlData.path + "', '" + path + "') WHERE pdf_kc LIKE '" 
                                                                           + mdlData.path + "%' or pdf_dog LIKE '" 
                                                                           + mdlData.path + "%' or pdf_invoice LIKE '" 
                                                                           + mdlData.path + "%' or pdf_consignment LIKE '" 
                                                                           + mdlData.path + "%' or pdf_act LIKE '" 
                                                                           + mdlData.path + "%'";
                    cmd.ExecuteNonQuery();
                    btnPathFolder_Click(sender, e);
                }
                else { MessageBox.Show("Вы не внесли изменений", "Saved SQL path", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            //В случае возникновения хотя бы одной ошибки, фиксируем ее
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка записи:" + ex.Message, "Saved SQL path", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void frmSettingFolder_Load(object sender, EventArgs e)
        {
            try
            {
                // считываем данные с файла
                FileStream file = new FileStream("config.txt", FileMode.Open, FileAccess.Read);
                StreamReader myreader = new StreamReader(file);
                server = myreader.ReadLine();
                bd = myreader.ReadLine();
                string RadioBtn = myreader.ReadLine();
                mdlData.RadioBtn = Convert.ToBoolean(RadioBtn);
                if (mdlData.RadioBtn == true)
                {
                    user = myreader.ReadLine();
                    pass = myreader.ReadLine();
                }
                path = myreader.ReadLine();
                myreader.Close(); file.Close();
                textBox1.Text = path;
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка считывания данных", "Saved Config File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnPathFolder_Click(object sender, EventArgs e)
        {
            // Удаляем файл
            FileInfo fileDel = new FileInfo(@"config.txt");
            fileDel.Delete();
            // Создаем файл и записываем
            FileStream fileNew = new FileStream("config.txt", FileMode.Create, FileAccess.ReadWrite);
            StreamWriter toWriteText = new StreamWriter(fileNew);
            try
            {
                toWriteText.WriteLine(server);
                toWriteText.WriteLine(bd);
                if (mdlData.RadioBtn == true)
                {
                    toWriteText.WriteLine("true");
                    toWriteText.WriteLine(user);
                    toWriteText.WriteLine(pass);
                }
                if (mdlData.RadioBtn == false)
                {
                    toWriteText.WriteLine("false");
                }
                if (path != textBox1.Text)
                {
                    toWriteText.WriteLine(textBox1.Text);
                }
                toWriteText.Close();
                fileNew.Close();
                MessageBox.Show("Изменения внесены", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка сохранения" + toWriteText, "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
