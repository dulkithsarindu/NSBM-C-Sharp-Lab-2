using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ZooManagement
{
    public abstract class Animal
    {
        public abstract void MakeSound();
    }
    public class Lion : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Grrr");
        }
    }
    public class Tiger : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Brrr");    
        }
    }
    public class Elephant : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("coon");
        }
    }
    internal class Program
    {
        private static int input;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of animal you want to add");
            Console.WriteLine("1.Lion");
            Console.WriteLine("2.Tiger");
            Console.WriteLine("3.Elephant");
            Console.WriteLine("4.Exit");

            string userinput = Console.ReadLine();
            int.TryParse(userinput , out input);

            Animal[] animal = new Animal[3];

            if (input == 1)
            {
                animal[0] = new Lion();
                Lion lion = new Lion();
                lion.MakeSound();
                Console.WriteLine("First Element of array has been added");
            }
            else if (input == 2)
            {
                animal[1] = new Tiger();
                Tiger tiger = new Tiger();
                tiger.MakeSound();
                Console.WriteLine("Second Element of array has been added");
            }
            else if (input == 3)
            {
                animal[2] = new Elephant();
                Elephant elephant = new Elephant(); 
                elephant.MakeSound();
                Console.WriteLine("Third Element of array has been added");
            }
            else if (input == 4)
            {
                return;
            }
            else
            {
                Console.WriteLine("Invalid input, Try again");
            }
            Console.ReadLine();
        }
    }
}
