using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    /// <summary>
    /// Хранит данные об учебной дисциплине.
    /// </summary>
    internal class Discipline
    {
        /// <summary>
        /// Название премета
        /// </summary>
        private string _subject;

        /// <summary>
        /// Имя учителя
        /// </summary>
        private string _teacher;

        /// <summary>
        /// Оцнека по дистиплине
        /// </summary>
        private int _grade;

        /// <summary>
        /// Возвращает и задает предмет дисциплины.
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Возвращает и задает имя учителя дисциплины
        /// </summary>
        public string Teacher { get; set; }
        
        /// <summary>
        /// Возвращает и задает оценку по дисциплине. Должна быть в пределе от 1 до 10
        /// </summary>
        public int Grade
        {
            set
            {
                if ( value < 0 && value >= 10)
                {
                    throw new ArgumentException();
                }
                _grade = value;
            }
            get { return _grade; }
            
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Discipline"/>
        /// </summary>
        /// <param name="subject">Название дисциплины.</param>
        /// <param name="teacher">Имя преподавателя.</param>
        /// <param name="grade">Оценка по дисциплине, от 1 до 10.</param>
        public Discipline(string subject, string teacher, int grade)
        {
            Subject = subject;      
            Teacher = teacher;
            Grade = grade;
        }       

   
        public Discipline() { }
    }
}
