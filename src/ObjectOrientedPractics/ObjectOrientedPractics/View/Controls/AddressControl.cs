using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Controls
{
    public partial class AddressControl : UserControl
    {
        private Address _address;

        public Address Address
        {
            set
            {

                _address = value;

                PostIndexTextBox.Text = _address.Index.ToString();
                CountryTextBox.Text = _address.Country;
                CityTextBox.Text = _address.City;
                StreetTextBox.Text = _address.Street;
                BuildingTextBox.Text = _address.Building;
                ApartmentTextBox.Text = _address.Apartment;
            }
            get { return _address; }
        }
        public AddressControl()
        {
            InitializeComponent();
            _address = new Address();
        }

        private void PostIndexTextBox_TextChanged(object sender, EventArgs e)
        {

            try
            {
                PostIndexTextBox.BackColor = Color.White;
                ValueValidator.AssertOnPositiveValue(Convert.ToInt32(PostIndexTextBox.Text), 100000, 1000000, nameof(Address.Index));

                _address.Index = Convert.ToInt32(PostIndexTextBox.Text);
            }
            catch
            {
                PostIndexTextBox.BackColor = Color.LightPink;

            }

        }

        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CountryTextBox.BackColor = Color.White;
                ValueValidator.AssertStringOnLength(CountryTextBox.Text, 50, nameof(Address.Country));
                _address.Country = CountryTextBox.Text;
            }

            catch
            {
                CountryTextBox.BackColor = Color.LightPink;
            }

        }

        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                StreetTextBox.BackColor = Color.White;
                ValueValidator.AssertStringOnLength(StreetTextBox.Text, 100, nameof(Address.Street));
                _address.Street = StreetTextBox.Text;
            }

            catch
            {
                StreetTextBox.BackColor = Color.LightPink;
            }
        }

        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                BuildingTextBox.BackColor = Color.White;
                ValueValidator.AssertStringOnLength(BuildingTextBox.Text, 10, nameof(Address.Building));
                _address.Building = BuildingTextBox.Text;
            }

            catch
            {
                BuildingTextBox.BackColor = Color.LightPink;
            }
        }

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CityTextBox.BackColor = Color.White;
                ValueValidator.AssertStringOnLength(CityTextBox.Text, 50, nameof(Address.City));
                _address.City = CityTextBox.Text;
            }

            catch
            {
                CityTextBox.BackColor = Color.LightPink;
            }
        }

        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ApartmentTextBox.BackColor = Color.White;
                ValueValidator.AssertStringOnLength(ApartmentTextBox.Text, 100, nameof(Address.Apartment));
                _address.Apartment = ApartmentTextBox.Text;
            }

            catch
            {
                ApartmentTextBox.BackColor = Color.LightPink;
            }
        }

        public void Clear()
        {
            _address = new Address();

            PostIndexTextBox.Text = "";
            CountryTextBox.Text = "";
            CityTextBox.Text = "";
            StreetTextBox.Text = "";
            BuildingTextBox.Text = "";
            ApartmentTextBox.Text = "";

            PostIndexTextBox.BackColor = Color.White;
            CountryTextBox.BackColor = Color.White;
            CityTextBox.BackColor = Color.White;
            StreetTextBox.BackColor = Color.White;
            BuildingTextBox.BackColor = Color.White;
            ApartmentTextBox.BackColor = Color.White;
        }


    }
}
