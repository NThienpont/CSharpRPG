﻿// .gitignore
using CSharpRPG.Models;

Hero Player = new Hero("Romain", 10, "", WeaponList.Sword);


Player.ViewLifes();
Player.WithdrawLifes(15);
Player.ViewLifes();
Player.AddLifes(20);
Player.ViewLifes();
Console.WriteLine(Player);
//test