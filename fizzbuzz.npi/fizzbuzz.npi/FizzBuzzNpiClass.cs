namespace fizzbuzz.npi
{
    public class FizzBuzzNpiClass
    {
        public string ComputeFizzBuzz(int input)
        {
            var isMultipleOf3 = input % 3 == 0;
            var isMultipleOf5 = input % 5 == 0;

            if (isMultipleOf3 && !isMultipleOf5)
            {
                return "Fizz";
            }
            else if (isMultipleOf5 && !isMultipleOf3)
            {
                return "Buzz";
            }
            else if (isMultipleOf3 && isMultipleOf5)
            {
                return "FizzBuzz";
            }
            else return input.ToString();
        }

        public int ComputeNpi(string text)
        {
            if (text.Trim().Length == 1)
            {
                return Convert.ToInt32(text.Trim());
            }
            List<string> splitedText;
            List<int> splitedValues;
            List<string> splitedOperators;
            var result = 0;
            var value = 0;

            splitedText = new List<string>();
            splitedValues = new List<int>();
            splitedOperators = new List<string>();
            splitedText = text.Split(" ").ToList();

            foreach (var i in splitedText)
            {
                var isValue = int.TryParse(i, out value);
                if (isValue)
                {
                    splitedValues.Add(value);
                }
                else
                {
                    splitedOperators.Add(i);
                }
            }


            var y = splitedValues.Count() - 1;

            for (var x = 0; x < splitedOperators.Count(); x++)
            {
                if (splitedOperators[x] == "+")
                {
                    result = result == 0 ? splitedValues[y] + splitedValues[y - 1] : result + splitedValues[y - 1];
                    y = y - 1;
                }
                else if (splitedOperators[x] == "x")
                {
                    result = result == 0 ? splitedValues[y] * splitedValues[y - 1] : result * splitedValues[y - 1];
                    y = y - 1;
                }

            }
            return result;
        }
    }
}