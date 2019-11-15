using System;

namespace _2_zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("podaj polecenie");
                var result = Console.ReadLine();
                if (result == "exit")
                {
                    break;
                }
                else if (result == "add")
                {
                    try
                    {
                        Console.WriteLine("Podaj dwie liczby");
                        double a = double.Parse(Console.ReadLine());
                        double b = double.Parse(Console.ReadLine());
                        Console.WriteLine(a+b);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Błąd konwertowania");
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("dzielisz przez 0");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }


                }
                else if (result == "div")
                {
                    try
                    {
                        Console.WriteLine("Podaj dwie liczby");
                        double a = double.Parse(Console.ReadLine());
                        double b = double.Parse(Console.ReadLine());
                        if (b == 0)
                            throw (new Exception("blad dzielenia przez 0"));
                        else
                            Console.WriteLine(a / b);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Błąd konwertowania");
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("dzielisz przez 0");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
            while (true);
        }
    }
}
