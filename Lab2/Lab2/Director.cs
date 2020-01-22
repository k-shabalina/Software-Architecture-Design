using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Director
    {
        private IBuilder builder;

        public IBuilder Builder
        {
            set { builder = value; }
        }

        public void MainProducts()
        {
            this.builder.BuildFlour();
            this.builder.BuildYeast();
            this.builder.BuildSugar();
            this.builder.BuildSalt();
            this.builder.BuildMilk();
            this.builder.BuildEgg();
            this.builder.BuildOil();
        }
    }
}
