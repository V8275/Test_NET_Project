namespace TestCode
{
    using System;
    using Xunit;

    public class SumTwoMinimalsTests
    {
        [Fact]
        public void TestNormalCase()
        {
            int[] numbers = { 4, 0, 3, 19, 492, -10, 1 };
            int result = SumClass.SumTwoMinimals(numbers);
            Assert.Equal(-10, result);
        }

        [Fact]
        public void TestEmptyArray()
        {
            int[] numbers = Array.Empty<int>();
            Assert.Throws<ArgumentException>(() => SumClass.SumTwoMinimals(numbers));
        }

        [Fact]
        public void TestSingleElementArray()
        {
            int[] numbers = { 5 };
            Assert.Throws<ArgumentException>(() => SumClass.SumTwoMinimals(numbers));
        }

        [Fact]
        public void TestLargeArray()
        {
            int[] numbers = new int[1000000];
            var random = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1000, 1000000);
            }

            numbers[random.Next(1, 50000)] = -100;
            numbers[random.Next(50001, 1000000)] = -50;

            int result = SumClass.SumTwoMinimals(numbers);
            Assert.Equal(-150, result);
        }

        [Fact]
        public void TestAllSameElements()
        {
            int[] numbers = { 7, 7, 7, 7, 7 };
            int result = SumClass.SumTwoMinimals(numbers);
            Assert.Equal(14, result);
        }
    }
}