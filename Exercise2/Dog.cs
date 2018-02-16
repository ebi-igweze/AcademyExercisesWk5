namespace SecondExercise
{
    public class Dog
    {
        public string Name { private set;  get; }
        public decimal Weight { get; private set; }
        public Dog(string Name, decimal Weight)
        {
            this.Name = Name;
        }

        public override bool Equals(object obj)
        {
            if (obj is Dog) {
                var dogToCompare = obj as Dog;
                if (dogToCompare.Name == this.Name && dogToCompare.Weight == this.Weight) {
                    return true;
                } else {
                    return false;
                }
            } else {
                return false;
            }
        }
    }
}