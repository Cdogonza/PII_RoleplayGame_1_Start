using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using System;

namespace Program
{


    public class ExampleTest
    {

        [Test]
        public void CharacterNameTest()
        {
            Items Martillo = new Items ("Martillo",2,0,0);
            List<Items> Inventory1 = new List<Items>();
            Inventory1.Add (Martillo);
            Character Sim = new Character ("Sim","Wizard",0,2,Inventory1);
            string expected = "Sim";

            Assert.AreEqual(Sim.Name,expected);
        }


         [Test]
        public void ItemNameTest()
        {
            Items Martillo = new Items ("Martillo",2,0,0);
            List<Items> Inventory1 = new List<Items>();
            Inventory1.Add (Martillo);
            Character Sim = new Character ("Sim","Wizard",0,2,Inventory1);
            string expected = "Martillo";

            Assert.AreEqual(expected,Martillo.Name);
        }

    }


}