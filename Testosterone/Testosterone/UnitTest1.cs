using ConsoleApp;
using Newtonsoft.Json.Linq;
using System.Globalization;

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
        [TestMethod]
        public void pocetvlozeniodpovidapoctuprvku()
        {
            FIFO tunel = new FIFO();
            tunel.Enqueue(1);
            tunel.Enqueue(2);
            tunel.Enqueue(3);

            Assert.AreEqual(3, tunel.Count(), "poèet prvkù v tunelu nesedí");
        }

        [TestMethod]
        public void prvnivlozenyjeprvniodebrany()
        {
            FIFO tunel = new FIFO();
            tunel.Enqueue(4);
            tunel.Enqueue(2);
            tunel.Enqueue(3);
            tunel.Enqueue(3);
            tunel.Enqueue(5);
            tunel.Enqueue(3);
            tunel.Enqueue(2);
            tunel.Enqueue(1);
            tunel.Enqueue(3);

            tunel.Dequeue();

            Assert.AreEqual(4, tunel.Dequeue(), "první odebraná není stejná jako první pøidaná");
        }

        [TestMethod]
        public void druhyvlozenyjedruhyodebrany()
        {
            FIFO tunel = new FIFO();
            tunel.Enqueue(4);
            tunel.Enqueue(2);
            tunel.Enqueue(3);
            tunel.Enqueue(3);
            tunel.Enqueue(5);
            tunel.Enqueue(3);
            tunel.Enqueue(2);
            tunel.Enqueue(1);
            tunel.Enqueue(3);

            Assert.AreEqual(4, tunel.Dequeue(), "první odebraná není stejná jako první pøidaná");
        }
    }
}