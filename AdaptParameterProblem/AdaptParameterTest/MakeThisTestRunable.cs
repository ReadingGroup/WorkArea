using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdaptParameter;
using Moq;

namespace AdaptParameterTest
{
    [TestClass]
    public class MakeThisTestRunable
    {
        [TestMethod]
        public void TestReturn1()
        {
            var sut = new ClassNeedTest();

            var mock = new Mock<IReadOnlyInterface>();

            mock.Setup(foo => foo.Return1()).Returns(1);

            Assert.AreEqual(1, sut.MethodNeedTesting(mock.Object));
        }
    }
}
