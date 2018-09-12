using System.Windows.Forms;

namespace Mostootriad_55
{
    public partial class frmKalendarCustomer : Form
    {
        DocCustomerPdf _owner;
        public frmKalendarCustomer(DocCustomerPdf form)
        {
            InitializeComponent();
            _owner = form; 
        }
        public void mcKalendarCustomer_DateChanged(object sender, DateRangeEventArgs e)
        {
            _owner.SetText(monthCalendar1.SelectionEnd.ToShortDateString());
        }
    }
}
