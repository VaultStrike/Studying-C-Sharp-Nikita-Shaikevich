using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studying_C_Sharp_Nikita_Shaikevich.Inheritance
{
    public class Electric_Products
    {
        protected int price;
        private int id = 0;
        protected int warrantyPeriod;//in Mothnts
        private bool isEnergyEfficient;

        public Electric_Products(int price, int warrantyPeriod, bool isEnergyEfficient)
        {
            this.price = price;
            this.warrantyPeriod = warrantyPeriod;
            this.isEnergyEfficient = isEnergyEfficient;
            id++;
        }
        public virtual void DisplayProduct()
        {
            Console.WriteLine($"Id: {id} | Price: {price} | warranty Period in Months: {warrantyPeriod} | EnergyEfficient: {isEnergyEfficient}");
        }
    }


}
