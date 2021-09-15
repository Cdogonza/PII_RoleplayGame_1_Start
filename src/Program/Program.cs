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
            List<Items> Inventor1 = new List<Items>();
            Inventor1.Add (Martillo);
            Character Sim = new Character ("Sim","Human",0,100,2,Inventor1);

            Items Lanza = new Items ("Lanza",4,0,0);
            List<Items> Invetory2 = new List<Items>();
            Invetory2.Add (Lanza);
            Character Belen = new Character ("Belen","Elf",3,100,0,Invetory2);

            Sim.Attack(Belen);

        }
    }
}
