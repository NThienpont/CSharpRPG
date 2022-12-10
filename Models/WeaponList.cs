using CSharpRPG.Utils;

namespace CSharpRPG.Models;

public static class WeaponList
{
    public static Weapon MasterSword => new Weapon("épée du hero", 9);
    public static Weapon Sword => new Weapon("épée", RandomUtils.GetRandomBetween(2, 3));
    public static Weapon Spear => new Weapon("lance", RandomUtils.GetRandomBetween(2, 4));
    public static Weapon Claw => new Weapon("griffe", RandomUtils.GetRandomBetween(1, 2));
    public static Weapon stove=> new Weapon("Poêle", RandomUtils.GetRandomBetween(3, 5));
    public static Weapon RustedSword => new Weapon(Sword, true);

}
