using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;

namespace Abstract_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string close = null;
            do { 
            Console.WriteLine("\nChoose the Drinks from Options :");
            Console.Write("1.Silver, 2. Gold, 3. Platinum  ::  ");
            int choice = Convert.ToInt32(Console.ReadLine());
            factory_made factory_Made = new factory_made();
            Silver silver = factory_Made.GenrateReport(choice);
                
                if (choice==1)
                {
                    silver.water();

                }
                if (choice == 2)
                {
                    silver.report();

                }
                if (choice == 3)
                {
                    silver.report();

                }
                Console.WriteLine("\nDo you want to continue : : 1.y 2. n");
                close = Console.ReadLine();
            } while (close!= "n");


        }
    }


    public abstract  class Silver
    {
        public abstract void water();
        public virtual void report()
        {
            water();
        }
    }
    public abstract class Gold: Silver
    {
        protected abstract void Apple_Juice();
        protected abstract void Beer();

        public override void report()
        {
            water();
            Beer();
            Apple_Juice();
        }
    }
    public abstract class Platinum: Gold
    {
        protected abstract void Kingfisher();
        protected abstract void Vodka();

        public override void report()   // override==new
        {
            water();
            Beer();
            Apple_Juice();
            Kingfisher();
            Vodka();
        }
    }

    public class factory_made
    {
        public Silver GenrateReport(int choice )
        {
            if (choice == 1)
            {
                return new Customer1();
            }
            if (choice == 2)
            {
                return new Customer2();
            }
            if (choice == 3)
            {
                return new Customer3();
            }
            else
            {
                return null;
            }

        }
    }

    public class Customer1 : Silver
    {
        public override void water()
        {
            Console.WriteLine("\n 1. Water");
        }
    }

    public class Customer2 : Gold
    {
        protected override void Apple_Juice()
        {
            Console.WriteLine("\n3. Apple_Juice");
        }

        protected override void Beer()
        {
            Console.WriteLine("\n2. Beer");
        }

        public override void water()
        {
            Console.WriteLine("\n 1. water");
        }
    }
    public class Customer3 : Platinum
    {
        protected override void Apple_Juice()
        {
            Console.WriteLine("\n3. Apple_Juice");
        }

        protected override void Beer()
        {
            Console.WriteLine("\n2.Beer");
        }

        protected override void Kingfisher()
        {
            Console.WriteLine("\n4.Kingfisher");
        }

        protected override void Vodka()
        {
            Console.WriteLine("\n5.Vodka");
        }

        public override void water()
        {
            Console.WriteLine("\n1.water");
        }
    }

}

