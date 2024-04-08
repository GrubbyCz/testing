namespace Testosterone
{
    [TestClass]
    public class UnitTest1 
    {
      [TestMethod]
      public void tuneljeprazdny()
        {
            Tunel tunel = new Tunel();

            Assert.AreEqual(0, Tunel.Count(), "Vytvoøený zásobník není prázdný.");
        }
    }
}
