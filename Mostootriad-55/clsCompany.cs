using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace Mostootriad_55
{
    class clsCompany
    {
        public int ID;
        public string ID_INN_KPP;
        public string Name;
        public string Address;
        public string Tel;
        //Процедура инициализации элементов
        public void Initialize(DataTable Tab, int i)
        {
            this.ID = Convert.ToInt32(Tab.Rows[i]["ID"].ToString());
            this.ID_INN_KPP = Tab.Rows[i]["ID_INN_KPP"].ToString();
            this.Name = Tab.Rows[i]["Name"].ToString();
            this.Address = Tab.Rows[i]["Address"].ToString();
            this.Tel = Tab.Rows[i]["Tel"].ToString();
        }
        public void PrintdataGridView(DataGridView dataGridView, int i)
        {
            dataGridView.Rows.Add(mdlData.colCompany[i].ID,
                                  mdlData.colCompany[i].ID_INN_KPP,
                                  mdlData.colCompany[i].Name,
                                  mdlData.colCompany[i].Address,
                                  mdlData.colCompany[i].Tel);
        }
    }
}