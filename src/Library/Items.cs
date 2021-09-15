using System;


namespace Program
{
    public class Items
    {
        public string Name {get; set;}

        public int Damage {get; set;}

        public int Defense {get; set;}

        public int RestorePoints {get; set;}

        public ArrayList Spells = new ArrayList();

        public Item(string name, int damage, int defense, int restorePoints, string[] spells = [])
        {
            this.Name = name;
            this.Damage = damage;
            this.Defense = defense;
            this.RestorePoints = restorePoints;
            this.Spells = spells;

        }
    }
}