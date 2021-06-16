using System;

namespace MenyProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            int ch;
            mainMenu();
            

            do
            {

               ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 0:
                        Console.WriteLine("avslutnings....");
                        break;
                    case 1:
                        movie();
                        mainMenu();
                        break;
                    case 2:
                        repeatTen();
                        mainMenu();
                        break;
                    case 3:
                        showThirdword();
                        mainMenu();
                        break;
                    default:
                        Console.WriteLine("felaktig input.. Tryck igen: ");
                        break;


                }
            } while (ch != 0);
        }

        private static void showThirdword()
        {
            Console.WriteLine("ange en mening med minst 3 ord");
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(' ');
            
            Console.WriteLine("third word is: {0}",words[2]);
        }

        private static void repeatTen()
        {
            Console.WriteLine("ange en text som du vill upprepa");
            string txt = Console.ReadLine();
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0}.{1} ",i+1,txt);
            }
        }

        private static void movie()
        {
            int sum = 0;
            Console.WriteLine("ange antal personer");
            int noOfPerson = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < noOfPerson; i++)
            {
                Console.WriteLine("ange ålder:");
                int age = Int32.Parse(Console.ReadLine());
                if (age < 20)
                {
                    if(age<5){
                        Console.WriteLine(" gratis");
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
                    if(age>100)
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
            Console.WriteLine("\nTotalkostnad: {0}", sum);

        }

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
