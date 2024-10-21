using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class Store
    {
        private List<Item> _items;
        private List<Customer> _customers;

        public List<Item> Items
        {
           
            set { _items = value; }
            get { return _items; }

        }

        public List<Customer> Customers
        {

            set { _customers = value; }
            get { return _customers; }

        }

        public Store() 
        { 
            _items = new List<Item>();
            _customers = new List<Customer>();
        }

    }
}
