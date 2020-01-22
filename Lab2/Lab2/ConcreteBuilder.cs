using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class ConcreteBuilder : IBuilder
    {
        private Product product = new Product();

        public ConcreteBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this.product = new Product();
        }

        public void BuildFlour()
        {
            this.product.Add("Мука");
        }

        public void BuildYeast()
        {
            this.product.Add("Дрожжи");
        }

        public void BuildSugar()
        {
            this.product.Add("Сахар");
        }

        public void BuildSalt()
        {
            this.product.Add("Соль");
        }

        public void BuildMilk()
        {
            this.product.Add("Молоко");
        }

        public void BuildEgg()
        {
            this.product.Add("Яйцо");
        }

        public void BuildChocolate()
        {
            this.product.Add("Шоколад");
        }

        public void BuildCondensedMilk()
        {
            this.product.Add("Сгущенка");
        }

        public void BuildOil()
        {
            this.product.Add("Масло");
        }

        public void BuildPoppy()
        {
            this.product.Add("Мак");
        }

        public void BuildSausage()
        {
            this.product.Add("Сосиска");
        }

        public Product GetProduct()
        {
            Product result = this.product;

            this.Reset();

            return result;
        }
    }
}
