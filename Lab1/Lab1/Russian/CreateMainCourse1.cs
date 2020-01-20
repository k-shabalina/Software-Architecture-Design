using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class CreateMainCourse1 : AbstractFood2
    {
        public string NameFood2()
        {
            return "Пельмени";
        }

        public string HelpFood2(AbstractFood1 help1, AbstractFood3 help2)
        {
            var result1 = help1.NameFood1();
            var result2 = help2.NameFood3();

            return $"Предложите клиенту {result1} и {result2}";
        }

        private static CreateMainCourse1 instance;

        public static CreateMainCourse1 GetInstance()
        {
            if (instance == null)
            {
                instance = new CreateMainCourse1();
            }
            return instance;
        }
    }
}
