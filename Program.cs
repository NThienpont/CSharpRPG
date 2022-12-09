// .gitignore
using CSharpRPG.Models;

Person Hero = new Person ("Romain");

Hero.ViewLives();
Hero.WithdrawLives(15);
Hero.ViewLives();
Hero.AddLives(20);
Hero.ViewLives();
