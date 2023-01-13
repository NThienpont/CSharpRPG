namespace CSharpRPG.Models;

public class Hero : Person
{
    public string Pseudo { get; set; }

    public Hero(string pseudo,int life, string view, Weapon weapon) : base(life, view, weapon)
    {
        Pseudo = pseudo;
    }
}
