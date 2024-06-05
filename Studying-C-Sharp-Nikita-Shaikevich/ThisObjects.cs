using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studying_C_Sharp_Nikita_Shaikevich
{
    public class ThisObjects
    {
        public static void UpdateId(characters characters)
        {
            characters.id = 10;
        }
        public static void Demo()
        {
            characters chari= new characters();
            chari.DisplayObj();
            chari.UpdateIds();
            chari.DisplayObj();
            chari.SetHp(10);
            Console.WriteLine(chari.GetHp());
        }


    }
    public class characters
    {
        public string name = "Niko";
        public int id = 0;
        private int hp = 100;

        public characters(string name, int id)//this דרך ראשנה להשתמש ב
        {
            this.name = name;
            this.id = id;
        }
        public characters() : this("Mario", 75) // this דרך שניה להשתמש ב
        {

        }
        public void DisplayObj()
        {
            Console.WriteLine($"Hello!, your name {name} id: {id} HP: {hp}");
        }
        public void UpdateIds()
        {
            ThisObjects.UpdateId(this);//שיטה שלישית
        }
        public void SetHp(int hp)
        {
            this.hp = hp;
        }
        public int GetHp() { return hp; }

    }


}
