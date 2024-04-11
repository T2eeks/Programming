using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    internal class Discipline
    {
        private string _subject;
        private string _teacher;
        private int _grade;

        public string Subject { get; set; }
        public string Teacher { get; set; }
        
        public int Grade
        {
            set
            {
                if ( value < 0 && value > 10)
                {
                    throw new ArgumentException();
                }
                _grade = value;
            }
            get { return _grade; }
            
        }
        public Discipline(string subject, string teacher, int grade)
        {
            Subject = subject;      
            Teacher = teacher;
            Grade = grade;
        }       
        public Discipline() { }
    }
}
