using System;
using Jenkins_TEST2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest_Jenkins
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1_Toplama()
        {
            Islemler islemler = new Islemler();
            double sonuc = islemler.Addition(15, 12);
            Assert.AreEqual(sonuc, 27);
        }

        [TestMethod]
        public void TestMethod1_Cikarma()
        {
            Islemler islemler = new Islemler();
            double sonuc = islemler.Extraction(15, 12);
            Assert.AreEqual(sonuc, 3);
        }

        [TestMethod]
        public void TestMethod3_Çarpma()
        {
            Islemler islemler = new Islemler();
            double sonuc = islemler.Multiplication(15, 12);
            Assert.AreEqual(sonuc, 180);
        }

        [TestMethod]
        public void TestMethod1_Bolme()
        {
            Islemler islemler = new Islemler();
            double sonuc = islemler.Division(15, 5);
            Assert.AreEqual(sonuc, 3);
        }
    }
}
