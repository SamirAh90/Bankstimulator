using System;

namespace BankSimulator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //programmet börjar med en hälsning:


            Console.WriteLine("\t \t \t §§§ ============= Välkommen till Samir Ahmads Bankstimulator =============§§§ \n");

                   
            Console.WriteLine("Välja ett alternativ: \n");
                       
            Console.WriteLine("[I]nsättning");
            Console.WriteLine("[U]ttag");
            Console.WriteLine("[S]aldo");
            Console.WriteLine("[R]äntebetalning");
            Console.WriteLine("[A]vsluta");
            Console.Write("Välj ett alternativ: ");

            string val = Console.ReadLine().ToUpper(); // Tar in använders val

            double saldo = 0;


            switch (val)
            {
                case "I":
                    Console.Write("Ange insättningsbelopp: ");
                    double insättning = Convert.ToDouble(Console.ReadLine());
                    saldo += insättning; // "Använder 'saldo += insättning' för att lägga till det angivna beloppet i saldo."
                    Console.WriteLine("Ditt nytt saldo är:" + saldo);
                    break;

                case "U":
                    Console.Write("Ange uttagsbelopp: ");
                    double uttag = Convert.ToDouble(Console.ReadLine());
                    if (uttag <= saldo)
                    {
                        saldo -= uttag;
                        Console.WriteLine("Uttag genomfört.");
                    }
                    else
                    {
                        Console.WriteLine("Otillräckligt saldo för uttag.");
                    }
                    break;

                case "S":
                    Console.WriteLine("Saldo: " + saldo);
                    break;

                case "R":
                    Console.Write("Årligt insättningsbelopp: ");
                    double arligtInstattning = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Räntesats (%): ");
                    double rantesats = Convert.ToDouble(Console.ReadLine()) / 100;
                    Console.Write("Antal år: ");
                    int ar = Convert.ToInt32(Console.ReadLine());

                    for (int i = 0; i < ar; i++)  // använder loop
                    {
                        saldo += arligtInstattning;
                        saldo += saldo * rantesats;
                    }
                    Console.WriteLine("Saldo efter " + ar + " år: " + saldo);

                    break;

                case "A":
                    Console.WriteLine("Programmet avslutas.");
                    break;

                default:
                    Console.WriteLine("Ogiltigt val. Försök igen.");
                    break;



            }
            Console.ReadLine();
            Console.WriteLine("Vill du fortsätta igen?");



       

        }
    }
}


