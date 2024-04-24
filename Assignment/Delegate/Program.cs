namespace Assignment1
{
    public delegate void mydelegates();
    internal class Program
    {
        static void Main(string[] args)

        {
            String choice;
            do
            {
                pdf x1 = new pdf();
                mydelegates d1 = x1.parse;
                mydelegates d2 = x1.validate;
                mydelegates d3 = x1.save;
                mydelegates d4 = x1.revalidate;
                //coupling between events and delegates

                x1.e1 += d1;
                x1.e1 += d2;
                x1.e1 += d3;

                Console.WriteLine("\nDo you want to add special functionality y/n");
                char ch = Convert.ToChar(Console.ReadLine());
                if (ch == 'y')
                {
                    x1.e1 += d4;
                }
                x1.call(); //  calling event e1
                Console.WriteLine("\nDo you want to continue ? ");
                choice = Console.ReadLine();
            }
            while (choice == "y");
        }

        public class pdf
        {
            public event mydelegates e1;
            public void parse()
            {
                Console.WriteLine("pdf parsed");
            }
            public void validate()
            {
                Console.WriteLine("pdf validated");
            }
            public void revalidate()
            {
                Console.WriteLine("pdf revalidated");
            }
            public void save()
            {
                Console.WriteLine("pdf saved");
            }
            public void call()
            {
                e1();
            }
        }

    }
}

