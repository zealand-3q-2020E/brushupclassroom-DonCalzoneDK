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
            return $"Student name: {Name} \nBirthday: {BirthMonth} / {Birthday} season: {Season()}\n";
        }

        public string Season()
        {
            if (BirthMonth == 12 || BirthMonth == 1 || BirthMonth == 2) return "Winter";
            if (BirthMonth == 3 || BirthMonth == 4 || BirthMonth == 5) return "Spring";
            if (BirthMonth == 6 || BirthMonth == 7 || BirthMonth == 8) return "Summer";
            if (BirthMonth == 9 || BirthMonth == 10 || BirthMonth == 11) return "Autumn";
            else return "Error: Invalid Month";
        }
    }
}
