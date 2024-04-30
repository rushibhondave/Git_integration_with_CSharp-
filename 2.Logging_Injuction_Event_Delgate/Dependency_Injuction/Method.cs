using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Injuction
{


    public interface IAccount
    {
        void Print();
    }

    public class SavingAcc : IAccount
    {
        void IAccount.Print()
        {
            Console.WriteLine(" \n This is Saving Account");
        }
    }
    public class CurrentAcc : IAccount
    {
        void IAccount.Print()
        {
            Console.WriteLine(" \n This is a Current Account");
        }
    }


    public class JointAcc : IAccount
    {
        void IAccount.Print()
        {
            Console.WriteLine(" \n This is a Joint Account");
        }
    }


    class Account()
    {
        Factory factory = new Factory();
        
        public  void PrintAccount(IAccount account)
        {
  
            if(account==null)
            {

                account = factory.Get(1);   // not run
            }
            else
            {
                 account.Print();
            }
  

        }
    }
    class Factory
    {
        public IAccount ? Get(int choice)
        {
            if(choice==1)
            {
                return new SavingAcc();
            }
            if (choice == 2)
            {
                return new CurrentAcc();
            }
            else
            {
                return null;
            }
        }
    }
    public class Method
    {
        public  void Main()
        {
            Factory factory = new Factory();    
            IAccount? account = factory.Get(1);
   
            Account account1= new Account();
            account1.PrintAccount(account);

        }
    }
}
