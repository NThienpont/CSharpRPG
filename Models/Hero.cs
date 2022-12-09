namespace CSharpRPG.Models;

public class Hero : Person
{
    public string Pseudo { get; set; }

    public Hero(string pseudo,int live, string view, Weapon weapon) : base(live, view, weapon)
    {
        Pseudo = pseudo;
    }
}
