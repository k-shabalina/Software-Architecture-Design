using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class ChineseFood : AbstractFactory
    {
        public AbstractFood1 CreateSoup()
        {
            return new CreateSoup2();
        }

        public AbstractFood2 CreateMainCourse()
        {
            return new CreateMainCourse2();
        }

        public AbstractFood3 CreateDrink()
        {
            return new CreateDrink2();
        }
    }
}
