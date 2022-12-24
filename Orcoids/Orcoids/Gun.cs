using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orcoids
{
    public class Gun : Object
    {
        public string name;
        public string description;
        public int might;
        public int range;

        
        public Gun() {
            this.name = "Пуляла";
            this.description = "Скафченая меком пуляла, шутает сквигами";
            this.range = 90;
            this.might = 10; 
        }
        public Gun(string name, string description, int might, int range)
        {
            this.name = name;
            this.description = description;
            this.might = might;
            this.range = range;
        }

    }
}
