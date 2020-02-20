using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentuDienynasLB;

namespace StudentuDienynas.test
{
    [TestClass]
    public class StudentasTests
    {
        [TestMethod]
        public void StudentuiGalimePridetiPamoka()
        {

            //Assign
            Studentas studentas = new Studentas(1, "Martynas", "Martynaitis");
            //Act
            studentas.PridetiNaujaPamoka("Matieka");
            studentas.PridetiPazymi("Matieka", 1, 5);
            //Assert
            Assert.AreEqual(studentas.Pamokos().Count, 1);
            int pirmoTrimestroVidurkis = studentas.GrazintiPamokaPagalPavadinima("Matieka").PirmoTrimestroVidurkis();
            Assert.AreEqual(pirmoTrimestroVidurkis, 5);

        }
        [TestMethod]
        public void StudentuiGalimeIstrintiPazymi()
        {

            //Assign
            Studentas studentas = new Studentas(1, "Martynas", "Martynaitis");
            //Act
            studentas.PridetiNaujaPamoka("Matieka");
            studentas.PridetiPazymi("Matieka", 1, 5);
            Pamoka pamoka = studentas.GrazintiPamokaPagalPavadinima("Matieka");
            pamoka.IstrintiPazymi(1, 1);
            //Assert
            Assert.AreEqual(pamoka.PirmoTrimestroVidurkis(), 0);

        }
        [TestMethod]
        public void StudentuiGalimeIstrintinNesamaPazymi()
        {

            //Assign
            Studentas studentas = new Studentas(1, "Martynas", "Martynaitis");
            //Act
            studentas.PridetiNaujaPamoka("Matieka");
            studentas.PridetiPazymi("Matieka", 1, 5);
            Pamoka pamoka = studentas.GrazintiPamokaPagalPavadinima("Matieka");
            pamoka.IstrintiPazymi(1, 10);
            //Assert
            Assert.AreEqual(pamoka.PirmoTrimestroVidurkis(), 5);

        }

    }
}
