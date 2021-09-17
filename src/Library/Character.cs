using System;
using System.Collections;
using System.Collections.Generic;


namespace Program
{
    public class Character
    {
        public string Race{get;set;}
        public string Name{get;set;}
        public int Defense{get;set;}
        public int LifePoint{get;set;}
        public int Damage{get;set;}
        
        public List<Items> ItemsList = new List<Items>();
      
        public Character (string name, string race, int defense, int damage, List <Items> itemslist, int lifepoint = 100)
        {
            if (race == "Elf" || race == "Wizard" || race == "Dwarf")
            {
                this.Race = race;
            }
            else
            {
                this.Race = "Human";
                Console.WriteLine($"Raza incorrecta. {name} ahora sos humano.");
            }
            this.Name = name;
            this.Defense = defense;
            this.LifePoint = lifepoint;
            this.Damage = damage;
            
            foreach (Items item in itemslist)
            {
                if ((item.Name != "SpellBook") || (item.Name == "SpellBook" && race == "Wizard"))
                {
                    this.ItemsList.Add(item);
                } 
                else
                {
                    Console.WriteLine("Solo los magos pueden tener libros de hechizos.");
                }
            }
        }

         public void Attack (Character victim)
        {
            int damageitem = 0;
            foreach (Items item in this.ItemsList)
            {
                damageitem += item.Damage;
                if (item.Spells != null)
                {
                    damageitem += item.Spells.Count;
                }
            }
            int defenseitem = 0;
            foreach (Items item in victim.ItemsList)
            {
                defenseitem += item.Defense;
            }
           
            victim.LifePoint -= (damageitem + this.Damage) - (defenseitem + victim.Defense);
            Console.WriteLine($"{victim.Name} te atacaron! Tu vida actual es: {victim.LifePoint}");
        }

        public int GetLifePoint()
        {
            return this.LifePoint;
        }

        public int GetDefensePoint()
        {
            return this.Defense;
        }

        public void AddItem(Items item)
        {
            if ((item.Name != "SpellBook") || (item.Name == "SpellBook" && this.Race == "Wizard"))
            {
                this.ItemsList.Add(item);
            } 
            else
            {
                Console.WriteLine("Solo los magos pueden tener libros de hechizos.");
            }
            this.ItemsList.Add(item);
        }
      
        public void RemoveItem(Items item)
        {
            this.ItemsList.Remove(item);
        }

        public void RemoveItem(Items item)
        {
            this.ItemsList.Remove(item);
        }

        public void Healing()
        {
            this.LifePoint = 100;
            Console.WriteLine($"{this.Name} te curaste! Tu vida actual es 100");
        }
    }   
}