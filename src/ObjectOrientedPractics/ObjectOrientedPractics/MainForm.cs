using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Tabs;

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

            cartsTab1.Items = _store.Items;
            cartsTab1.Customers = _store.Customers;


        }


        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabControl.SelectedIndex == 2)
            {
                if (cartsTab1.Items != null && cartsTab1.Customers != null)
                {
                    cartsTab1.RefreshData();
                }
            }
        }

        private void cartsTab1_Load(object sender, EventArgs e)
        {

        }
    }
}
