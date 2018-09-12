using System;
using System.Data;
using System.Windows.Forms;

namespace Mostootriad_55
{
    class clsObject
    {
        public int ID;
        public string Name;
        public string date;
        //Процедура инициализации элементов
        public void Initialize(DataTable Tab, int i)
        {
            this.ID = Convert.ToInt32(Tab.Rows[i]["ID"].ToString());
            this.Name = Tab.Rows[i]["Name"].ToString();
        }
        public void PrintdataGridView(DataGridView dataGridView, int i)
        {
            dataGridView.Rows.Add(mdlData.colObject[i].ID,
                                  mdlData.colObject[i].Name);
        }
    }
}
