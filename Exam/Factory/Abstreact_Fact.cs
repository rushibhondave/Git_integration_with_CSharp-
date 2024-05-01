namespace Dependency_Injuction1
{
    public class program
    {
        int choice1;
        public void Main()
        {
            Console.WriteLine("Enter choice");
             choice1 = Convert.ToInt32(Console.ReadLine());
            factory_made1 factory_Made1 = new factory_made1();
            Silver Silver = factory_made1.GetDetails1(choice1);
            Silver.report();
        }


    }
    public class factory_made1
    {
        public Silver? GetDetails1(int choice)
        {
            if (choice == 1)
            {
                return new Customer1();
            }
            if (choice == 2)
            {
                return new customer21();
            }
            if (choice == 3)
            {
                return new customer31();
            }
            else
            {
                return null;

            }
        }


    }

    public abstract class Silver
    {
        protected abstract void water1();
        public virtual void report()
        {
            water1();

        }
    }

    public abstract class Gold : Silver
    {
        protected abstract void Tea1();
        protected abstract void Coffe1();
        public override void report()
        {
            Console.WriteLine("Enter the Choice:: 1.T 2.C 3.W");
            int ch = Convert.ToInt32(Console.ReadLine());
            if (ch == 1)
            {
                Tea1();
            }
            if (ch == 2)
            {
                Coffe1();
            }

            if (ch == 3)
            {
                water1();
            }
        }

    }
    public abstract class Platinum : Gold
    {
        protected abstract void Bear1();
        protected abstract void Viskey1();
        public override void report()
        {
            Console.WriteLine("Enter the Choice:: 1.T 2.C 3.w 4.b 5.V");
            int ch = Convert.ToInt32(Console.ReadLine());
            if (ch == 1)
            {
                Tea1();
            }
            if (ch == 2)
            {
                Coffe1();
            }

            if (ch == 3)
            {
                water1();
            }
            if (ch == 4)
            {
                Bear1();
            }
            if (ch == 5)
            {
                Viskey1();
            }

        }
    }
  
 

    public class Customer1 : Silver
    {
        protected override void water1()
        {
            Console.WriteLine("\n 1.Water");
        }
    }


    public class customer21 : Gold
    {
        protected override void Coffe1()
        {
            Console.WriteLine("Coffe");
        }

        protected override void Tea1()
        {
            Console.WriteLine("Tea");
        }

        protected override void water1()
        {
            Console.WriteLine("water");
        }
    }
    public class customer31 : Platinum
    {
        protected override void Bear1()
        {
            Console.WriteLine("Bear");
        }

        protected override void Coffe1()
        {
            Console.WriteLine("Coffe");
        }

        protected override void Tea1()
        {
            Console.WriteLine("Tea");
        }

        protected override void Viskey1()
        {
            Console.WriteLine("Viskey");
        }

        protected override void water1()
        {
            Console.WriteLine("water");
        }
    }
   
       
    }

