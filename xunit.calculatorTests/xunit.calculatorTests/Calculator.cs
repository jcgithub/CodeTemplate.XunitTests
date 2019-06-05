using System;

namespace xunit.calculatorTests
{
    public class Calculator //
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Subtract(int x, int y)
        {
            return x - y;
        }

        private int AddThenSubtract(int x, int y)
        {
            return x + y - 1;
        }
    }
}
