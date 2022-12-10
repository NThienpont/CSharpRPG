// .gitignore
using CSharpRPG.Models;

Hero Player = new Hero("Romain", 10, "☺", WeaponList.Sword);
Monster Zombie = MonsterList.Zombie;
Monster Zombie2 = MonsterList.Zombie;
Monster Skeleton = MonsterList.Skeleton;

Player.ViewLives();
Player.WithdrawLives(15);
Player.ViewLives();
Player.AddLives(20);
Player.ViewLives();
Console.WriteLine(Player);
