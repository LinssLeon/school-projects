using System;
namespace DateCheckerApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string again = "y";
            string[] monthNames = new string[] { "Januar", "Februar", "März", "April", "Mai", "Juni", "Juli", "August", "September", "Oktober", "November", "Dezember" };

            while (again.ToLower() == "y")
            {
                int day = 0, month = 0, year = 0;

                bool dContinue = true;
                while (dContinue)
                {
                    Console.WriteLine("Bitte gebe 3 Zahlen für ein Datum ein.");
                    Console.Write("Tag: ");
                    string InputDay = Console.ReadLine();
                    if (int.TryParse(InputDay, out day))
                    {
                        dContinue = false;
                    }
                    else
                    {
                        Console.WriteLine("Ungültige Eingabe. Bitte versuche es erneut.");
                    }
                }
                bool mContinue = true;
                while (mContinue)
                {
                    Console.Write("Monat: ");
                    string InputMonth = Console.ReadLine();
                    if (int.TryParse(InputMonth, out month))
                    {
                        mContinue = false;
                    }
                    else
                    {
                        Console.WriteLine("Ungültige Eingabe. Bitte versuche es erneut.");
                    }
                }
                bool yContinue = true;
                while (yContinue)
                {
                    Console.Write("Jahr: ");
                    string InputYear = Console.ReadLine();   
                    if (int.TryParse(InputYear, out year))
                    {
                        yContinue = false;
                    }
                    else
                    {
                        Console.WriteLine("Ungültige Eingabe. Bitte versuche es erneut.");
                    }
                }

                
                ValidDateCheck vDC = new ValidDateCheck();
                bool result = vDC.ValidDate(day, month, year);
                try
                {
                    Console.WriteLine($"{day}. {monthNames[month - 1]} {year}.");
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Es gibt nur 12 Monate..");
                    Console.ReadKey();
                    Console.ResetColor();
                    Console.Clear();
                    continue;
                }
                
                Console.WriteLine("Datum wird geprüft..");
                
                Thread.Sleep(3000);

                if (result == true)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Datum ist gültig.");
                    Thread.Sleep(1000);
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Datum ist ungültig.");
                    Thread.Sleep(1000);
                    Console.ResetColor();
                }

                Console.Write("Weiteres Datum prüfen y/n: ");
                again = Console.ReadLine();

                if (again.ToLower() == "y")
                {
                    Console.Clear();
                }
                else
                {
                    break;
                }
            }
        }
    }
}
