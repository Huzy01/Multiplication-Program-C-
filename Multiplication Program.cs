using System;

namespace assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Huzy's multiplication quiz");
            Console.WriteLine("press enter to view your first number");
            Console.ReadLine();
            int iNum1 = 0;
            int iNum2 = 0;
            int iguess = 0;
            int ipoints = 0;
            int iquestion = 1;
            int iloop = 0;
            string question;

            for(iloop = 0; iloop < 10; iloop++) {
                Random randomNumber = new Random();
                iNum1 = randomNumber.Next(1, 6);

                Random randomNumber2 = new Random();
                iNum2 = randomNumber.Next(1, 6);
                int iTotal = 0;
                iTotal = iNum1 * iNum2;
                Console.WriteLine("question " + iquestion + ": what is" + iNum1 + " x " + iNum2);
                iquestion = iquestion + 1;

                iguess = int.Parse(Console.ReadLine());

                if (iguess == iTotal)
                {
                    Console.WriteLine("correct");
                    ipoints = ipoints + 1;

                }
                else
                {
                    Console.WriteLine("incorrect");

                }


                Console.ReadLine();
            }
                Console.ReadLine();
                Console.WriteLine("you got a total of" + ' ' + ipoints);

        }
    }
}
