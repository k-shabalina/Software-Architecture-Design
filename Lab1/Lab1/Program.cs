using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            CreateDrink2 a1 = CreateDrink2.GetInstance();
            CreateSoup2 a2 = CreateSoup2.GetInstance();
            CreateMainCourse2 a3 = CreateMainCourse2.GetInstance();
            Console.WriteLine($"Клиент заказал {a1.NameFood3()}");
            Console.WriteLine(a1.HelpFood3(a2, a3));

            CreateSoup1 a4 = CreateSoup1.GetInstance();
            CreateDrink1 a6 = CreateDrink1.GetInstance();
            CreateMainCourse1 a5 = new CreateMainCourse1();
            Console.WriteLine($"Клиент заказал {a4.NameFood1()}");
            Console.WriteLine(a4.HelpFood1(a5, a6));

            Console.ReadKey();

        }
    }
}
