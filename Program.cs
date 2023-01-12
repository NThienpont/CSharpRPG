// .gitignore
using CSharpRPG.Models;

bool fightingStatus = true;
Hero Player = new Hero ("Romain",10,"🤴", WeaponList.MasterSword);
Monster Monstre = new Monster(5,"",WeaponList.Claw);

/*
Player.ViewLifes();
Player.WithdrawLifes(15);
Player.ViewLifes();
Player.AddLifes(20);
Player.ViewLifes();
Console.WriteLine(Player);*/

// Test interface + map

Interface interface1 = new Interface(Player);
interface1.top();

Matrix Matrix1 = new Matrix();
Matrix1.ViewMap(Player);

interface1.bottom();
interface1.aideCombat();

// Test des options de combat

Fight fight1 = new Fight(Player, Monstre);
fight1.violentAttack();
fight1.attack();
fight1.heal();
fight1.escape();


// Permettrait de voir si un combat est en cours et changer l'interface en fonction, je dois encore réfléchir exactement comment

Console.WriteLine(fightingStatus);
