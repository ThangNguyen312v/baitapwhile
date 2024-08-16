using System;
namespace baitapwhile{
    class Program{
        static void Main(string[] Args){
            int number;
            Console.WriteLine("Enter a number: ");
            number = Int32.Parse(Console.ReadLine());

            if (number < 2){
            Console.WriteLine(number + " is not a prime");
            }else{int i = 2;
                bool check = true;
                while (i <= Math.Sqrt(number))
                {
                    if (number % i == 0)
                    {
                        check = false;
                        break;
                    }
                    i++;
                }
                if (check)
                {
                    Console.WriteLine(number + " is a prime");
                }
                else
                {
                    Console.WriteLine(number + " is not a prime");
                }
            }

        }
    }

}
