using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orcoids
{
    public class Doc : Orc
    {
        
        private int shizo;
        public int Heal(int pay)
        {
            
            if (rnd.Next(0, 100) > this.shizo) {
                return pay * 10;
            }
            else
            {
                return shizo * rnd.Next(-100, 100);
            }
        }
        public override string getdata()
        {
            return $"{this.Size}_{this.Weight}_{this.Zhubi}_{Shuta.name}_{Shuta.description}_{this.shizo}";
        }
        public override string Scream()
        {
            this.shizo = rnd.Next(0, 100);
            this.Hp += 20;
            return "WAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAGH";
        }
        public Doc(int shizo)
        {
            this.shizo = shizo;
            this.Size = 123;
            this.Name = "Зог";
            this.Zhubi = 123223;
            this.Weight = 120;
            this.Shuta = new Gun();
            this.classname = "doc";
        }
        public Doc(int shizo, int size, string name, int zhubi, int weight, Gun shuta)
        {
            this.shizo = shizo;
            this.Size = size;
            this.Name = name;
            this.Zhubi = zhubi;
            this.Weight = weight;
            this.Shuta = shuta;
            this.classname = "doc";
        }
        public Doc()
        {
            this.shizo = 78;
            this.Size = 123;
            this.Name = "Зог";
            this.Zhubi = 123223;
            this.Weight = 120;
            this.Shuta = new Gun();
            this.classname = "doc";
        }
    }
}
