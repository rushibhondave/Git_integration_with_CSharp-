using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesInjusction
{

    public interface IAccount
    {

        void print();
    }

    public class Saving_Account: IAccount
    {
        public void print()
        {
            Console.WriteLine("\nSaving Account");
        }
    }

    public class Current_Account: IAccount
    {
        public void print()
        {
            Console.WriteLine("\nCurrent Account");
        }
    }

     class Account 
    {
        public IAccount account { get; set; }

        public void printDeatils()
        {
            account.print();    
        }

    }


 
   
    class Properties
    {
        public void main()
        {
            Account Sa = new Account();
            Sa.account = new Saving_Account(); 
            Sa.printDeatils();
        }
    }
}
