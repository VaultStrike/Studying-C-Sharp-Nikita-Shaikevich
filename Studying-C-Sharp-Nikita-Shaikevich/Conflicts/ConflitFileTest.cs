using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studying_C_Sharp_Nikita_Shaikevich.Conflicts
{
    internal class ConflitFileTest
    {
        
        public static void Conflict2()//Changed to Conflict2() From Conflict1()
        {
            Console.WriteLine("This is New Conflict");
            Console.WriteLine("Lets Test This Conflict! (CHANGED!)");
        }
    }
}
