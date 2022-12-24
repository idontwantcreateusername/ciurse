using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Orcoids
{
    public class Grot : Orcoid
    {
        private int Size;
        private int Weight;
        private bool panic;
        public Grot() {
            this.Size = 1;
            this.Weight = 20;
            this.Name = "Grot";
            this.panic = false;
            this.Hp = 10;
            this.Alive = true;
            this.classname = "grot";
        }

        public Grot(int size, string name, int weight, int hp)
        {
            this.Size = size;
            this.Weight = weight;
            this.panic = false;
            this.Alive = true;
            this.Hp = hp;
            this.Name = name;
            this.classname = "grot";
        }

        public void afraid()
        {
            this.panic = true;
        }
        public bool check_panic()
        {
            return panic;
        }
        public uint Pastuk(int hr)
        {
            uint res = (uint)(this.Size * 0.1 + this.Weight * 0.1);
            return res;
        }
        public void damage(int dmg)
        {
            this.Hp -= dmg;

        }
        public override string getdata()
        {
            return $"{this.Size} {this.Weight} {this.panic} ";
        }
        public void runaway()
        {
            if (this.panic) { this.Alive = false; }
        }
    }

}
