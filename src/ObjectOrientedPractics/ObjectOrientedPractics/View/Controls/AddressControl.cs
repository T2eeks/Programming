using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Controls
{
    public partial class AddressControl : UserControl
    {
        private Address _address = new Address();

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Address Address
        {
            set
            {
                _address = value ?? new Address();

                PostIndexTextBox.Text = _address.Index == 0 ? string.Empty : _address.Index.ToString();
                CountryTextBox.Text = _address.Country;
                CityTextBox.Text = _address.City;
                StreetTextBox.Text = _address.Street;
                BuildingTextBox.Text = _address.Building;
                ApartmentTextBox.Text = _address.Apartment;
            }
            get
            {
                return _address;
            }
        }

        public AddressControl()
        {
            InitializeComponent();
            _address = new Address(); 
            PostIndexTextBox.Text = string.Empty;
            CountryTextBox.Text = string.Empty;
            CityTextBox.Text = string.Empty;
            StreetTextBox.Text = string.Empty;
            BuildingTextBox.Text = string.Empty;
            ApartmentTextBox.Text = string.Empty;
        }

        private void PostIndexTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                PostIndexTextBox.BackColor = Color.White;
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
                _address.Country = CountryTextBox.Text;
            }
            catch
            {
                CountryTextBox.BackColor = Color.LightPink;
            }
        }

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CityTextBox.BackColor = Color.White;
                _address.City = CityTextBox.Text;
            }
            catch
            {
                CityTextBox.BackColor = Color.LightPink;
            }
        }

        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                StreetTextBox.BackColor = Color.White;
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
                _address.Building = BuildingTextBox.Text;
            }
            catch
            {
                BuildingTextBox.BackColor = Color.LightPink;
            }
        }

        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ApartmentTextBox.BackColor = Color.White;
                _address.Apartment = ApartmentTextBox.Text;
            }
            catch
            {
                ApartmentTextBox.BackColor = Color.LightPink;
            }
        }

        public void Clear()
        {
            Address = new Address();
            PostIndexTextBox.Text = string.Empty;
            CountryTextBox.Text = string.Empty;
            CityTextBox.Text = string.Empty;
            StreetTextBox.Text = string.Empty;
            BuildingTextBox.Text = string.Empty;
            ApartmentTextBox.Text = string.Empty;

            PostIndexTextBox.BackColor = Color.White;
            CountryTextBox.BackColor = Color.White;
            CityTextBox.BackColor = Color.White;
            StreetTextBox.BackColor = Color.White;
            BuildingTextBox.BackColor = Color.White;
            ApartmentTextBox.BackColor = Color.White;
        }
    }
}
