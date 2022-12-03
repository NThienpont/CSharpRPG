// .gitignore
 using CSharpRPG.Models;

Person Hero = new Person ("Romain");

Hero.ViewLives();
Hero.WithdrawLives(5);
Hero.ViewLives();
Hero.AddLives(3);
Hero.ViewLives();

