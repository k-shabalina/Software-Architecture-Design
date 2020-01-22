using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();
            var builder = new ConcreteBuilder();
            director.Builder = builder;

            Console.WriteLine("Продукты, которые используются во всех рецептах:");
            director.MainProducts();
            Console.WriteLine(builder.GetProduct().ListParts());

            Console.WriteLine("Клиент заказал Синнабон:");
            builder.BuildFlour();
            builder.BuildYeast();
            builder.BuildSugar();
            builder.BuildSalt();
            builder.BuildMilk();
            builder.BuildEgg();
            builder.BuildOil();
            builder.BuildCondensedMilk();
            Console.WriteLine(builder.GetProduct().ListParts());

            Console.WriteLine("Клиент заказал Булочку с маком и шоколадом:");
            builder.BuildFlour();
            builder.BuildYeast();
            builder.BuildSugar();
            builder.BuildSalt();
            builder.BuildMilk();
            builder.BuildEgg();
            builder.BuildOil();
            builder.BuildChocolate();
            builder.BuildPoppy();
            Console.WriteLine(builder.GetProduct().ListParts());

            Console.WriteLine("Клиент заказал Сосиску в тесте:");
            builder.BuildFlour();
            builder.BuildYeast();
            builder.BuildSugar();
            builder.BuildSalt();
            builder.BuildMilk();
            builder.BuildEgg();
            builder.BuildOil();
            builder.BuildSausage();
            Console.WriteLine(builder.GetProduct().ListParts());

            Console.WriteLine("Клиент заказал Плюшку:");
            builder.BuildFlour();
            builder.BuildYeast();
            builder.BuildSugar();
            builder.BuildSalt();
            builder.BuildMilk();
            builder.BuildEgg();
            builder.BuildOil();
            Console.WriteLine(builder.GetProduct().ListParts());
            Console.ReadKey();
        }
    }
}
