using PropertiesInjusction;
using Method_Injuction;

namespace Dependency_Injuction
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

    public class JandhanAcc : IAccount
    {
        void IAccount.Print()
        {
            Console.WriteLine(" \n This is a Jandhan  Account");
        }
    }
    
    public class Accout
    {
        private IAccount account;

        public Accout(IAccount accc)
        {
            account=accc;
        }
        public void Print()
        {
            account.Print();
        }
    }

    public class factory
    {
        public IAccount GetFactory(int choice)
        {
            if (choice == 1)
            {
                return new SavingAcc();
            }
            if (choice == 2)
            {
                return new CurrentAcc();
            }
            if (choice == 3)
            {

                return new JointAcc();
            }
            if (choice == 4)
            {
                return new JandhanAcc();
            }
            else
            {
                return null;
            }
        }
    }


    class Constucter
    {
        static void Main(string[] args)
        {

    

                Console.WriteLine("\nChoose the Account type");
                Console.Write("\n1.Saving 2.Current 3.Joint 4.Jandhan :: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                factory factory = new factory();
                IAccount account = factory.GetFactory(choice);
                Accout acc = new Accout(account);
                acc.Print();        
               



             

        }
    }

}



