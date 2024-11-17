using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class OrdersTab : UserControl
    {

        public List<Customer> Customers { get; set; }
        private List<Order> Orders { get; } = new List<Order>();

        public OrdersTab()
        {
            InitializeComponent();
            InitializeComponent();
            StatusComboBox.Items.AddRange(Enum.GetValues(typeof(OrderStatus)).Cast<object>().ToArray());
        }

    }
}
