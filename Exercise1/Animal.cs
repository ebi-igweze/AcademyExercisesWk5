namespace AnimalKingdom
{
    public abstract class Animal 
    {
        protected string Name { get; set; }
        protected decimal Weight { get; set;  }
        
        public abstract void Speak();
        public abstract void Move();
        public new abstract string ToString();
    }
}