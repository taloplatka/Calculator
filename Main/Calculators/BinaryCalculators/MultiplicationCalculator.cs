

using Main.Calculators.Abstract;

namespace Main.Calculators.BinaryCalculators
{
    public class MultiplicationCalculator : IBinaryCalculator
    {
        
        public double Calculate(double x, double y)
        {
            return x * y;
        }
    }
}
