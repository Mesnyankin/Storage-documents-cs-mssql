using System.Windows.Forms;

namespace Mostootriad_55
{
    public partial class frmKalendarEdit : Form
    {
        EditCustomer _owner;
        public frmKalendarEdit(EditCustomer form)
        {
            InitializeComponent();
            _owner = form; 
        }
        public void mcKalendarEdit_DateChanged(object sender, DateRangeEventArgs e)
        {
            _owner.SetText(monthCalendar1.SelectionEnd.ToShortDateString());
        }
    }
}
