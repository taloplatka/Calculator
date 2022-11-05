//CR: remove newline here
namespace Main.Parsers
{
    //CR: public and not internal class
    public class BinaryParser
    {
        private readonly List<char> _operations;

        public BinaryParser(List<char> _operations)
        {
            this._operations = _operations;
        }

        public List<ParsedItem> Parse(string input)
        {
            var parsedResult = new List<ParsedItem>();
            input = input.Trim();

            int operationIndex = 0;
           
            foreach (var operation in _operations)
            {
                if (input.IndexOf(operation) != -1)
                {
                    operationIndex = input.Substring(1).IndexOf(operation);
                    operationIndex++;
                    break; 
                }
            }

            string firstNumber = input.Substring(0, operationIndex);
            string secondNumber = input.Substring(operationIndex + 1);

            parsedResult.Add(new ParsedItem(firstNumber));
            parsedResult.Add(new ParsedItem(input[operationIndex].ToString()));
            parsedResult.Add(new ParsedItem(secondNumber));

            return parsedResult;
        }
    }
}
