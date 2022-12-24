using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Orcoids
{
    public class Orc : Orcoid
    {
        protected int Size;
        protected int Zhubi;
        protected int Weight;
        protected Gun Shuta;
        

        public uint Pastuk(int hr)
        {
            uint res = (uint)(this.Shuta.might + (this.Shuta.range - hr) + (this.Size * 0.01) + this.Weight * 0.01);
            return res;
        }

        public override string getdata()
        {
            return $"{this.Size}_{this.Weight}_{this.Zhubi}_{Shuta.name}_{Shuta.description}";
        }
        public void damage(int dmg)
        {
            this.Hp = this.Hp - (dmg - (int) (this.Size * 0.001) - (int) (this.Weight * 0.001));
        } 
        public void purchase(int cost, Gun gun)
        {
            Random rnd = new Random();
            if (cost < this.Zhubi)
            {
                this.Shuta = gun;
            }
            else
            {
                
                this.Zhubi = 0;
                this.Shuta = new Gun("очень странная шута", "жубов хватило только на это...", rnd.Next(0, 10), rnd.Next(0, 10));

            }
        }
        public Orc(int size, string name, int zhubi, int weight, Gun shuta, int hp)
        {
            this.Alive = true;
            this.Hp = hp;
            this.Size = size;
            this.Name = name;
            this.Zhubi = zhubi;
            this.Weight = weight;
            this.Shuta = shuta;
            this.classname = "orc";
        }
        public Orc()
        {
            this.Alive = true;
            this.Hp = 100;
            this.Size = 3;
            this.Name = "Зог";
            this.Zhubi = 123223;
            this.Weight = 120;
            this.Shuta = new Gun();
            this.classname = "orc";

        }
        
    }

}
