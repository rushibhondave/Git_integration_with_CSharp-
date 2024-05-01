using Dependency_Injuction1;
namespace Dependency_Injuction
{
    public interface ISilver
    {
        protected void water();
        public virtual void report()
        {
            water();
        }
    }

    public interface IGold : ISilver
    {
        protected void Tea();
        protected void Coffe();
        public new void report()
        {
            Console.WriteLine("Enter the Choice:: 1.T 2.C");
            int ch = Convert.ToInt32(Console.ReadLine());
            if (ch == 1)
            {
                Tea();
            }
            if (ch == 2)
            {
                Coffe();
            }

            if (ch == 3)
            {
                water();
            }
        }

    }
    public interface IPlatinum : IGold
    {
        protected void Bear();
        protected void Viskey();
        public new void report()
        {
            Console.WriteLine("Enter the Choice:: 1.T 2.C 3.w 4.b 5.V");
            int ch = Convert.ToInt32(Console.ReadLine());
            if (ch == 1)
            {
                Tea();
            }
            if (ch == 2)
            {
                Coffe();
            }

            if (ch == 3)
            {
                water();
            }
            if (ch == 4)
            {
                Bear();
            }
            if (ch == 5)
            {
                Viskey();
            }

        }
    }

    class factory_made
    {
        public ISilver GetDetails(int choice)
        {
            if (choice == 1)
            {
                return new customer1();
            }
            else
            {
                return null;

            }
        }

        public IGold GetDetails1(int choice)
        {
            if (choice == 2)
            {
                return new customer2();
            }

            else
            {
                return null;

            }
        }


        public IPlatinum GetDetails2(int choice)
        {
            if (choice == 3)
            {
                return new customer3();
            }
            else
            {
                return null;

            }



        }

        public class customer1 : ISilver
        {
            void ISilver.water()
            {
                Console.WriteLine("Water");
            }
        }
        public class customer2 : IGold
        {
            public void Coffe()
            {
                Console.WriteLine("Coffe");
            }

            public void Tea()
            {
                Console.WriteLine("Tea");
            }

            public void water()
            {
                Console.WriteLine("water");
            }
        }
        public class customer3 : IPlatinum
        {
            public void Bear()
            {
                Console.WriteLine("Bear");
            }

            public void Coffe()
            {
                Console.WriteLine("Coffe");
            }

            public void Tea()
            {
                Console.WriteLine("Tea");
            }

            public void Viskey()
            {
                Console.WriteLine("Viskey");
            }

            public void water()
            {
                Console.WriteLine("water");
            }
        }

        internal class Program
        {
            //static void Main(string[] args)
            //{
            //    Console.WriteLine("Enter the Choice:: 1.S 2.G 3.P");
            //    int choice = Convert.ToInt32(Console.ReadLine());
            //    factory_made factory_Made = new factory_made();

            //    if (choice == 1)
            //    {
            //        ISilver silver = factory_Made.GetDetails(choice);
            //        silver.report();
            //    }
            //    if (choice == 2)
            //    {
            //        IGold silver = factory_Made.GetDetails1(choice);
            //        silver.report();


            //    }

            //    if (choice == 3)
            //    {
            //        IPlatinum silver = factory_Made.GetDetails2(choice);
            //        silver.report();
            //    }
            //}

            static void Main(string[] args)
            {
                program program = new program();
                program.Main();
            }
        }
    }
}
