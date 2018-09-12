using System.Windows.Forms;

namespace Mostootriad_55
{
    public partial class frmKalendarEditSellers : Form
    {
        EditSellers _owner;
        public frmKalendarEditSellers(EditSellers form)
        {
            InitializeComponent();
            _owner = form; 
        }
        public void mcKalendarEditSellers_DateChanged(object sender, DateRangeEventArgs e)
        {
            _owner.SetText(monthCalendar1.SelectionEnd.ToShortDateString());
        }
    }
}
