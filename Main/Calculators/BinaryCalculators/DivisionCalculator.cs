
using Main.Calculators.Abstract;

namespace Main.Calculators.BinaryCalculators
{
    internal class DivisionCalculator : BinaryCalculator
    {
        override
        public double Calculate(double x, double y)
        {
            if (y == 0)
            {
                throw new ArgumentException("Cannot Divie By Zero");
            }
            return x / y;
        }
    }
}
