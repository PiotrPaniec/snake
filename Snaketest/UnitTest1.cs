using Microsoft.VisualStudio.TestTools.UnitTesting;
using Snake;
namespace Snaketest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SprawdzenieTest()
        {
            string login = "kuba";
            string haslo = "haslo";
                odczyt test = new odczyt(login, haslo);
            bool czyzalogowano = test.sprawdzanie();
            Assert.AreEqual(false, czyzalogowano,"nie uda³o sie");
        }
    }
}
