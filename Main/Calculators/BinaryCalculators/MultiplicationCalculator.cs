

using Main.Calculators.Abstract;

namespace Main.Calculators.BinaryCalculators
{
    public class MultiplicationCalculator : BinaryCalculator
    {
        override
        public double Calculate(double x, double y)
        {
            return x * y;
        }
    }
}
