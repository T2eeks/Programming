using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics
{
    internal class Customer
    {
        private static int _nextid = 1;
        private readonly int _id;
        private string _fullname;
        private string _address;

        public int Id
        {
            get {  return _id; }
        }
        public string FullName
        { 
           set
           {
                ValueValidator.AssertStringOnLength(value, 200, nameof(FullName));
               _fullname = value;
           }
            get { return _fullname; }
        }
        public string Address
        {
            set
            {
                ValueValidator.AssertStringOnLength(value, 500, nameof(Address));
                _address = value;
            }
            get { return _address; }
        }   
        public Customer()
        {
            _id = _nextid++;
        }
        public Customer(string fullname,string address)
        {
            FullName = fullname;
            Address = address;
        }
    }
}
