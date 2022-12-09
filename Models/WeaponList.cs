namespace CSharpRPG.Models;

public static class WeaponList
{
    public static Weapon MasterSword => new Weapon("épée du hero", 9);
    public static Weapon Sword => new Weapon("épée", GetRandomDamage(2, 3));
    public static Weapon Spear => new Weapon("lance", GetRandomDamage(2, 4));
    public static Weapon Claw => new Weapon("griffe", GetRandomDamage(1, 2));
    public static Weapon RustedSword => new Weapon(Sword, true);

    public static int GetRandomDamage(int min, int max)
    {
        Random number = new Random();
        return number.Next(min, max);
    }
}
