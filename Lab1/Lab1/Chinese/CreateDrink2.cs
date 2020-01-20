using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class CreateDrink2 : AbstractFood3
    {
        public string NameFood3()
        {
            return "Байцзю";
        }

        public string HelpFood3(AbstractFood1 help1, AbstractFood2 help2)
        {
            var result1 = help1.NameFood1();
            var result2 = help2.NameFood2();

            return $"Предложите клиенту {result1} и {result2}";
        }

        private static CreateDrink2 instance;

        public static CreateDrink2 GetInstance()
        {
            if (instance == null)
            {
                instance = new CreateDrink2();
            }
            return instance;
        }
    }
}
