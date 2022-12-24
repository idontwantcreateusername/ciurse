using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orcoids
{
    public class Weirdboy : Orc
    {private int menthal;
        private int dmg;
        

        public int attack()
        {
            if(menthal > rnd.Next(0, 100))
            {
                this.menthal -= rnd.Next(0, 10);
                return dmg * rnd.Next(0, 10);
                
            }
            else
            {
                this.Alive = false;
                return dmg * -1;
            }
            
        }
        public override string Scream()
        {
            this.menthal += 12;
            this.Hp += 20;    
            return "WAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAGH";
        }



        public Weirdboy(int menthal, int dmg, int size, string name, int zhubi, int weight, Gun shuta)
        {
            this.menthal = menthal;
            this.dmg = dmg;
            this.Size = size;
            this.Name = name;
            this.Zhubi = zhubi;
            this.Weight = weight;
            this.Shuta = shuta;
            this.classname = "weird";
        }
        public Weirdboy(int menthal, int dmg)
        {
            this.menthal = menthal;
            this.dmg = dmg;
            
            this.Size = 123;
            this.Name = "Зог";
            this.Zhubi = 123223;
            this.Weight = 120;
            this.Shuta = new Gun();
            this.classname = "weird";
        }
        public override string getdata()
        {
            return $"{this.Size}_{this.Weight}_{this.Zhubi}_{Shuta.name}_{Shuta.description}_{this.menthal}";
        }
        public Weirdboy() 
        {
            this.menthal = 70;
            this.dmg = 10;
           
            this.Size = 123;
            this.Name = "Зог";
            this.Zhubi = 123223;
            this.Weight = 120;
            this.Shuta = new Gun();
            this.classname = "weird";
        }
    }
}
