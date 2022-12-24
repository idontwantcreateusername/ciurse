using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orcoids
{
    public class Snotling : Orcoid
    {
        public Snotling() {
            this.Name = "growa";
            this.classname = "snotling";
        }
        public Snotling(string name) { 
            this.Name = name;
            this.classname = "snotling";
        }

        public int grow_the_mushrooms(int time)
        {
            return 10 * time;
        }

        public override string Scream()
        {
            return "weeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeep";
        }
        public void die()
        {
            Alive = false;
        }
    }
}
