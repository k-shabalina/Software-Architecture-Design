using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class CreateDrink3 : AbstractFood3
    {
        public string NameFood3()
        {
            return "Красное вино";
        }

        public string HelpFood3(AbstractFood1 help1, AbstractFood2 help2)
        {
            var result1 = help1.NameFood1();
            var result2 = help2.NameFood2();

            return $"Предложите клиенту {result1} и {result2}";
        }

        private static CreateDrink3 instance;

        public static CreateDrink3 GetInstance()
        {
            if (instance == null)
            {
                instance = new CreateDrink3();
            }
            return instance;
        }
    }
}
