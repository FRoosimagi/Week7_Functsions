using System;

namespace UserNameAndDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnimi
            //programm küsib kasutajal sisestada numbrit 1-3
            //kui kasutaja sisestab "1", siis kuvatakse kasutaja eesnime tagurpidi
            //kui kasutaja sisestab "2", siis kuvatakse kasutaja eesnime esimest tähte
            //kui kasutaja sisestab "3", siis kuvatakse kasutaja eesnime pikkust

            Console.WriteLine("sisesta oma eesnimi:");
            string userName = Console.ReadLine();

            Console.WriteLine("Sisesta '1', '2' või '3'");
            char userOperator = Convert.ToChar(Console.ReadLine());

            switch (userOperator)
            {
                case '1':
                    UserNameLenght(userName);
                    break;
                case '2':
                    UserNameFirstLetter(userName);
                    break;
                case '3':
                    UserNameReversed(userName);
                    break;
                default:
                    Console.WriteLine("Kena päeva!");
                    break;
            }

        }

        public static void UserNameLenght(string userInput)
        {
            Console.WriteLine($"Sinu nimi on {userInput.Length} sümbolit pikk");
        }

        public static void UserNameFirstLetter(string userInput)
        {
            Console.WriteLine($"Sinu eesnime esimene täht on {userInput[0]}");
        }

        public static void UserNameReversed(string userInput)
        {
            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(userInput[i]);
            }
        }
    }
}
