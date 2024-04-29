using System.Transactions;

namespace Assignment_Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Emp[] emp = new Emp[3];
            for (int i = 0; i < emp.Length; i++)
            {
                Emp e1 = new Emp();
                Console.WriteLine("Enter id");
                e1.EmpId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter name");
                e1.EmpName = Console.ReadLine();
                Console.WriteLine("Enter address");
                e1.EmpAddress = Console.ReadLine();
                emp[i] = e1;
            }
            Console.WriteLine("Enter the position of record you want see: ");
            int pos = Convert.ToInt32(Console.ReadLine());
            //printing record
            foreach (Emp e in emp)
            {
                if (e.EmpId == emp[pos - 1].EmpId)
                {
                    Console.WriteLine(e.EmpId + "   " + e.EmpName + "   " + e.EmpAddress);
                    break;
                }
            }


            Console.WriteLine("Do you want to change 1.name  2.address: ");
            int ch = Convert.ToInt32(Console.ReadLine());
            if (ch == 1)
            {
                //updating name
                Console.WriteLine("Enter name: ");
                String s = Console.ReadLine();
                emp[pos - 1].EmpName = s;
            }
            else if (ch == 2)
            {
                //updating address
                Console.WriteLine("Enter address: ");
                String s = Console.ReadLine();
                emp[pos - 1].EmpAddress = s;
            }

            Console.WriteLine("\nAll records:");
            foreach (Emp e in emp)
            {
                Console.WriteLine(e.EmpId + "  " + e.EmpName + "  " + e.EmpAddress);
            }


        }

    }
    public class Emp
    {
        int empId;
        string empName;
        string empAddress;

        public int EmpId { get => empId; set => empId = value; }
        public string EmpName { get => empName; set => empName = value; }
        public string EmpAddress { get => empAddress; set => empAddress = value; }
    }

}