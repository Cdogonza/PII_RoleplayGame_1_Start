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
        
        [Test]
        public void CharRaceTest()
        {
            Items Hacha = new Items ("Hacha",35,0,0);
            List<Items> Inventory1 = new List<Items>();
            Inventory1.Add (Hacha);
            Character Zedunpax = new Character ("Zedunpax","Wizard",0,2,Inventory1);
            string expected = "Wizard";

            Assert.AreEqual(expected,Zedunpax.Race);
        }
        
        [Test]
        public void InventoryAddTest()
        {
            Items Zanpakuto = new Items ("Zanpakuto",35,0,0);
            List<Items> Inventory = new List<Items>();
            Inventory.Add (Zanpakuto);
            int expected = 1;
            
            Assert.AreEqual(expected,Inventory.Count);
        }

        [Test]
        public void HealingTest()
        {
            Items Zanpakuto = new Items ("Zanpakuto",35,0,0);
            List<Items> Inventory = new List<Items>();
            Inventory.Add (Zanpakuto);
            Character SubZero = new Character ("Sim","Wizard",0,2,Inventory,50);
            int expected = 100;
            SubZero.Healing();
            Assert.AreEqual(expected,SubZero.LifePoint);
        }

        [Test]
        public void AttackTest()
        {
            Items Martillo = new Items ("Martillo",2,0,0);
            List<Items> Inventory1 = new List<Items>();
            Inventory1.Add (Martillo);
            Character Sim = new Character ("Sim","Wizard",0,2,Inventory1);

            Items Lanza = new Items ("Lanza",4,0,0);
            List<Items> Inventory2 = new List<Items>();
            Inventory2.Add (Lanza);
            Character Belen = new Character ("Belen","Elf",3,0,Inventory2);

            Belen.Attack(Sim);
            int expected = 96;
            Assert.AreEqual(expected,Sim.LifePoint);
        }
        

    }


}