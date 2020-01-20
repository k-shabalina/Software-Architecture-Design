using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public interface AbstractFactory
    {
        AbstractFood1 CreateSoup();
        AbstractFood2 CreateMainCourse();
        AbstractFood3 CreateDrink();
    }
}
