namespace _DI
{
    public class program
    {
        static void Main(string[] args)
        {
            IProgram ca=new currentAccount();
            Account account = new Account(ca);
            account.printD();

            IProgram sa = new savingAccount();
            Account account1 = new Account(sa);
            account1.printD();
        }
    }
    public interface IProgram
    {
        public void printDetails();
    }
    public class currentAccount:IProgram
    {
        public void printDetails()
        {
            Console.WriteLine("In Current account");
        }
    }

    public class savingAccount:IProgram
    {
        public void printDetails()
        {
            Console.WriteLine("In Saving account");
        }
    }

    public class Account
    {
        private IProgram account;

        public Account(IProgram account) 
        { 
            this.account = account;
        }

        public void printD() 
        { 
            account.printDetails();
        }
    }
}
