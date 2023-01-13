using CSharpRPG.Utils;
namespace CSharpRPG.Models

{
    public class Map
    {
        public Map()
        {
            List<Monster> MonsterList = new List<Monster>();
            MonsterList.Add(new Monster(RandomUtils.GetRandomBetween(9, 10), "🧟", WeaponList.Claw));
            MonsterList.Add(new Monster(RandomUtils.GetRandomBetween(8, 9), "💀", WeaponList.RustedSword));
            MonsterList.Add(new Monster(RandomUtils.GetRandomBetween(9, 10), "👩", WeaponList.RustedSword));
        }
    }
}