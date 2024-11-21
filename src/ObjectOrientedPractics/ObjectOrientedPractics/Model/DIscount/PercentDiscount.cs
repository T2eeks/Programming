using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.DIscount
{
    internal class PercentDiscount
    {
        /// <summary>
        /// Категория товаров, на которую распространяется скидка.
        /// </summary>
        public string Category { get; private set; }

        /// <summary>
        /// Текущий процент скидки.
        /// </summary>
        public int Percentage { get; private set; } = 1;

        /// <summary>
        /// Общая сумма покупок данной категории товаров.
        /// </summary>
        public double TotalSpent { get; private set; }

        /// <summary>
        /// Возвращает название скидки в виде строки.
        /// </summary>
        public string Info
        {
            get { return $"Процентная «{Category}» - {Percentage}%"; }
        }

        /// <summary>
        /// Рассчитывает размер скидки для заданного списка товаров.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Размер скидки.</returns>
        public double Calculate(List<Item> items)
        {
            if (items == null || !items.Any())
            {
                return 0.0;
            }

            var categoryItems = items.Where(item => item.Category.ToString() == Category).ToList();
            if (!categoryItems.Any())
            {
                return 0.0;
            } 

            double categoryTotal = categoryItems.Sum(item => item.Cost);
            return categoryTotal * (Percentage / 100.0);
        }

        /// <summary>
        /// Применяет скидку к списку товаров и возвращает размер скидки.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Размер примененной скидки.</returns>
        public double Apply(List<Item> items)
        {
            double discount = Calculate(items);
            return discount;
        }

        /// <summary>
        /// Обновляет данные скидки на основе новых покупок.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        public void Update(List<Item> items)
        {
            if (items == null || !items.Any())
            {
                return;
            }

            var categoryItems = items.Where(item => item.Category.ToString() == Category).ToList();
            if (!categoryItems.Any())
            {
                return;
            }

            TotalSpent += categoryItems.Sum(item => item.Cost);
            Percentage = Math.Min(1 + (int)(TotalSpent / 1000), 10); // Максимум 10%.
        }

        /// <summary>
        /// Создает новый экземпляр класса <see cref="PercentDiscount"/>.
        /// </summary>
        /// <param name="category">Категория товаров.</param>
        public PercentDiscount(string category)
        {
            if (string.IsNullOrWhiteSpace(category))
                throw new ArgumentException("Категория не может быть пустой.");

            Category = category;
        }
    }
}
