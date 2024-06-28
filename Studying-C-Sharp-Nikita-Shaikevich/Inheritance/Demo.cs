using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studying_C_Sharp_Nikita_Shaikevich.Inheritance
{
    public class Demo
    {
        public static void demo()
        {
            Vehicle tesla = new Vehicle(100,1,"no color","tesla","NA");
            Plain teslaPlain = new Plain("fly-X", 10000, 1001);
            Train teslaTrain = new Train("train-Xmax", 18, 2001);
            Vehicle[] arr = { tesla, teslaPlain, teslaTrain };


            ((Plain)tesla).DoPlain();
        }
    }
}
