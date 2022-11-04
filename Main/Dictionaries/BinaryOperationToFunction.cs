using Main.Calculators.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Dictionaries
{
    public class BinaryOperationToFunction 
    {
        private readonly Dictionary<string, BinaryCalculator> _BinaryOperationToFunction;

        public BinaryOperationToFunction()
        {
            _BinaryOperationToFunction = new Dictionary<string, BinaryCalculator>();

        }

        public BinaryCalculator Get(string input)
        {
            return _BinaryOperationToFunction[input];
        }

        public void Set(string input, BinaryCalculator binaryCalculator)
        {
            _BinaryOperationToFunction[input] = binaryCalculator;
        }

        public List<string> GetKeys()
        {
            return _BinaryOperationToFunction.Keys.ToList();
        }
        
    }
}
