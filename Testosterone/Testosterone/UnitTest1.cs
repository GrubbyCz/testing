using ConsoleApp;

namespace Testosterone
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void tuneljeprazdny()
        {
            FIFO tunel = new FIFO();

            Assert.AreEqual(0, tunel.Count(), "tunel není prázdný");

        }
    }
}