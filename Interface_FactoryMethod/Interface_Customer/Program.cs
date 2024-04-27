namespace Interface_Customer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nChoose the Drinks from Options :");
            Console.Write("1.Silver, 2. Gold, 3. Platinum  ::  ");
            int choice = Convert.ToInt32(Console.ReadLine());
            factory_made factory_Made = new factory_made();
            Silver silver = factory_Made.report(choice);

            if(choice==1)
            {
                silver.Report();
            }
            if (choice == 2)
            {
                silver.Report();
            }
            if (choice == 3)
            {
                silver.Report();
            }
            else
            {
                Console.WriteLine("invalid No");
            }

        }
    }


    public interface Silver
    {
        protected void SilverPack();
        public virtual void Report()
        {
            SilverPack();
        }
    }

     interface Gold: Silver
    {
        protected void GoldPack();
        public new void Report()
        {
            SilverPack();
            GoldPack();
        }
    }
     interface Paltinium: Gold, Silver
    {
        protected void PaltiniumPack();
        public new void Report()
        {
            SilverPack();
            GoldPack();
            PaltiniumPack();
        }

    }

    public class factory_made
    {
        public Silver report(int choice)
        {
             if(choice==1)
            {
                return new customer1();
            }
             if(choice==2)
            {
                return new customer2();
            }
             if(choice==3)
            {
                return new customer3();
            }
             else
            {
                return null;
            }
        }
    }


    public class customer1 : Silver
    {
        void Silver.SilverPack()
        {
            Console.WriteLine("SilverPack");
        }
    }

    public class customer2 : Gold
    {
        void Gold.GoldPack()
        {
            Console.WriteLine("GoldPack");
        }

        void Silver.SilverPack()
        {
            Console.WriteLine("SilverPack");
        }
    }
    public class customer3 : Paltinium
    {
        void Gold.GoldPack()
        {
            Console.WriteLine("GoldPack");
        }

        void Paltinium.PaltiniumPack()
        {
            Console.WriteLine("PaltiniumPack");
        }

        void Silver.SilverPack()
        {
            Console.WriteLine("SilverPack");
        }
    }
}
