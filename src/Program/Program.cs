using System;
using System.Collections;
using System.Collections.Generic;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Items Martillo = new Items ("Martillo",2,0,0);
            List<Items> Inventory1 = new List<Items>();
            Inventory1.Add (Martillo);
            Character Sim = new Character ("Sim","Wizard",0,2,Inventory1);

            Items Lanza = new Items ("Lanza",4,0,0);
            List<Items> Inventory2 = new List<Items>();
            Inventory2.Add (Lanza);
            Character Belen = new Character ("Belen","caca",3,0,Inventory2);

            ArrayList SpellList = new ArrayList{"Galletita","Manzana venenosa","Cuchara"};
            Items SpellBook = new Items ("SpellBook",0,0,2,SpellList);

            Sim.AddItem(SpellBook);
            Sim.Attack(Belen);
            Belen.Attack(Sim);
            Sim.RemoveItem(Martillo);
            Sim.Attack(Belen);
        }
    }
}