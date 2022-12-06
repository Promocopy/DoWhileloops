using System;

namespace dowhileloop
{
    public class Doowhileloop
    {
        public static void Main()
        {
            int totalcoffecost = 0;
            string userDecision = string.Empty;
            int userChoice = 0;

            do
            {
                do
                {
                    Console.WriteLine("WELCOME TO SPOOKY COFFEESHOP, HAVE A EXPERIENCE.");
                    Console.WriteLine("Please select your choice... 1.Small 2.Medium 3.Large");
                    userChoice = int.Parse(Console.ReadLine());

                    switch (userChoice)
                    {
                        case 1:
                            totalcoffecost +=100;
                            break;
                        case 2:
                            totalcoffecost +=200;
                            break;
                        case 3:
                            totalcoffecost +=300;
                            break;
                        default:
                            Console.WriteLine("Your choice {0} is invalid", userChoice);
                            break;
                    }
                } while (userChoice !=1 && userChoice !=2 && userChoice !=3);

                do
                {

                    Console.WriteLine("Do you want to try again - Yes or No");
                    userDecision = Console.ReadLine();

                    switch (userDecision)
                    {
                        case "Yes":

                        case "No":
                            Console.WriteLine("ByE");
                            break;
                        default:
                            Console.WriteLine("Your Decision {0} is invalid, Do you want to try again.", userDecision);
                            break;
                    }
                } while (userDecision == "Yes" && userDecision != "No");

            } while (userChoice == );





            Console.WriteLine("Thank you for sharing the experence with us");
            Console.WriteLine("Your Bill Amount = {0}", totalcoffecost);
        }
    }
}