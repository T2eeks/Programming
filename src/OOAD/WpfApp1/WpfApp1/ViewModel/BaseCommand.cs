using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp1.ViewModel
{
    /// <summary>
    /// Реализация команды с делегированием действия.
    /// </summary>
    internal class BaseCommand : ICommand
    {

        private readonly Action<object> _execute;
        private readonly Func<object, bool> _canExecute;

        /// <summary>
        /// Событие, которое вызывается при изменении состояния команды.
        /// </summary>
        public event EventHandler CanExecuteChanged;

        /// <summary>
        /// Инициализирует новый экземпляр команды с делегированием действий.
        /// </summary>
        /// <param name="execute">Действие, которое выполняет команда.</param>
        /// <param name="canExecute">Предикат, определяющий, можно ли выполнить команду.</param>
        public BaseCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            if (execute == null)
                throw new ArgumentNullException(nameof(execute));

            _execute = execute;
            _canExecute = canExecute;
        }

        /// <summary>
        /// Определяет, может ли команда быть выполнена в текущий момент.
        /// </summary>
        /// <param name="parameter">Параметр, передаваемый в команду.</param>
        /// <returns>Возвращает true, если команда может быть выполнена.</returns>
        public bool CanExecute(object parameter)
        {
            if (_canExecute == null)
                return true;
            return _canExecute(parameter);
        }

        // <summary>
        /// Выполняет команду.
        /// </summary>
        /// <param name="parameter">Параметр, передаваемый в команду.</param>
        public void Execute(object parameter)
        {
            _execute(parameter);
        }

        /// <summary>
        /// Вызывает событие CanExecuteChanged для уведомления об изменении возможности выполнения команды.
        /// </summary>
        public void RaiseCanExecuteChanged()
        {
            if (CanExecuteChanged != null)
            {
                CanExecuteChanged(this, EventArgs.Empty);
            }
        }
    }
}
