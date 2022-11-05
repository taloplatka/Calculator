namespace Main.Validators
{
    public class DivisionByZeroValidator : IBinaryExerciseValidator
    {
        public bool IsValid(double firstArgument, string operation, double secondArgument)
        {
            return !(operation == "/") || !(secondArgument == 0);
        }
    }
}
