using CSharpRPG.Utils;
namespace CSharpRPG.Models;

public static class MonsterList
{
    public static Monster Zombie => new Monster(RandomUtils.GetRandomBetween(9, 10), "🧟", WeaponList.Claw);
    public static Monster Skeleton => new Monster(RandomUtils.GetRandomBetween(8, 9),"💀", WeaponList.RustedSword);
    public static Monster Femme  => new Monster(RandomUtils.GetRandomBetween(9, 10),"♀", WeaponList.RustedSword);

}
