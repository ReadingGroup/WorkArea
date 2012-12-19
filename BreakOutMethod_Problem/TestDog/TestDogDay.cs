using BreakOutMethod;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestDog
{
    [TestClass]
    public class TestDogDay
    {
        [TestMethod]
        public void TestDogDiary()
        {
            //cannot new abstract class, but want to test method: "NeedTestMethod_DogDay"
            var dog = new Dog();  

            string expectedDiary = "WakeUpEatFoodDrinkWaterPlayBallSleep";

            Assert.AreEqual(expectedDiary, dog.NeedTestMethod_DogDay());

        }
    }
}
