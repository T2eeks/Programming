using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.DIscount
{
    internal class PointsDiscount
    {
        /// <summary>
        /// Количество накопленных баллов.
        /// </summary>
        private int _points;

        /// <summary>
        /// Возвращает текущее количество накопленных баллов.
        /// </summary>
        public int Points
        {
            get { return _points; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Количество баллов не может быть отрицательным.");
                }
                _points = value;
            }
        }

        /// <summary>
        /// Возвращает название скидки с указанием количества баллов.
        /// </summary>
        public string Info
        {
            get { return $"Накопительная – {Points} баллов"; }
        }

        /// <summary>
        /// Рассчитывает размер скидки на основе текущего количества баллов и списка товаров.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Размер скидки.</returns>
        public double Calculate(List<Item> items)
        {
            if (items == null || !items.Any())
            {
                return 0.0;
            }

            double totalCost = items.Sum(item => item.Cost);
            double maxDiscount = totalCost * 0.3;

            if (Points >= maxDiscount)
            {
                return maxDiscount;
            }

            return Points; 
        }

        /// <summary>
        /// Применяет скидку на основе накопленных баллов к списку товаров.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Размер примененной скидки.</returns>
        public double Apply(List<Item> items)
        {
            if (items == null || !items.Any())
            {
                return 0.0;
            }

            double discount = Calculate(items);
            Points -= (int)discount; 

            return discount;
        }

        /// <summary>
        /// Обновляет количество накопленных баллов на основе стоимости списка товаров.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        public void Update(List<Item> items)
        {
            if (items == null || !items.Any())
            {
                return;
            }

            double totalCost = items.Sum(item => item.Cost);

           
            int earnedPoints = (int)Math.Ceiling(totalCost * 0.1);
            Points += earnedPoints;
        }

        /// <summary>
        /// Создает новый экземпляр класса <see cref="PointsDiscount"/>.
        /// </summary>
        /// <param name="initialPoints">Начальное количество баллов.</param>
        public PointsDiscount(int initialPoints = 0)
        {
            Points = initialPoints;
        }
    }
}
