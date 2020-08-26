using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class Student
    {

        public string Name { get; }
        public int BirthMonth { get; }
        public int Birthday { get; }

        public Student(string name, int birthMonth, int birthday)
        {
            Name = name;
            BirthMonth = birthMonth;
            Birthday = birthday;
        }

        public override string ToString()
        {
            return $"Student name: {Name} birth month: {BirthMonth} day: {Birthday}";
        }
    }
}
