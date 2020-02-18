using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentuDienynasLB;
using System.Collections.Generic;

namespace StudentuDienynas.test
{
    [TestClass]
    public class PamokaTests
    {
        [TestMethod]
        public void TurimeGrazintiTiekPazymiuKiekPridejome()
        {
            //Assign
            Pamoka pamoka = new Pamoka(1, "Matematika");
            //Act
            pamoka.PridetiPazymi(1, 5);
            List<int> pirmoTrimestroPazymiai = pamoka.GrazintiTrimestroPazymius(1);
            //Assert
            Assert.AreEqual(pirmoTrimestroPazymiai.Count, 1);
            Assert.AreEqual(pirmoTrimestroPazymiai[0], 5);
        }

        [TestMethod]
        public void PirmoTrimestroVidurkisTuriButi9()
        {
            //Assign
            Pamoka pamoka = new Pamoka(1, "Matematika");
            //Act
            pamoka.PridetiPazymi(1, 8);
            pamoka.PridetiPazymi(1, 9);
            pamoka.PridetiPazymi(1, 10);
            int pirmoTrimestroVidurkis = pamoka.PirmoTrimestroVidurkis();
            //Assert
            Assert.AreEqual(pirmoTrimestroVidurkis, 9);
        }
        [TestMethod]
        public void NegalimaPridetiNeteisingoPazymio()
        {
            //Assign
            Pamoka pamoka = new Pamoka(1, "Matematika");
            //Act
            pamoka.PridetiPazymi(1, -8);
            int pirmoTrimestroVidurkis = pamoka.PirmoTrimestroVidurkis();
            List<int> pirmoTrimestroPazymiai = pamoka.GrazintiTrimestroPazymius(1);
            //Assert
            Assert.AreEqual(pirmoTrimestroPazymiai.Count, 0);
            Assert.AreEqual(pirmoTrimestroVidurkis, 0);
        }
        [TestMethod]
        public void AntroTrimestroVidurkisTuriButi10()
        {
            //Assign
            Pamoka pamoka = new Pamoka(1, "Matematika");
            //Act
            pamoka.PridetiPazymi(2, 10);
            pamoka.PridetiPazymi(2, 10);
            pamoka.PridetiPazymi(2, 10);
            int antroTrimestroVidurkis = pamoka.AntroTrimestroVidurkis();
            //Assert
            Assert.AreEqual(antroTrimestroVidurkis, 10);
        }
    }
}
