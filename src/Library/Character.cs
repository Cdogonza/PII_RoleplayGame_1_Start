using System;
using System.Collections;
using System.Collections.Generic;


namespace Program
{
    // Se creo la clase Character que tiene como responsabilidad la creacion de personajes del juego, conoces sus atributos y y metodos de este.
    //Recibe la colaboracion de la clase Items, que es la que conoce los items que los personajes pueden utilizar.
    //Contiene varios metodos para interactuar entre personajes asi como tambien manejar las propiedades de este.
    //Tuvimos en cuenta el patron  EXPERT en la definicion de la clase por los antes comentado.
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
            // En esta parte del constructor validamos que la raza del personaje sea dentro de las esperadas, de lo contrario se asigna una x
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
            
            //Aca validamos que solo los magos puedan ser creados con el libro de hechizos
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
            // Recorremos la lista de items para poder calcular el dano acorde a cada item con el que se ataca
            //Se agrega 1 de dano por cada hechizo que contenga el libro de hechizos
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
          //Aca validamos que solo a los magos se les pueda agregar el libro de hechizos como item   
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

        public void Healing()
        {
            this.LifePoint = 100;
            Console.WriteLine($"{this.Name} te curaste! Tu vida actual es 100");
        }
    }   
}