using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics
{
    internal class Item
    {
        private static int _nextId = 1;
        private readonly int _id;
        private string _name;
        private string _info;
        private double _cost;

        public int Id
        {
            get { return _id; }
        }
        public string Name
        {
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, nameof(Name));
                _name = value;
            }
            get { return _name; }
        }

        public string Info
        {
            set
            {
                ValueValidator.AssertStringOnLength(value, 1000, nameof(Info));
                _info = value;
            }
            get { return _info; }
        }
        public double Cost
        {
            set
            {
                ValueValidator.AssertOnPositiveValue(value, 100000, nameof(Cost));
                _cost = value;
            }
            get { return _cost; }
        }

        public Item()
        {
            _id = _nextId++;
        }

        public Item(string name, string info, double cost)
        {
            
            Name = name;
            Info = info;
            Cost = cost;
        }
  
    }
}
