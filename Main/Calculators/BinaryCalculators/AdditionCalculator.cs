using Main.Calculators.Abstract;


namespace Main.Calculators.BinaryCalculators
{
    public class AdditionCalculator : BinaryCalculator
    {
        override
        public double Calculate(double x, double y)
        {
            return x + y;
        }
    }
}
