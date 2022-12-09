// .gitignore
using CSharpRPG.Models;

Hero Player = new Hero ("Romain",10,"😊",WeaponList.Sword);

Player.ViewLives();
Player.WithdrawLives(15);
Player.ViewLives();
Player.AddLives(20);
Player.ViewLives();
