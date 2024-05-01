using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _Interface_Silver_Gold
{

    public interface ISilver
    {
        protected void water();
        public  void Getdata()
        {
            water();
        }
    }
    public interface IGold : ISilver
    {
        protected void water();
        protected void Tea();
        public new void Getdata()
        {
            water();
            Tea();
        }
    }
    public interface IPlatinum : IGold
    {
        protected void water();
        protected void Tea();
        protected void Coffee();
        public new void Getdata()
        {
            water();
            Tea();
            Coffee();
        }
    }

    public class customer1 : ISilver
    {
        public void water()
        {
            Console.WriteLine("I drink Water");
        }
    }

    public class customer2 : IGold
    {
        public void water()
        {
            Console.WriteLine("I drink Water");
        }
        public void Tea()
        {
            Console.WriteLine("I drink Tea");
        }
    }

    public class customer3 : IPlatinum
    {
        public void water()
        {
            Console.WriteLine("I drink Water");
        }
        public void Tea()
        {
            Console.WriteLine("I drink Tea");
        }
        public void Coffee()
        {
            Console.WriteLine("I drink Coffee");
        }
    }

    public class PremiumFactory
    {
        public static ISilver getReport(int pf)
        {
            if (pf == 1)
                return new customer1();
            else if (pf == 2)
                return new customer2();
            else if (pf == 3)
                return new customer3();
            else
                return null;

        }
    }

    public class program
    {
        static void Main(string[] args)
        {
            string Op;
           
                Console.WriteLine("Enter your preminum: ");
                Console.WriteLine("1.Silver 2.Gold 3.Platinum");
                int choice = Convert.ToInt32(Console.ReadLine());
                PremiumFactory pf = new PremiumFactory();
                ISilver silver = PremiumFactory.getReport(choice);

                if (choice == 1)
                {
                    silver.Getdata();
                }
                if (choice == 2)
                {
                    silver.Getdata();
                }
                if (choice == 3)
                {
                    silver.Getdata();
                }
                else
                {
                    Console.WriteLine("invalid No");
                }





                //    switch (choice)
                //    {
                //        case 1:
                //            ISilver silver = pf.getData(choice);
                //            Console.WriteLine("Enter preminum: ");
                //            Console.WriteLine("1.Water");
                //            int ch = Convert.ToInt32(Console.ReadLine());

                //            if (ch == 1)
                //                silver.Getdata();
                //            else
                //                Console.WriteLine("Aukat se bahar");
                //            break;

                //        case 2:
                //            IGold gold = (IGold)pf.getData(choice);
                //            Console.WriteLine("Enter preminum: ");
                //            Console.WriteLine("1.Water 2.Tea");
                //            int ch1 = Convert.ToInt32(Console.ReadLine());

                //            if (ch1 == 1)
                //                gold.Getdata();
                //            else if (ch1 == 2)
                //                gold.Getdata();
                //            else
                //                Console.WriteLine("Aukat se bahar");

                //            break;
                //        case 3:

                //            IPlatinum platinum = (IPlatinum)pf.getData(choice);
                //            Console.WriteLine("Enter preminum: ");
                //            Console.WriteLine("1.Water 2.Tea 3.Coffee");
                //            int ch2 = Convert.ToInt32(Console.ReadLine());
                //            if (ch2 == 1)
                //                platinum.Getdata();
                //            else if (ch2 == 2)
                //                platinum.Getdata();
                //            else if (ch2 == 3)
                //                platinum.Getdata();
                //            else
                //                Console.WriteLine("Aukat se bahar");
                //            break;

                //    }
                //    Console.WriteLine("Do you want to continue?n/y");
                //    Op = Console.ReadLine();
                //} while (Op == "y");
        }
        
   }

  }




