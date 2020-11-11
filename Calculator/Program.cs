using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What do you want ?");

            int.TryParse(Console.ReadLine(),out int number);

            switch (number)
            {
                case 1:
                    addNumbers();
                    break;
                case 2:
                    subtractNumbers();
                    break;
                case 3:
                    multiplicationNumbers();
                    break;
                case 4:
                    divisionNumbers();
                    break;
                default:
                    addNumbers();
                    break;
            }

            Console.ReadKey();
        }

        public static double addNumbers()
        {
            var numbers = new List<double>();
            var sum = 0.0;
            Console.WriteLine("Enter your desired number");
            string x = Console.ReadLine();
            double firstNumber = double.Parse(x, CultureInfo.InvariantCulture); ;
            numbers.Add(firstNumber);

            ConsoleKeyInfo name = Console.ReadKey();
            while (name.KeyChar.ToString() == "+")
            {
                Console.WriteLine("Enter your desired another number");

                var y = Console.ReadLine();
                var secoundNumber = double.Parse(y, CultureInfo.InvariantCulture); ;
                //double.TryParse(Console.ReadLine(), out secoundNumber);
                numbers.Add(secoundNumber);
                name = Console.ReadKey();
                secoundNumber = 0.0;
                if (name.KeyChar.ToString() == "=")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        sum = sum + numbers[i];
                    }
                }
            }
            Console.WriteLine(sum);
            return sum;
        }

        public static double subtractNumbers()
        {
            Console.WriteLine("Enter the bigger number ");
            string x = Console.ReadLine();
            var biggerNumber = Convert.ToDouble(x, CultureInfo.InvariantCulture);
            //double.TryParse(Console.ReadLine(), out biggerNumber);

            //Console.WriteLine("Enter the smaller number ");
            //string y = Console.ReadLine();
            //var smallNumber = Convert.ToDouble(y, CultureInfo.InvariantCulture);


            var newResult = 0.0;
            var subtractNumbers = new List<double>();
            
            //result = biggerNumber - smallNumber;
            subtractNumbers.Add(biggerNumber);

            ConsoleKeyInfo name = Console.ReadKey();
            while (name.KeyChar.ToString() == "-")
            {
                Console.WriteLine("Enter your desired another number");

                var z = Console.ReadLine();
                var checkedNumber = double.Parse(z, CultureInfo.InvariantCulture);
                //double.TryParse(Console.ReadLine(), out secoundNumber);

                newResult = subtractNumbers[subtractNumbers.Count-1]-checkedNumber;
                subtractNumbers.Add(newResult);
                name = Console.ReadKey();
                
                
                checkedNumber = 0.0;

                if (name.KeyChar.ToString() == "=")
                {
                    Console.WriteLine(newResult);
                    break;
                }
            }
            return newResult;
        }

        public static int multiplicationNumbers()
        {
            int sum = 170;
            Console.WriteLine(sum);
            return 100;
        }

        public static int divisionNumbers()
        {
            int sum = 10;
            Console.WriteLine(sum);
            return 100;
        }
    }
}
