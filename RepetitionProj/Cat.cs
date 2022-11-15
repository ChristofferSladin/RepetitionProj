using RepetitionProj;

class Cat : IAnimal
{
    

    public string Name { get; set; }
    public int AttackSpeed { get; set; }
    public int EscapeSpeed { get; set; }
    public bool Tail { get; set; }
    public AnimalType Type { get; set; }
    public void AttackPrey()
    {
        var time = new Timer();
        EscapeSpeed = 5;

        Console.WriteLine("CAT: Waits in grass");

        while (true)
        {
            Console.WriteLine("How long does CAT wait (sec)");
            var input = int.Parse(Console.ReadLine());

            var TTC = time.TimeBetweenAction(input); //Time To Catch

            if (TTC < EscapeSpeed)
            {
                Console.WriteLine("Prey caught");
            }
            else
                Console.WriteLine("Prey got away");
        }
        
    }
    public void EscapeFromPredator()
    {
        Console.WriteLine($"CAT Stands alone in grass");

        AttackPrey();

        Console.WriteLine("CAT Runs for its life");

    }
    public void CleanItSelf()
    {

    }
    public void Eating()
    {

    }



}


