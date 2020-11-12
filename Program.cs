using System;


namespace Miniräknare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            bool ok = false;
            string input;
            char operation = '0';
            double nr1, nr2;
            do
            {

                do
                {
                    Console.Clear();
                    Console.Beep(440, 500);
                    Console.Beep(329, 200);
                    Console.Beep(311, 200);
                    Console.Beep(329, 200);
                    Console.Beep(349, 700);
                    Console.Beep(329, 700);
                    Console.Beep(415, 500);
                    Console.Beep(440, 500);
                    Console.WriteLine("Välkommen till miniräknaren\nVad vill du göra?\n1. Addera två tal\n" +
                                "2. Subtrahera två tal\n3. Multiplicera två tal\n4. Dividera två tal\n5. Retunera återstoden\n" +
                                "6. Avsluta");
                    input = Console.ReadLine();
                    Console.Beep();
                    if (input.Equals("1"))
                    {
                        operation = '+';
                        ok = true;
                    }
                    else if (input.Equals("2"))
                    {
                        operation = '-';
                        ok = true;
                    }
                    else if (input.Equals("3"))
                    {
                        operation = '*';
                        ok = true;
                    }
                    else if (input.Equals("4"))
                    {
                        operation = '/';
                        ok = true;
                    }
                    else if (input.Equals("5"))
                    {
                        operation = '%';
                        ok = true;
                    }
                    else if (input.Equals("6"))
                    {
                        operation = 'q';
                        ok = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ogiltig input. Vänligen försök igen");
                        Console.WriteLine("Startar om miniräknaren");
                        Console.Beep(440, 1000);
                        Console.Beep(311, 1000);
                        Console.Beep(37, 2000);
                        continue;
                    }
                    Console.Beep(415, 200);
                    Console.Beep(415, 200);
                    Console.Beep(415, 200);
                    Console.Beep(311, 1200);
                    Console.Beep(349, 200);
                    Console.Beep(349, 200);
                    Console.Beep(349, 200);
                    Console.Beep(293, 1200);
                } while (!ok);
                if (operation == 'q')
                {
                    break;
                }
                do
                {
                    Console.WriteLine("Skriv in det första numret: ");
                    input = Console.ReadLine();
                    ok = double.TryParse(input, out nr1);
                    if (!ok)
                    {
                        Console.WriteLine("Skriv in ett giltigt nummer");
                        Console.Beep(440, 1000);
                        Console.Beep(311, 1000);
                        Console.Beep(37, 2000);
                    }
                } while (!ok);
                Console.Beep(174, 300);
                Console.Beep(218, 300);
                Console.Beep(262, 300);
                Console.Beep(348, 700);

                do
                {
                    Console.WriteLine("Skriv in det andra numret: ");
                    input = Console.ReadLine();
                    ok = double.TryParse(input, out nr2);
                    if (!ok)
                    {
                        Console.WriteLine("Skriv in ett giltigt nummer");
                        Console.Beep(440, 1000);
                        Console.Beep(311, 1000);
                        Console.Beep(37, 2000);
                    }
                    else if(operation == '/' && nr2 == 0)
                    {
                        Console.WriteLine("Varning, du får inte dividera med 0");
                        Console.Beep(37, 2000);
                        ok = false;
                    }
                } while (!ok);
                Console.Beep(208, 300);
                Console.Beep(262, 300);
                Console.Beep(311, 300);
                Console.Beep(416, 700);

                if (operation == '+')
                {
                    Console.WriteLine("{0} {1} {2} = {3}", nr1, operation, nr2, (nr1 + nr2));
                }
                else if (operation=='-')
                {
                    Console.WriteLine("{0} {1} {2} = {3}", nr1, operation, nr2, (nr1 - nr2));
                }
                else if (operation == '*')
                {
                    Console.WriteLine("{0} {1} {2} = {3}", nr1, operation, nr2, (nr1 * nr2));
                }
                else if (operation == '/')
                {
                    Console.WriteLine("{0} {1} {2} = {3}", nr1, operation, nr2, (nr1 / nr2));
                }
                else if (operation == '%')
                {
                    Console.WriteLine("{0} {1} {2} = {3}", (int) nr1, operation, (int) nr2, ((int) nr1 & (int) nr2));
                }
                
                Console.Beep(440, 300);
                Console.Beep(440, 600);
                Console.Beep(440, 300);
                Console.Beep(440, 600);
                Console.Beep(329, 200);
                Console.Beep(369, 200);
                Console.Beep(329, 200);
                Console.Beep(440, 600);
                Console.ReadLine();
            } while (true);
            Console.WriteLine("Hejdå!");
            Console.Beep(415, 500);
            Console.Beep(415, 500);
            Console.Beep(415, 500);
            Console.Beep(311, 375);
            Console.Beep(466, 150);
            Console.Beep(415, 500);
            Console.Beep(311, 375);
            Console.Beep(466, 150);
            Console.Beep(415, 500);
            Console.Beep(587, 500);
            Console.Beep(587, 500);
            Console.Beep(587, 500);
            Console.Beep(622, 375);
            Console.Beep(466, 150);
            Console.Beep(369, 500);
            Console.Beep(311, 375);
            Console.Beep(466, 150);
            Console.Beep(415, 1500);
        }
    }
}
