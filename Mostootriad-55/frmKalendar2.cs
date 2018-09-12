using System.Windows.Forms;

namespace Mostootriad_55
{
    public partial class frmKalendar2 : Form
    {
        AddSellers _owner;
        public frmKalendar2(AddSellers form)
        {
            InitializeComponent();
            _owner = form; 
        }
        public void mcKalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            _owner.SetText(monthCalendar1.SelectionEnd.ToShortDateString());
        }
    }
}
