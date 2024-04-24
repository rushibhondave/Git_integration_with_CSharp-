using static delgate_Private.Program;
public delegate void deql();
namespace delgate_Private
{
    internal class Program
    {  
        static void Main(string[] args)

        {
            deql del = aarti;
            del += rushi;
            Ram.Run(del);
        }
        private static void aarti()
        {
            Console.WriteLine("Hi Aarti");
        }
        private static void rushi()
        {
            Console.WriteLine("Hi Rushi");
        }
    }

}

public class Ram
{
    public static void Run(deql d1)
    {
        d1();
      
    }
}


