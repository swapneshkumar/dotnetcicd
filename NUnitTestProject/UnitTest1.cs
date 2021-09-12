using BusinessEntity.Test;
using NUnit.Framework;

namespace NUnitTestProject
{
    public class Tests
    {
        TestMath obj;
        [SetUp]
        public void Setup()
        {
            obj = new TestMath();
        }

        [Test]
        public void Test1()
        {

            Assert.AreEqual(5, obj.AddTwoNum(3, 2));
        }
    }
}