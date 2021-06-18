using System;

namespace MenyProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
                menuOption();
        }
           
        private static void menuOption()
        {
            do
            {
                mainMenu();

                switch (Console.ReadLine())
                {
                    case "0":
                        Environment.Exit(0);
                        break;

                    case "1":
                        movie();
                         break;

                    case "2":
                        repeatTen();
                        break;
                      
                    case "3":
                        showThirdword();
                        break;
                       
                    default:
                        Console.WriteLine("felaktig input.. Tryck igen: ");
                        break;
                }
            } while (true);
        }

        //case 3 method
        private static void showThirdword()
        {
            Console.WriteLine("ange en mening med minst 3 ord");
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(" ", StringSplitOptions.RemoveEmptyEntries);
      
            if (words.Length<3)
                Console.WriteLine("meningen är för kort");
            else
            Console.WriteLine("Det tredje ordet är : ' {0} '\n", words[2]);
        }

        //case 2 method
        private static void repeatTen()
        {
            Console.WriteLine("ange en text som du vill upprepa");
            string txt = Console.ReadLine();
           
            if (string.IsNullOrEmpty(txt))
            {

                Console.WriteLine("Empty text... ange en text");
                txt = Console.ReadLine();
            }
           
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0}.{1} ",i+1,txt);
            }

            Console.WriteLine("\n");
        }

        //case  1 methods
        private static void movie()
        {
         
            try
            {
                calculateTotal();
            }
            catch (FormatException )     
            {
                Console.WriteLine("fel typ.. tryck correct value");
                calculateTotal();
            }
             
        }
                  

        private static void calculateTotal()
        {
            int sum = 0;
            Console.WriteLine("Ange antal personer");
            int noOfPerson = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < noOfPerson; i++)
            {
                Console.WriteLine("Ange ålder:");
                int age = Int32.Parse(Console.ReadLine());
                if (age < 20)
                {
                    if (age < 5)
                    {
                        Console.WriteLine(" Gratis ");
                        sum += 0;
                    }
                    else
                    {
                        Console.WriteLine("Ungdompris: 80kr");
                        sum += 80;
                    }
                }
                else if (age >= 20 && age <= 64)
                {
                    Console.WriteLine("Standardpris: 120kr");

                    sum += 120;

                }
                else
                {
                    if (age > 100)
                    {
                        Console.WriteLine(" gratis");
                        sum += 0;
                    }
                    else
                    {
                        Console.WriteLine("Pensionärpris: 90kr");
                        sum += 90;
                    }


                }

            }
            Console.WriteLine("\nTotalkostnad: {0}\n", sum);
        }


        //main menu method
        private static void mainMenu()
        {
            Console.WriteLine("\n--------------------------");
            Console.WriteLine("\tHuvudMeny");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Tryck 1 : bio ");
            Console.WriteLine("Tryck 2 : Upprepa tio gånger ");
            Console.WriteLine("Tryck 3: Det tredje ordet");
            Console.WriteLine("Tryck 0: Stäng");
        }
    }
}

                  
                              
           
