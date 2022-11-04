using Main.Calculators.Abstract;


namespace Main.Calculators.BinaryCalculators
{
    public class SubtractionCalculator : BinaryCalculator
    {
        override
        public double Calculate(double x, double y)
        {
            return x - y;
        }
    }
}
