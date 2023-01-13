namespace CSharpRPG.Models;

public class Weapon
{
    public string Name { get; private set; }
    public int Damage { get; private set; }

    public Weapon(string name, int damage)
    {
        Name = name;
        Damage = damage;
    }
    public Weapon(Weapon baseWeapon, bool isRusted)
    {
        Name = baseWeapon.Name;
        Damage = isRusted ? baseWeapon.Damage - 1 : baseWeapon.Damage;
    }
}
