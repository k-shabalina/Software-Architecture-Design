using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class RussianFood : AbstractFactory
    {
        public AbstractFood1 CreateSoup()
        {
            return new CreateSoup1();
        }

        public AbstractFood2 CreateMainCourse()
        {
            return new CreateMainCourse1();
        }

        public AbstractFood3 CreateDrink()
        {
            return new CreateDrink1();
        }
    }
}
