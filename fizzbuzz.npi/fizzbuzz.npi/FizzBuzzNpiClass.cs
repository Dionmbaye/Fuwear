namespace fizzbuzz.npi
{
    public class FizzBuzzNpiClass
    {
        public string FizzBuzz(int input)
        {
            var isMultipleDe3 = input % 3 == 0;
            var isMultipleDe5 = input % 5 == 0;

            if (isMultipleDe3 && !isMultipleDe5)
            {
                return "Fizz";
            }
            else if (isMultipleDe5 && !isMultipleDe3)
            {
                return "Buzz";
            }
            else if (isMultipleDe3 && isMultipleDe5)
            {
                return "FizzBuzz";
            }
            else return input.ToString();
        }

    }
}
