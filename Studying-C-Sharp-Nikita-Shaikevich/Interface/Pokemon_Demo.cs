using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studying_C_Sharp_Nikita_Shaikevich.Interface
{
    public class Pokemon_Demo : Study_Interface
    {
        //Proparties
        private string name;
        private int id;
        private int lvl;
        private string elementType;

        //Constractor
        public Pokemon_Demo(){} //Empty Constractor
        public Pokemon_Demo(string name, int id, int lvl, string elementType)
        {
            this.name = name;
            this.id = id;
            this.lvl = lvl;
            this.elementType = elementType;
        }
        //Setters/Getters

        public string Name { get => name; set => name = value; }
        public int Id { get => id; set => id = value; }
        public int Lvl { get => lvl; set => lvl = value; }
        public string ElementType { get => elementType; set => elementType = value; }

        //Methods 
        public void DoSomthing()
        {
            Console.WriteLine($"Pokemon Name: {name} | Id: {id} | Level: {lvl} | Element Type: {elementType} |");
        }
        public void ShowLevel()
        {
            Console.WriteLine($"Pokemon Level: {lvl} | Exp for next Level: " + lvl*5);
        }

    }
}
