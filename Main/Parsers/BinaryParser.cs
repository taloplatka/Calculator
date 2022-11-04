



namespace Main.Parsers
{
    internal class BinaryParser
    {
        private readonly List<char> _operations;

        public BinaryParser()
        {
            _operations = new List<char>();
            _operations.Add('+');
            _operations.Add('-');
            _operations.Add('*');
            _operations.Add('/');
        }
        public List<string> Parse(string input, List<string> operations)
        {
            List<string> parsedResult = new List<string>();
            input = input.Trim();

        
            string firstNumber = input[0].ToString();
            string operation = "";
            string secondNumber = "";


            int operationIndex = 0;
           

            foreach (var c in operations)
            {
                if (input.IndexOf(c) != -1)
                {
                    operationIndex = input.Substring(1).IndexOf(c);
                    operationIndex++;
                    operation = input[operationIndex].ToString();
                    break; 
                }
            }

            firstNumber = input.Substring(0, operationIndex);
            secondNumber = input.Substring(operationIndex + 1);

            parsedResult.Add(firstNumber);
            parsedResult.Add(operation);
            parsedResult.Add(secondNumber);

            return parsedResult;
        }
    }
}
