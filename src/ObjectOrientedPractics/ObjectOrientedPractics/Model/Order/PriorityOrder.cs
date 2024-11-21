using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Model.Order;


namespace ObjectOrientedPractics.Model.Order
{
    public class PriorityOrder : Order
    {

        /// <summary>
        /// Возвращает и задает дату доставки.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Возвращает и задает время доставки.
        /// </summary>
        public OrderTime Time { get; set; }

        /// <summary>
        /// Создает экзепляр класса <see cref="PriorityOrder"/>.
        /// </summary>
        /// <param name="address">Адрес доставки.</param>
        /// <param name="items">Список товаров заказа.</param>
        public PriorityOrder(
          Address address,
          List<Item> items,
          DateTime date,
          double discoutAmount) : base(address, items,discoutAmount)
        {
            Date = date;
        }
    }
}
