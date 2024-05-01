namespace Delgate
{
    internal class Program
    {
        public delegate void deli(int a, int b);
        public static event deli addq;
        public static dynamic add(dynamic a, dynamic b)
        {
           return a + b;    
        }
        public static void add(int a, int b)
    {
            Console.WriteLine(a + b); 
    }

    public static void sub(int a, int b)
    {
            Console.WriteLine(a + b);

        }
        static void Main(string[] args)
        {
            Console.WriteLine(add(14, 14.3)); 
            deli deli = add;
            deli += sub;
            deli(1, 2);
            addq = deli;
            addq.Invoke(1,1);
            
        }
    }
}
