using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001Interface
{
    internal class Custmer
    {
        static void Main()
        {
            string op = null;
            do
            {
                Console.WriteLine("Enter your Drink Choice :");
                Console.WriteLine("1.Gold, 2.Silver 3.Premium");
                int drChoice = Convert.ToInt32(Console.ReadLine());
                DrinkFactory DrinkFactory = new DrinkFactory();
                IPlatinum db = DrinkFactory.GetDrink3(drChoice);
                Gold db1 = DrinkFactory.GetDrink(drChoice);
                Silver db2 = DrinkFactory.GetDrink2(drChoice);

                Console.WriteLine("Enter you Drinks Choice:");
                Console.WriteLine("1.Coco, 2. Apple juice,3.Mango juice");
                int opChoice1 = Convert.ToInt32(Console.ReadLine());
                switch (opChoice1)
                {
                    case 1:
                        db1.coco();
                        break;
                    case 2:
                        db1.coco();
                        db2.apple_juice();
                        break;
                    case 3:
                        db1.coco();
                        db2.apple_juice();
                        db.Mango_juice();
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Do you want to continue? y/n");
                op = Console.ReadLine();
            } while (op != "n");




        }


        public class DrinkFactory //Factory Classes
        {
            public static Gold GetDrink(int drChoice)//Factory Methods
            {
                if (drChoice == 1)
                {
                    return new Customer1();
                }

                else
                {
                  
                    return null; 

                }
               
            }

            public Silver GetDrink2(int drChoice)//Factory Methods
            {
              

                if (drChoice == 2)
                {
                    return new Customer2();
                }

                else
                {
                  
                    return null; 
                }
              
            }

            public IPlatinum GetDrink3(int drChoice)//Factory Methods
            {

                if (drChoice == 3)
                {

                    return new Customer3();
                }
                else
                {
                 
                    return null;
                }



            }
               
            }
        }

    }



            interface Gold
            {
                void coco();

            }
            interface Silver
            {
                void apple_juice();
            }
            interface IPlatinum
            {
                void Mango_juice();
            }
            public class Customer1 : Gold
            {
                public void coco()
                {
                    Console.WriteLine("coco");
                }
            }
            public class Customer2 : Gold, Silver
            {
                void Silver.apple_juice()
                {
                    Console.WriteLine("apple_juice");
                }

                void Gold.coco()
                {
                    Console.WriteLine("coco");
                }
            }
            public class Customer3 : Gold, Silver, IPlatinum
            {
                void Silver.apple_juice()
                {
                    Console.WriteLine("apple_juic");
                }

                void Gold.coco()
                {
                    Console.WriteLine("coco");
                }

                void IPlatinum.Mango_juice()
                {
                    Console.WriteLine("Mango_juice");


                }
            }

        
    


