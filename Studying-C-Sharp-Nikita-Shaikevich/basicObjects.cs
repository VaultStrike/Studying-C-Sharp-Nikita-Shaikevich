using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studying_C_Sharp_Nikita_Shaikevich
{
    public class basicObjects
    {
        //properties - שדות/תכונות
        public int age = -1;

        public char charProperty = 'A';

        public string name = "";

        public bool goodFriend = false;

        public void ToggleBoolProperty()
        {
            goodFriend = !goodFriend;
        }
        public void goodFreind()
        {
            Console.WriteLine("Are you a good friend?");
            string answer= Console.ReadLine();
            switch (answer)
            {
                case "yes":
                    ToggleBoolProperty();
                    break;
                    case "no":
                    Console.WriteLine("Why are you running?!");
                    this.goodFriend = false;
                    break;
                    default: Console.WriteLine("Wrong Input!");
                    answer = Console.ReadLine();
                    break;
            }
        }
    }
    public class Pc
    {
        public int partIndex = 0;
        public int pcPrice;
        public bool readyForSale;
        public PcPart[] parts;
        public Pc(int parts)
        {
            this.readyForSale = false;
            this.pcPrice= 0;
            this.parts = new PcPart[parts];
        }
        public int updatePrice()
        {
            for(int i =0; i<parts.Length;i++)
            {
                this.pcPrice+= parts[i].price;
            }
            Console.WriteLine($"New Price:{this.pcPrice}");
            return this.pcPrice;
        }
        public void AddPart()
        {
            if(this.partIndex != parts.Length)
            {
                Console.Write("Enter manufacturer:");
                string manufacturer =Console.ReadLine();
                Console.Write("Enter part name:");
                string partName = Console.ReadLine();
                Console.Write("Enter id:");
                string id = Console.ReadLine();
                Console.Write("Enter price:");
                int price = int.Parse(Console.ReadLine());

                PcPart addpard = new PcPart(manufacturer, partName, id, price);
                this.parts[this.partIndex] = addpard;
                this.partIndex++;
            }
            else
                Console.WriteLine("No Space For Parts!");
        }
        public void saleCheck()
        {
            Console.WriteLine($"PC Sale Status:{this.readyForSale}");
            if(!this.readyForSale)
            {
                Console.WriteLine("PC is not ready to Buy. Do you want to update price and Buy it?");
                string answer = Console.ReadLine();
                switch (answer)
                {
                    case "yes":
                        updatePrice();
                        this.readyForSale = true;
                        Console.WriteLine($"you Got it Boss! The Price is:{this.pcPrice}");
                        break;
                    case "no":
                        Console.WriteLine("Allright Boss!");
                        break; 
                    default: Console.WriteLine("Wrong Input");
                        break;
                }
            }
        }
    }
    public class PcPart
    {
        public string manufacturer;
        public string partName;
        public string id;
        public int price;
        public PcPart(string manufacturer,string partName,string id,int price)
        {
            this.manufacturer = manufacturer;
            this.partName = partName;
            this.id = id;
            this.price = price;
        }
    }
    class runObjects
    {
        public static void DemoRun()
        {
            basicObjects obj1= new basicObjects();

            Console.Write("Enter Your Name: ");
            obj1.name = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Enter your Age: ");
            obj1.age = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            obj1.goodFreind();
        }
        public static void DemoPcRun() 
        {
            Console.WriteLine("Welcome!");
            Console.WriteLine("Today We will Build Your PC!");
            Console.WriteLine("");
            Console.WriteLine("Lets Start!");
            Console.WriteLine("How Many Parts Do You have?");
            int count = int.Parse(Console.ReadLine());
            Pc newPc = new Pc(count);
            int print = 1;
            while (print != 0)
            {
                Console.WriteLine("Hi choose your Action\n" +
                "1 – AddPart | 2 – updatePrice | 3 – saleCheck| 0 - Exit");

                print = int.Parse(Console.ReadLine());
                switch (print)
                {
                    case 0:
                        Console.WriteLine("Bye");
                        break;
                    case 1:
                        newPc.AddPart();
                        break;
                    case 2:
                        newPc.updatePrice();
                        break;
                    case 3:
                        newPc.saleCheck();
                        break;
                    default:
                        Console.WriteLine("i dont have any Applications in the number u choose try again please");
                        break;
                }
            }
        }
    }
}
