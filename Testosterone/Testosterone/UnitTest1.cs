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
        [TestMethod]
        public void tunelpovlozeniprvkuneniprazdny()
        {
            FIFO tunel = new FIFO();
            tunel.Enqueue(2);
            Assert.AreNotEqual(0, tunel.Count(), "Tunel je prázdný");
        }
    }
}