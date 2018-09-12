using System.Windows.Forms;

namespace Mostootriad_55
{
    public partial class frmKalendarSellers : Form
    {
        DocPdf _owner;
        public frmKalendarSellers(DocPdf form)
        {
            InitializeComponent();
            _owner = form; 
        }
        public void mcKalendarSellers_DateChanged(object sender, DateRangeEventArgs e)
        {
            _owner.SetText(monthCalendar1.SelectionEnd.ToShortDateString());
        }
    }
}
