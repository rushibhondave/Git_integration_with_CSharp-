namespace Interface
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Enter your Preminum choice: 1.Silver 2.Gold 3.Platinum");
            int n=Convert.ToInt32(Console.ReadLine());
            Factory factor = new Factory();
            Silver silver = factor.Report(n);
            if( n == 1 ) 
            {
                silver.report();
            }
            else if (n == 2)
            {
                silver.report();
            }
            else if (n == 3)
            {
                silver.report();
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }

        }
    }

    public class Factory
    {
        public Silver Report(int choice)
        {
           if(choice == 1) 
            {
                return new Customer1();   
            }
           else if(choice == 2)
            {
                return new Customer2();
            }
            else if (choice == 3)
            {
                return new Customer3();
            }
            else 
            {
                return null;
            }
        }
    }
    public abstract class Silver
    {
        public abstract void Water();
        public virtual void report()
        {
            Water();
        }
    }

    public abstract class Gold:Silver
    {
        public abstract void Bear();
        public abstract void Vodka();
        public override void report()
        {
            Water();
            Bear();
            Vodka();
        }
    }

    public abstract class Platinum : Gold
    {
        public abstract void Wisky();
        public abstract void Wine();
        public override void report()
        {
            Water();
            Bear();
            Vodka();
            Wisky();
            Wine();
        }
    }

    public class Customer1:Silver
    {
        public override void Water()
        {
            Console.WriteLine("1.Water");
        }
    }

    public class Customer2 : Gold
    {
        public override void Water()
        {
            Console.WriteLine("1.Water");
        }

        public override void Bear()
        {
            Console.WriteLine("1.Bear");
        }
        public override void Vodka()
        {
            Console.WriteLine("1.Vodka");
        }
    }

    public class Customer3 : Platinum
    {
        public override void Water()
        {
            Console.WriteLine("1.Water");
        }

        public override void Bear()
        {
            Console.WriteLine("1.Bear");
        }
        public override void Vodka()
        {
            Console.WriteLine("1.Vodka");
        }

        public override void Wisky()
        {
            Console.WriteLine("1.Bear");
        }
        public override void Wine()
        {
            Console.WriteLine("1.Vodka");
        }
    }
}
