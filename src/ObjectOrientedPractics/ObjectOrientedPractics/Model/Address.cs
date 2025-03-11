using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Представляет адрес в системе.
    /// </summary>
    public class Address : ICloneable, IEquatable<Address>
    {
        /// <summary>
        /// Хранит индекс (почтовый код) адреса.
        /// </summary>
        private int _index;

        /// <summary>
        /// Хранит страну, к которой относится адрес.
        /// </summary>
        private string _country;

        /// <summary>
        /// Хранит город, в котором находится адрес.
        /// </summary>
        private string _city;

        /// <summary>
        /// Хранит улицу, на которой расположен адрес.
        /// </summary>
        private string _street;

        /// <summary>
        /// Хранит номер здания по данному адресу.
        /// </summary>
        private string _building;

        /// <summary>
        /// Хранит номер квартиры по данному адресу.
        /// </summary>
        private string _apartment;

        /// <summary>
        /// Событие при обновлении любого поля объекта <see cref="Address"/>.
        /// </summary>
        public event EventHandler<EventArgs> AddressChanged;

        /// <summary>
        /// Возвращает и задает индекс адреса. Значение должно быть положительным и содержать не более 1000000 символов.
        /// </summary>
        public int Index
        {
            set
            {
                
                ValueValidator.AssertOnPositiveValue(value, 100000, 999999, nameof(Index));
                _index = value;
                AddressChanged?.Invoke(this, EventArgs.Empty);
            }
            get { return _index; }
        }

        /// <summary>
        /// Возвращает и задает страну, к которой относится адрес. Должно содержать не более 50 символов.
        /// </summary>
        public string Country
        {
            set
            {
                ValueValidator.AssertStringOnLength(value, 50, nameof(Country));
                _country = value;
                AddressChanged?.Invoke(this, EventArgs.Empty);
            }
            get { return _country; }
        }

        /// <summary>
        /// Возвращает и задает город, в котором находится адрес. Должно содержать не более 50 символов.
        /// </summary>
        public string City
        {
            set
            {
                ValueValidator.AssertStringOnLength(value, 50, nameof(City));
                _city = value;
                AddressChanged?.Invoke(this, EventArgs.Empty);
            }
            get { return _city; }
        }

        /// <summary>
        /// Возвращает и задает улицу, на которой расположен адрес. Должно содержать не более 100 символов.
        /// </summary>
        public string Street
        {
            set
            {
                ValueValidator.AssertStringOnLength(value, 100, nameof(Street));
                _street = value;
                AddressChanged?.Invoke(this, EventArgs.Empty);
            }
            get { return _street; }
        }

        /// <summary>
        /// Возвращает и задает номер здания по данному адресу. Должно содержать не более 10 символов.
        /// </summary>
        public string Building
        {
            set
            {
                ValueValidator.AssertStringOnLength(value, 10, nameof(Building));
                _building = value;
                AddressChanged?.Invoke(this, EventArgs.Empty);
            }
            get { return _building; }
        }

        /// <summary>
        /// Возвращает и задает номер квартиры по данному адресу. Должно содержать не более 10 символов.
        /// </summary>
        public string Apartment
        {
            set
            {
               
                ValueValidator.AssertStringOnLength(value, 10, nameof(Apartment));
                _apartment = value;
                AddressChanged?.Invoke(this, EventArgs.Empty);
            }
            get { return _apartment; }
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Address"/> с указанными значениями.
        /// </summary>
        /// <param name="index">Почтовый индекс адреса.</param>
        /// <param name="country">Страна адреса.</param>
        /// <param name="city">Город адреса.</param>
        /// <param name="street">Улица адреса.</param>
        /// <param name="building">Номер здания по адресу.</param>
        /// <param name="apartment">Номер квартиры по адресу.</param>
        public Address(int index, string country, string city, string street, string building, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Address"/> без параметров.
        /// </summary>
        public Address() { }

        /// <summary>
        /// Создает копию объекта <see cref="Address"/>.
        /// </summary>
        /// <returns>Копия объекта в <see cref="object"/>.</returns>
        public object Clone()
        {
            return new Address(
                this.Index,
                this.Country,
                this.City,
                this.Street,
                this.Building,
                this.Apartment);
        }

        /// <summary>
        /// Проверяет равенство исходного объект с передаваемым.
        /// </summary>
        /// <param name="other">Объект класса <see cref="Address"/>.</param>
        /// <returns>Возвращает булевое значение, равны ли объекты.</returns>
        public bool Equals(Address other)
        {
            if (other == null)
            {
                return false;
            }
            if (object.ReferenceEquals(this, other))
            {
                return true;
            }
            var result = this.Index == other.Index;
            result &= this.Country == other.Country;
            result &= this.City == other.City;
            result &= this.Street == other.Street;
            result &= this.Building == other.Building;
            result &= this.Apartment == other.Apartment;
            return result;
        }

    }
}
