using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class CreateDrink1 : AbstractFood3
    {
        public string NameFood3()
        {
            return "Компот";
        }

        public string HelpFood3(AbstractFood1 help1, AbstractFood2 help2)
        {
            var result1 = help1.NameFood1();
            var result2 = help2.NameFood2();

            return $"Предложите клиенту {result1} и {result2}";
        }

        private static CreateDrink1 instance;

        public static CreateDrink1 GetInstance()
        {
            if (instance == null)
            {
                instance = new CreateDrink1();
            }
            return instance;
        }
    }
}
