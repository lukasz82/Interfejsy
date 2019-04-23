using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp1.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SprawdzanieInstancji()
        {
            SATA sata = new SATA();
            Assert.IsInstanceOfType(sata,typeof(IWtyczka));
        }

        [TestMethod]
        public void SprawdzaniePrzesylanychDanychPomiedzyDyskiemAPortem()
        {
            IWtyczka sata = new SATA();

            DyskHDD dysk = new DyskHDD(sata);

            string dane = "Jakieœ dane";
            dysk.WgrajDane(dane);

            Assert.AreEqual(dane,sata.PrzeslijDane());
        }

        [TestMethod]
        public void ZmianaPortuIPrzeslaniePonownieDanych()
        {
            IWtyczka sata = new SATA();
            IWtyczka usb = new USB();

            DyskHDD dysk = new DyskHDD(sata);

            string dane = "Jakieœ dane";
            dysk.WgrajDane(dane);
            dysk.PrzepnijPort(usb);
            dysk.WgrajDane(dane);

            Assert.AreEqual(dane,usb.PrzeslijDane());
        }

        [TestMethod]
        public void SprawdzenieCzyportJestPodlaczony()
        {
            IWtyczka sata = new SATA();

            Assert.AreEqual(true,sata.CzyPodlaczony());
        }
    }
}
