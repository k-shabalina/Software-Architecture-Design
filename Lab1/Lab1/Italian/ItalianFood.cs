using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class ItalianFood : AbstractFactory
    {
        public AbstractFood1 CreateSoup()
        {
            return new CreateSoup3();
        }

        public AbstractFood2 CreateMainCourse()
        {
            return new CreateMainCourse3();
        }

        public AbstractFood3 CreateDrink()
        {
            return new CreateDrink3();
        }
    }
}
