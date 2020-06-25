using System;

namespace ValidID
{
    class Program
    {
        static void Main(string[] args)
        {
            int idNum;
            string input;
            const int LOW = 1000;
            const int HIGH = 9999;

            Console.Write("Enter an ID Numer: ");
            input = Console.ReadLine();
            idNum = Convert.ToInt32(input);

            while(idNum < LOW || idNum > HIGH)
            {
                Console.WriteLine("{0} is an invalid ID Number", idNum);
                Console.Write("Id number must be ");
                Console.WriteLine("between {0} and {1} inclusive", LOW, HIGH);

                Console.Write("Enter an ID Number: ");
                input = Console.ReadLine();
                idNum = Convert.ToInt32(input);
            }

            Console.WriteLine("ID Number {0} is valid", idNum);
        }
    }
}
