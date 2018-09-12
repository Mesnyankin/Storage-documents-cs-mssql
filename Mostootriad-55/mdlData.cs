using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using asprise_imaging_api;

namespace Mostootriad_55
{
    class mdlData
    {
        public static string LoadDisable = "не загружен...";
        public static string LoadKc = "Открыть КС-2/КС-3";
        public static string LoadDog = "Открыть документ";
        public static string LoadInvoice = "Открыть Счет-фактуру";
        public static string LoadСonsignment = "Открыть накладные";
        public static string LoadAct = "Открыть акты";
        public static bool statusEdit = false;
        public static string path = "";
        public static string ObjectDir = "";
        public static SqlConnection cnn;
        public static bool RadioBtn = false;
        public static bool ready;
        public static bool StatusAdd;
        public static bool WindowChildSellers = false;
        public static bool WindowChildCustomer = false;
        public static bool IntSecurity;
        public static int ScanDocRadioBtn = 0;
        public static int CountScanDocument = 0;
        public static string Server;
        public static string DBName;
        public static string UserID="";
        public static string Password="";
        public static string GrnNumberID = "";
        public static IList<clsCustomer> colCustomer = new List<clsCustomer>();
        public static IList<clsSellers> colSellers = new List<clsSellers>();
        public static IList<clsObject> colObject = new List<clsObject>();
        public static IList<clsCompany> colCompany = new List<clsCompany>();
        //Параметры сервера
        public static string ConnectionString(string Server, string DBname, string UserID, string Password)
        {        
            if (mdlData.RadioBtn == true)
            {
                IntSecurity = false;
            }
            if (mdlData.RadioBtn != true)
            {
                IntSecurity = true;
            }
            SqlConnectionStringBuilder connectionStringBuilder = new SqlConnectionStringBuilder();
            connectionStringBuilder.DataSource = Server;
            connectionStringBuilder.InitialCatalog = DBname;
            connectionStringBuilder.IntegratedSecurity = IntSecurity;
            connectionStringBuilder.UserID = UserID;
            connectionStringBuilder.Password = Password;
            return connectionStringBuilder.ConnectionString;
        }
        //Генератор билетов
        public static string GenNumberID()
        {
            string abc = "1234567890";
            int kol = 4;
            Random rnd = new Random();
            int lng = abc.Length;
            for (int i = 0; i < kol; i++)
            { GrnNumberID += abc[rnd.Next(lng)]; }
            return GrnNumberID;
        }
        public static void selectFolderFile(string FolderFile)
        {
            Process PrFolder = new Process();
            ProcessStartInfo psi = new ProcessStartInfo();
            string file = @FolderFile;
            psi.CreateNoWindow = true;
            psi.WindowStyle = ProcessWindowStyle.Normal;
            psi.FileName = "explorer";
            psi.Arguments = @"/n, /select, " + file;
            PrFolder.StartInfo = psi;
            PrFolder.Start();
        }
        public static void ConnectDataBase()
        {
            FileConfig();
            string connetionString = null;
            connetionString = ConnectionString(Server, DBName, UserID, Password);
            cnn = new SqlConnection(connetionString);
            cnn.Open();
        }
        public static void FileConfig()
        {
            try
            {
                FileStream file = new FileStream("config.txt", FileMode.Open, FileAccess.Read);
                StreamReader myreader = new StreamReader(file);
                mdlData.Server = myreader.ReadLine();
                mdlData.DBName = myreader.ReadLine();
                string RadioBtn = myreader.ReadLine();
                mdlData.RadioBtn = Convert.ToBoolean(RadioBtn);

                if (mdlData.RadioBtn == true)
                {
                    mdlData.UserID = myreader.ReadLine();
                    mdlData.Password = myreader.ReadLine();
                }
                mdlData.path = myreader.ReadLine();
                myreader.Close(); file.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Incorrect config file or file does not exist!", "Saved Config File", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static string ScanImage()
        {
            string pathfile = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments);
            Directory.CreateDirectory(pathfile + @"\Mostootriad\scan");
            string ScanPath = pathfile + @"\Mostootriad\scan\${TMS}${EXT}";
            try
            {
                Result result = new AspriseImaging().Scan(new Request().AddOutputItem(
                                                          new RequestOutputItem(AspriseImaging.OUTPUT_SAVE, AspriseImaging.FORMAT_PDF)
                                                    .SetPdfTextLine("Scanned on ${DATETIME} by user X") // Optional text line at the bottom of the 1st page
                                                    .AddExifTag("DocumentName", "Scan to PDF by Asprise") // Optional PDF doc properties (metadata)
                                                    .SetSavePath(ScanPath))
                                                    .SetPromptScanMore(true)
                                                    , "select", true, true);
                string pdfFile = result == null ? null : result.GetPdfFile();
                ScanPath = pdfFile;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось запустить сканирование: " + ex.Message + ". Проверьте наличие драйвера для сканера. Подключено ли сканирующее устройство к компьютеру.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ScanPath;
        }
        public static void DeleteFileScan()
        {
            var result = MessageBox.Show("Все документы сохранены на сервере. Удалить их копии на локальном диске?", "Внимание",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string pathfile = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments);
                string ScanPath = pathfile + @"\Mostootriad\scan\";
                DirectoryInfo dirInfo = new DirectoryInfo(ScanPath);
                try
                {
                    foreach (FileInfo file in dirInfo.GetFiles())
                    {
                        file.Delete();
                    }
                    MessageBox.Show("Временные файлы удалены", "Очистка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Не удалось удалить временный(е) файл(ы). ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                return;
        }
        public static void CounterClear()
        {
            //..
        }       
    }
    class ConsoleMessageBox
    {
        public static string SaveDBTrue =  ": Изменения успешно загружены в базу данных " + mdlData.DBName;
        public static string SaveDBFalse = ": Сохранение в базу данных " + mdlData.DBName + " прошло с ошибками!";
        public static string AddCollTrue = ": Данные успешно добавленны в коллекцию";
        public static string LoadDBTrue = ": База данных " + mdlData.DBName + " загружена!";
        public static string LoadDBFalse = ": База данных " + mdlData.DBName + " не загружена!";
        public static string LoadCollTrue = ": Все коллекции для базы данных " + mdlData.DBName + " загружены!";
        public static string SessionClose = ": Сессия с базой данных " + mdlData.DBName + " закрыта";   
    }
}
