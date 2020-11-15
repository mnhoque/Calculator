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
        //static List<double> numbers = new List<double>();

        static void Main(string[] args)
        {
            Console.WriteLine("What do you want ?");
            Console.WriteLine("Enter a number between 1 to 4");
            int.TryParse(Console.ReadLine(), out int number);

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
            double firstNumber = double.Parse(x); 
            numbers.Add(firstNumber);

            ConsoleKeyInfo name = Console.ReadKey();
            while (name.KeyChar.ToString() == "+")
            {
                Console.WriteLine("Enter your desired another number");

                var y = Console.ReadLine();
                var secoundNumber = double.Parse(y); 
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
            //string x = Console.ReadLine();
            double biggerNumber = 0.0;
            double.TryParse(Console.ReadLine(), out biggerNumber);

            
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

                //var z = Console.ReadLine();
                double checkedNumber = 0.0; 
                double.TryParse(Console.ReadLine(), out checkedNumber);

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

        public static double multiplicationNumbers()
        {
            var multiplicationNumbers = new List<double>();
            Console.WriteLine("Enter a number ");
            var entered_Number = double.Parse(Console.ReadLine());
            multiplicationNumbers.Add(entered_Number);
            
            double total_Multiplication = 0.0;
            ConsoleKeyInfo name = Console.ReadKey();

            while (name.KeyChar.ToString() == "*")
            {
                Console.WriteLine("Enter your desired another number");

                //var z = Console.ReadLine();
                double checkedNumber = 0.0;//, CultureInfo.InvariantCulture
                double.TryParse(Console.ReadLine(), out checkedNumber);

                total_Multiplication = multiplicationNumbers[multiplicationNumbers.Count - 1] * checkedNumber;
                multiplicationNumbers.Add(total_Multiplication);
                name = Console.ReadKey();

                checkedNumber = 0.0;

                if (name.KeyChar.ToString() == "=")
                {
                    Console.WriteLine(total_Multiplication);
                    break;
                }
            }
                //Console.WriteLine(total_Multiplication);
            return total_Multiplication;
        }

        public static double divisionNumbers()
        {
            var dividedNumbers = new List<double>();
            Console.WriteLine("Enter a number ");
            var entered_Number = double.Parse(Console.ReadLine());
            dividedNumbers.Add(entered_Number);

            double total_Division = 0.0;
            ConsoleKeyInfo name = Console.ReadKey();

            while (name.KeyChar.ToString() == "/")
            {
                Console.WriteLine("Enter your desired another number");

                //var z = Console.ReadLine();
                double checkedNumber = 0.0;//, CultureInfo.InvariantCulture
                double.TryParse(Console.ReadLine(), out checkedNumber);

                total_Division = dividedNumbers[dividedNumbers.Count - 1] / checkedNumber;
                dividedNumbers.Add(total_Division);
                name = Console.ReadKey();

                checkedNumber = 0.0;

                if (name.KeyChar.ToString() == "=")
                {
                    Console.WriteLine(total_Division);
                    break;
                }
            }
            return total_Division;
        }
    }
}
