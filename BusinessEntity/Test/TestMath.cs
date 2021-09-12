using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessEntity.Test
{
    public class TestMath : ITestMath
    {
        public int AddTwoNum(int a, int b)
        {
            return a + b;
        }
    }
}
