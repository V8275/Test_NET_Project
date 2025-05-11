namespace TestCode
{
    public class SumClass
    {
        static void Main(string[] args)
        {
            int[] numArray = { 1, 2, 3, 4, 5 };
            int result = 0;

            result = SumTwoMinimals(numArray);

            Console.WriteLine(result);
        }

        public static int SumTwoMinimals(int[] numbers)
        {
            if (numbers == null || numbers.Length < 2)
            {
                throw new ArgumentException("The array should contain at least 2 elements");
            }

            int firstMin = int.MaxValue;
            int secondMin = int.MaxValue;

            foreach (int num in numbers)
            {
                if (num < firstMin)
                {
                    secondMin = firstMin;
                    firstMin = num;
                }
                else if (num < secondMin)
                {
                    secondMin = num;
                }
            }

            return firstMin + secondMin;
        }
    }
}
