using System;
using System.Data;

namespace Mostootriad_55
{
    class clsCustomer
    {
        public int ID;
        public int Client;
        public int Performer;
        public string ContractNumber;
        public string dateDoc;
        public string pdf_kc;
        public string pdf_dog;
        public string pdf_invoice;
        public string note;
        public int ObjectN;
        public static DateTime times = DateTime.Now;
        //Процедура инициализации элементов
        public void Initialize(DataTable Tab, int i)
        {
            this.ID = Convert.ToInt32(Tab.Rows[i]["ID"].ToString());
            this.ObjectN = Convert.ToInt32(Tab.Rows[i]["ObjectN"].ToString());
            this.Client = Convert.ToInt32(Tab.Rows[i]["Client"].ToString());
            this.Performer = Convert.ToInt32(Tab.Rows[i]["Performer"].ToString());
            this.ContractNumber = Tab.Rows[i]["ContractNumber"].ToString();
            this.dateDoc = Tab.Rows[i]["dateDoc"].ToString();
            this.pdf_kc = Tab.Rows[i]["pdf_kc"].ToString();
            this.pdf_invoice = Tab.Rows[i]["pdf_invoice"].ToString();
            this.pdf_dog = Tab.Rows[i]["pdf_dog"].ToString();
            this.note = Tab.Rows[i]["note"].ToString();
        }
    }
}
