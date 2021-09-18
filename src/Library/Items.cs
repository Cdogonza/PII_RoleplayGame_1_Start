using System;
using System.Collections;

namespace Program
{
//Esta clase se crean los item de los personajes 
    public class Items
    {
        public string Name {get; set;}

        public int Damage {get; set;}

        public int Defense {get; set;}

        public int RestorePoints {get; set;}

        public ArrayList Spells = new ArrayList();

        public Items(string name, int damage, int defense, int restorePoints, ArrayList spells = null)
        {
            this.Name = name;
            this.Damage = damage;
            this.Defense = defense;
            this.RestorePoints = restorePoints;
// En el caso de que el item sea Spellbook se le permite cargar los hechizos
            if (name == "SpellBook")
            {
                this.Spells = spells;
            }
        }
    }
}