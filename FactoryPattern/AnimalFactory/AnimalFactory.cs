namespace AnimalFactory
{
    public class AnimalFactory
    {
        public static AnimalInterface CreateAnimal(string species)
        {
            if (species == "human") return new Human();
            if (species == "monkey") return new Monkey();
            return new Pig();
        }
    }
}