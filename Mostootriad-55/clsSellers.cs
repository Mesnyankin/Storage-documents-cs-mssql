using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace Mostootriad_55
{
    class clsSellers
    {
        public int ID;
        public int Client; 
        public int Performer;
        public string TypeContract;
        public string ContractNumber;
        public string dateDoc;
        public string pdf_kc;
        public string pdf_dog;
        public string pdf_invoice;
        public string pdf_consignment;
        public string pdf_act;
        public string note;
        public int ObjectN;
        public void Initialize(DataTable Tab, int i)
        {
            this.ID = Convert.ToInt32(Tab.Rows[i]["ID"].ToString());
            this.ObjectN = Convert.ToInt32(Tab.Rows[i]["ObjectN"].ToString());
            this.Client = Convert.ToInt32(Tab.Rows[i]["Client"].ToString());
            this.Performer = Convert.ToInt32(Tab.Rows[i]["Performer"].ToString());
            this.TypeContract = Tab.Rows[i]["TypeContract"].ToString();
            this.ContractNumber = Tab.Rows[i]["ContractNumber"].ToString();
            this.dateDoc = Tab.Rows[i]["dateDoc"].ToString();
            this.pdf_kc = Tab.Rows[i]["pdf_kc"].ToString();
            this.pdf_invoice = Tab.Rows[i]["pdf_invoice"].ToString();
            this.pdf_dog = Tab.Rows[i]["pdf_dog"].ToString();
            this.pdf_consignment = Tab.Rows[i]["pdf_consignment"].ToString();
            this.pdf_act = Tab.Rows[i]["pdf_act"].ToString();
            this.note = Tab.Rows[i]["note"].ToString();
        }
        public void PrintdataGridView(DataGridView dataGridView, int i)
        {
            dataGridView.Rows.Add(mdlData.colSellers[i].ID,
                                  mdlData.colSellers[i].ObjectN,
                                  mdlData.colSellers[i].Client,
                                  mdlData.colSellers[i].Performer,
                                  mdlData.colSellers[i].TypeContract,
                                  mdlData.colSellers[i].ContractNumber,
                                  Convert.ToDateTime(mdlData.colSellers[i].dateDoc).ToString("MM'/'dd'/'yy"),
                                  mdlData.colSellers[i].pdf_kc,
                                  mdlData.colSellers[i].pdf_invoice,
                                  mdlData.colSellers[i].pdf_dog,
                                  mdlData.colSellers[i].pdf_consignment,
                                  mdlData.colSellers[i].pdf_act,
                                  mdlData.colSellers[i].note);
        }
    }
}