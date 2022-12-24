namespace Orcoids
{
    public class Orcoid : Object
    {
        protected bool Alive;
        protected int Hp;
        protected string Name;
        protected string classname = "zero";
        protected Random rnd = new Random();

        public virtual string Scream()
        {
            this.Hp += 10;
            return "WAAAAAAAAAAAAAAAGH";
        }

        public int HP_Status()
        {
            return this.Hp;
        }
        public virtual string getdata()
        {
            return " ";
        }
        public string Name_yourself()
        {
            return this.Name;
        }
        public string getclass()
        {
            return this.classname;
        }

        public Orcoid() 
        {
            this.Hp = 10;
            this.Name = "mashroom";
            this.Alive= true;   
        }

        public Orcoid(int hp, string name)
        {
            this.Alive = true;
            this.Hp = hp;
            this.Name = name;
        }
    }
}