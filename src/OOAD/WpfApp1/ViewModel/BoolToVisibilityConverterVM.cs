using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace View.ViewModel
{
    /// <summary>
    /// Конвертер, преобразующий значение типа bool в Visibility.
    /// </summary>
    public class BoolToVisibilityConverterVM : IValueConverter
    {
        /// <summary>
        /// Преобразует bool в Visibility.
        /// </summary>
        /// <param name="value">Значение типа bool.</param>
        /// <param name="targetType">Тип, в который нужно преобразовать.</param>
        /// <param name="parameter">Дополнительный параметр (не используется).</param>
        /// <param name="culture">Культура (не используется).</param>
        /// <returns>Visibility.Visible, если value = true, иначе Visibility.Collapsed.</returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool isVisible)
            {
                return isVisible ? Visibility.Visible : Visibility.Collapsed;
            }
            return Visibility.Collapsed;
        } 
        

        /// <summary>
        /// Преобразует Visibility обратно в bool (не используется в данном случае).
        /// </summary>
        /// <param name="value">Значение типа Visibility.</param>
        /// <param name="targetType">Тип, в который нужно преобразовать.</param>
        /// <param name="parameter">Дополнительный параметр (не используется).</param>
        /// <param name="culture">Культура (не используется).</param>
        /// <returns>Не реализовано, так как обратное преобразование не требуется.</returns>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}