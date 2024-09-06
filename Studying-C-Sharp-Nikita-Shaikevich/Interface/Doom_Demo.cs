using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studying_C_Sharp_Nikita_Shaikevich.Interface
{
    public class Doom_Demo : Study_Interface
    {
        //Proparties
        private string name;
        private int id;
        private int lvl;
        private int hp;
        private string weaponeType;

        //Constractors
        public Doom_Demo() { } //Empty Constractor
        public Doom_Demo(string name, int id, int lvl, int hp, string weaponeType)
        {
            this.name = name;
            this.id = id;
            this.lvl = lvl;
            this.hp = hp;
            this.weaponeType = weaponeType;
        }

        //Setters/Getters
        public string Name { get => name; set => name = value; }
        public int Id { get => id; set => id = value; }
        public int Lvl { get => lvl; set => lvl = value; }
        public int Hp { get => hp; set => hp = value; }
        public string WeaponeType1 { get => weaponeType; set => weaponeType = value; }

        //Methods
        public void DoSomthing()
        {
            Console.WriteLine($"Player Name: {name} | Id: {id} | Level: {lvl} | Weapone Type: {weaponeType} |");
        }
        public void ShowLevel()
        {
            Console.WriteLine($"Player Level: {lvl} | Exp for next Level: " + lvl * 10);
        }
    }
}
