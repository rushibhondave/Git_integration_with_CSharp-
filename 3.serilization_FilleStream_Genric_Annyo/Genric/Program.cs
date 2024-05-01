using System;

namespace Genric
{


    public class Genric <T>
    {

       public T ? msg;
        
        public void genaricMehtod(T name,T id)
        {
            Console.WriteLine("Msg {0}",msg);
            Console.WriteLine("Msg {0}" , name);
            Console.WriteLine("Msg {0}", id);
        }

        public void add<T>(int a, int b)
        {  
            Console.WriteLine("Add is ::{0} ",(a+b));
        }

    }

   

    internal class Program
    {
        static void Main(string[] args)
        {

            Genric<String> genric=new Genric<String>();
            genric.msg="Hello"; 
            genric.genaricMehtod("Rushi","1");

            Genric<int> add = new Genric<int>();
            add.add<int>(1,2);
        }
    }
}



