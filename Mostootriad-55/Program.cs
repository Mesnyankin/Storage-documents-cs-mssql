using System;
using System.Windows.Forms;

namespace Mostootriad_55
{
    public static class Data
    {
        public delegate void MyEvent(int i, string ObjectN, string Client, string Performer);
        public delegate void MyEventComboBoxDocument(int i);
        public delegate void MyEventCompany();
        public delegate void MyEventScan();
        public static MyEvent EventHandler;
        public static MyEventScan EventHandlerScan;
        public static MyEvent EventHandlerSellers;
        public static MyEventCompany EventHandlerCompany;
        public static MyEventCompany EventHandlerCompanySellers;
        public static MyEventComboBoxDocument EventHandlerComboBoxDocument;
        public static MyEventComboBoxDocument EventHandlerComboBoxDocumentSellers;
    }
    static class addI
    {
        public static int Value { get; set; }
        public static string Value_ObjectN { get; set; }
        public static string Value_Client { get; set; }
        public static string Value_Performer { get; set; }
        public static int Value_ComboBoxDocument { get; set; }
    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// 
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new asprise_imaging_api.SampleScanForm()); // ☜ Run SampleScanForm

            Application.Run(new Form1());
        }
    }
}
