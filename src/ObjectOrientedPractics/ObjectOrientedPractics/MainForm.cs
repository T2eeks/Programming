using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        private Store _store;
        public MainForm()
        {
            InitializeComponent();
            _store = new Store();
            itemsTab1.Items = _store.Items;
            customersTab1.Customers = _store.Customers;
        }

        private void itemsTab1_Load(object sender, EventArgs e)
        {

        }
    }
}
