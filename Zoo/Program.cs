namespace Zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Animal myAnimal1 = new Animal("Eeyore", 8, "Donkey", 120, "stubborn", "carrots", "hee-haw!", 16);
            Penguin myAnimal2 = new Penguin("Pingu", 5, "Penguin", 50, "cool as a fool", "fish", "honk!", 7, 8);
            Frog myAnimal3 = new Frog("Kermit", 6, "Frog", 8, "jumpy", "insects", "ribbit-ribbit", 16, "cats");
            Bear myAnimal4 = new Bear("Bobo", 13, "Bear", 250, "intelligent", "plants", "rooooaaar!!", 50, 40);


            Panda myAnimal5 = new Panda("Yin-yang", 20, "Great panda", 180, "kooky", "bamboo", "nee-ee-ee-eeeh", 22, 30, 14);
            Grizzly myAnimal6 = new Grizzly("Bonecrusher", 14, "Grizzly bear", 260, "aggressive", "everything bloody", "ROOOOOAAAAARRR!!!!", 45, 40, 180);
            


            myAnimal1.MakeSound();
            myAnimal2.MakeSound();
            myAnimal3.MakeSound();
            myAnimal4.MakeSound();
            myAnimal5.MakeSound();
            myAnimal6.MakeSound();
        }
    }
}