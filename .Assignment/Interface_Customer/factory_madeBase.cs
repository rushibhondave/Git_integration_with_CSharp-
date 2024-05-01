namespace Interface_Customer
{
    public class factory_madeBase
    {
        public Silver Report1(int choice)
        {
            if (choice == 1)
            {
                return new customer1();
            }
            if (choice == 2)
            {
                return new customer2();
            }
            if (choice == 3)
            {
                return new customer3();
            }
            else
            {
                return null;
            }
        }
    }
}