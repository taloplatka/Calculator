namespace Main.Validators
{
    public interface IBinaryExerciseValidator
    {
        public bool IsValid(double firstArgument, string operation, double secondArgument);
    }
}
