
using Main.Calculators.Abstract;

namespace Main.Calculators.BinaryCalculators
{
    internal class DivisionCalculator : IBinaryCalculator
    {
        
        public double Calculate(double x, double y)
        {
            if (y == 0)
            {
                throw new ArgumentException("Cannot Divide By Zero");
            }

            return x / y;
        }
    }
}
