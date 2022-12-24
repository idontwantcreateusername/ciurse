using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orcoids
{
    public class Mech : Orc
    {
        private int Metall;
        public Mech(int metall, int size, string name, int zhubi, int weight, Gun shuta)
        {
            this.Metall = metall;
            this.Size = size;
            this.Name = name;
            this.Zhubi = zhubi;
            this.Weight = weight;
            this.Shuta = shuta;
            this.classname = "mech";
        }
        public override string getdata()
        {
            return $"{this.Size}_{this.Weight}_{this.Zhubi}_{Shuta.name}_{Shuta.description}_{this.Metall}";
        }
        public Mech(int metall)
        {
            this.Metall = metall;
            this.Size = 123;
            this.Name = "Зог";
            this.Zhubi = 123223;
            this.Weight = 120;
            this.Shuta = new Gun();
            this.classname = "mech";
        }
        public Mech()
        {
            this.Metall = 1000000;
            this.Size = 123;
            this.Name = "Зог";
            this.Zhubi = 123223;
            this.Weight = 120;
            this.Shuta = new Gun();
            this.classname = "mech";
        }
        public Gun craft(int metall)
        {
            return new Gun("Крафтовая пуляла", "сделано меком", 10 * metall, 30 * metall);
        }
    }
}
