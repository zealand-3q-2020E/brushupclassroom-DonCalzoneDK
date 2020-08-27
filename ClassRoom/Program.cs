using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassRoom classRoom = new ClassRoom();
            classRoom.ClassName = "Coding";
            classRoom.classList.Add(new Student("Josh", 12, 05));
            classRoom.classList.Add(new Student("Ani", 02, 14));
            classRoom.classList.Add(new Student("Elvis", 04, 13));
            classRoom.classList.Add(new Student("FakeGuy",13,14));


            foreach (var name in classRoom.classList)
            {
                Console.WriteLine(name);
            }
            

            Console.ReadKey();
        }
    }
}
