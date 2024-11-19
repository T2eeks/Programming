using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Перечисление статусов заказа
    /// </summary>
    public enum OrderTime
    {
        FromNineToElevenAM = 1,
        FromElevenToOnePM = 2,
        FromOneToThreePM = 3,
        FromThreeToFivePM = 4,
        FromFiveToSevenPM =5,
        FromSevenToNinePM = 6
    }
}
