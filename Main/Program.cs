using Main.Calculators.Abstract;
using Main.Calculators.BinaryCalculators;
using Main.Parsers;
using Main.Validators;

namespace Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var AdditionCalculator = new AdditionCalculator();
            var SubtractionCalculator = new SubtractionCalculator();
            var MultiplicationCalculator = new MultiplicationCalculator();
            var DivisionCalculator = new DivisionCalculator();

            var BinaryOperationToFunction = new Dictionary<char, IBinaryCalculator>();
            BinaryOperationToFunction.Add('+', AdditionCalculator);
            BinaryOperationToFunction.Add('-', SubtractionCalculator);
            BinaryOperationToFunction.Add('/', DivisionCalculator);
            BinaryOperationToFunction.Add('*', MultiplicationCalculator);
            var Parser = new BinaryParser(BinaryOperationToFunction.Keys.ToList());

            List<IBinaryExerciseValidator> validators = new List<IBinaryExerciseValidator>();
            validators.Add(new DivisionByZeroValidator());

            string input = Console.ReadLine();

            var parsedResult = Parser.Parse(input);
            var firstArgument = double.Parse(parsedResult[0].GetItem());
            var operation = parsedResult[1].GetItem();
            var secondArgument = double.Parse(parsedResult[2].GetItem());

            bool isValid = validators.All(validator => validator.IsValid(firstArgument, operation, secondArgument));

            if (isValid)
            {
                Console.WriteLine(BinaryOperationToFunction[char.Parse(operation)].Calculate(firstArgument, secondArgument));
            }
            
            
        }
    }
}