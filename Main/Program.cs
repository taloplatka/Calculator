using Main.Calculators.BinaryCalculators;
using Main.Dictionaries;
using Main.Parsers;
using System;


namespace Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var Parser = new BinaryParser();

            var AdditionCalculator = new AdditionCalculator();
            var SubtractionCalculator = new SubtractionCalculator();
            var MultiplicationCalculator = new MultiplicationCalculator();
            var DivisionCalculator = new DivisionCalculator();

            var BinaryOperationToFunction = new BinaryOperationToFunction();
            BinaryOperationToFunction.Set("+", AdditionCalculator);
            BinaryOperationToFunction.Set("-", SubtractionCalculator);
            BinaryOperationToFunction.Set("/", DivisionCalculator);
            BinaryOperationToFunction.Set("*", MultiplicationCalculator);


            string input = Console.ReadLine();

            var parsedInput = Parser.Parse(input, BinaryOperationToFunction.GetKeys());

            if (parsedInput[1] == "/" && parsedInput[2] == "0")
            {
                Console.WriteLine("Fuck You");
            }
            else
            {
                var firstNumber = double.Parse(parsedInput[0]);
                var secondNumber = double.Parse(parsedInput[2]);

                Console.WriteLine(BinaryOperationToFunction.Get(parsedInput[1]).Calculate(firstNumber, secondNumber));

            }
        }
    }
}