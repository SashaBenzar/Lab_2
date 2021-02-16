using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int n = 3;
            int[] a = { 1, 2, 3 };
            float result = Lab2_3a.Program.Sum_el(a,n);
            Assert.AreEqual(4, result);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int n = 3;
            int[] a = { -1, 2, -3 };
            float result = Lab2_3a.Program.Dob_el(a, n);
            Assert.AreEqual(2, result);
        }
    }
}
