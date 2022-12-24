using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orcoids
{
    public class Pilot : Orc
    {
        private int fuel;
        private int enough;

        

        public int recharge(int payed)
        {
            return this.enough * payed;
        }
        public string fly()
        {
            if(fuel > this.enough)
            {
                return "полет прошел успешно";
            }
            else
            {
                this.Alive = false;
                return "вы разбилтсь";
            }
        }
        public override string getdata()
        {
            return $"{this.Size}_{this.Weight}_{this.Zhubi}_{Shuta.name}_{Shuta.description}_{this.fuel}_{enough}";
        }
        public Pilot(int fuel, int enough)
        {
            this.fuel = fuel;
            this.enough = enough;
            this.Size = 123;
            this.Name = "Зог";
            this.Zhubi = 123223;
            this.Weight = 120;
            this.Shuta = new Gun();
            this.classname = "pilot";
        }
        public Pilot(int fuel, int enough, int size, string name, int zhubi, int weight, Gun shuta) {
            this.fuel = fuel;
            this.enough = enough;
            this.Size = size;
            this.Name = name;
            this.Zhubi = zhubi;
            this.Weight = weight;
            this.Shuta = shuta;
            this.classname = "pilot";
        }
        public Pilot()
        {
            this.fuel = 40;
            this.enough = 10;
            this.Size = 123;
            this.Name = "Зог";
            this.Zhubi = 123223;
            this.Weight = 120;
            this.Shuta = new Gun();
            this.classname = "pilot";
        }
    }
}
