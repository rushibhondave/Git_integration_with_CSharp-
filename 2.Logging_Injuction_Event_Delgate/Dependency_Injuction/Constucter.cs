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
    public class Account
    {
        private IAccount account;

        factory factory = new factory();
        public Account(IAccount? Acc)
        {

            account = Acc;
            //if (account==null)
            //{
            //    account = factory.GetFactory(1);
            //}
            //else
            //{

            //}


        }

        public void PrintDetails() 
        {
            account.Print(); 
        }
    }

    public class factory
    {
        public IAccount GetFactory(int choice) 
        {
                if(choice==1)
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

           string N;
           do
           {
              
                Console.WriteLine("\nChoose the Account type");
                Console.Write("\n1.Saving 2.Current 3.Joint 4.Jandhan :: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                factory factory = new factory();
                IAccount account = factory.GetFactory(choice);
                Account account1 = new Account(account);
                account1.PrintDetails();
              


                #region Properties Injuction
                //  Properties pro = new Properties();
                // pro.main(); 
                #endregion

                #region Method Injuction
             //   Method method = new Method();
               // method.Main(); 
                #endregion


            Console.Write("\n Do you want to continue  1.Yes-y 2.No-n::");
              N = Console.ReadLine();

            } while (N != "n");

        }
    }

}



