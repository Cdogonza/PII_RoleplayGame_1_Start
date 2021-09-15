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
        
        public Character (string name, string race, int defense, int lifepoint, int damage, List <Items> itemslist)
        {
            this.Race = race;
            this.Name = name;
            this.Defense = defense;
            this.LifePoint = lifepoint;
            this.Damage = damage;
            this.ItemsList = itemslist;
 
        }

        public int Attack (Character victim)
        {
            int damageitem = 0;
            foreach (Items item in this.ItemsList)
            {
                damageitem += item.Damage;
            }
            int defenseitem = 0;
            foreach (Items item in victim.ItemsList)
            {
                defenseitem += item.Defense;
            }           
            victim.LifePoint -= (damageitem + this.Damage) - (defenseitem + victim.Defense);
            return victim.LifePoint;
        }





    }






}