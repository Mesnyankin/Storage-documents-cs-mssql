using System.Windows.Forms;

namespace Mostootriad_55
{
    public partial class frmKalendar : Form
    {
        AddCustomer _owner; 
        public frmKalendar(AddCustomer form)
        {
            InitializeComponent();
            _owner = form; 
        }
        public void mcKalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            _owner.SetText(monthCalendar1.SelectionEnd.ToShortDateString());
        }
    }
}
