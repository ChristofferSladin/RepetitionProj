using RepetitionProj;

interface IAnimal
{
    public string Name { get; set; }
    public int AttackSpeed { get; set; }
    public int EscapeSpeed { get; set; }
    public bool Tail { get; set; }
    public AnimalType Type { get; set; }
    void AttackPrey();
    void EscapeFromPredator();
    void CleanItSelf();
    void Eating();

}
