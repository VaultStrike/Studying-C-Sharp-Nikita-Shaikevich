using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studying_C_Sharp_Nikita_Shaikevich.Interface
{
    public class Demo_Main
    {
        public static void DemoRun()//Main ----> Program
        {
            Pokemon_Demo pikachu = new Pokemon_Demo("Pikachu", 1, 1, "Electric");

            pikachu.DoSomthing();
            pikachu.ShowLevel();
        }


    }
}
