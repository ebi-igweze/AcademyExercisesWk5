namespace AnimalKingdom
{
    public class Cat : Animal
    {
        public Cat(string Name, decimal Weight)  {
            this.Name = Name;
            this.Weight = Weight;
        }

        public override void Move()
        {
            System.Console.WriteLine("I have started moving, my 'Cat' paws one at a time.");
        }

        public override string ToString()
        {
            return $"My name is {this.Name} and I am a cat weighing {this.Weight}kg.";
        }

        public override void Speak()
        {
            System.Console.WriteLine("Meoooww!!");

        }
    }
}