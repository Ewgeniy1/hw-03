using System;


namespace Host
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int A;
            A = int.Parse(Console.ReadLine());
            if (A == 1 || A == 2 || A == 12)
            {
                Console.WriteLine("\n You have chosen the winter months");
            }
            else if (A == 3 || A == 4 || A == 5)
            {
                Console.WriteLine("\n You have chosen the spring months");
            }
            else if (A == 6 || A == 7 || A == 8)
            {
                Console.WriteLine("\n You have chosen the summer months");

            }
            else if (A == 9 || A == 10 || A == 11)
            {
                Console.WriteLine("\n You have chosen the autumn months");
            }
            switch (A)
            {
                case 1:
                    Console.WriteLine(Lang.january);

                    break;
                case 2:
                    Console.WriteLine(Lang.february);
                    break;
                case 3:
                    Console.WriteLine(Lang.march);
                    break;
                case 4:
                    Console.WriteLine(Lang.april);
                    break;
                case 5:
                    Console.WriteLine(Lang.may);
                    break;
                case 6:
                    Console.WriteLine(Lang.june);
                    break;
                case 7:
                    Console.WriteLine(Lang.july);
                    break;
                case 8:
                    Console.WriteLine(Lang.august);
                    break;
                case 9:
                    Console.WriteLine(Lang.september);
                    break;
                case 10:
                    Console.WriteLine(Lang.october);
                    break;
                case 11:
                    Console.WriteLine(Lang.november);
                    break;
                case 12:
                    Console.WriteLine(Lang.december);
                    break;
            }

            Console.WriteLine();

        }

    }

}


            
        
    
