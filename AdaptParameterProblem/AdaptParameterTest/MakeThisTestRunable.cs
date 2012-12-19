using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdaptParameter;

namespace AdaptParameterTest
{
    [TestClass]
    public class MakeThisTestRunable
    {
        [TestMethod]
        public void TestReturn1()
        {
            var sut = new ClassNeedTest();

            Assert.AreEqual(1, sut.MethodNeedTesting(new ReadOnlyObject()));
        }
    }
}
