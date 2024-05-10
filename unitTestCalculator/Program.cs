namespace UnitTestCalc
{
    static class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
						calc.ParseInput("10+10");
            Console.WriteLine("Input: ");
            string input = Console.ReadLine();
        }
    }

    public class Calculator
    {
        public double ParseInput(string input)
        {
            int[] numbers = { };
            string number = "";
            foreach (char c in input)
            {
                if (char.IsDigit(c) || c == '.')
                {
                    number += c;
                }
                else
                {
                    if (number != "")
                    {
                        numbers = numbers.Append(Convert.ToInt32(number)).ToArray();
												number = "";
                    }
                }
            }

						numbers = numbers.Append(Convert.ToInt32(number)).ToArray();

            foreach (int n in numbers)
            {
                Console.WriteLine(n);
            }

            return 0.0;
        }

        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new ArgumentException("Cannot divide by zero.");
            }
            return a / b;
        }
    }
}
