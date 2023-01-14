// .gitignore
using CSharpRPG.Models;

Console.Clear();
Console.WriteLine("Bienvenue dans ce RPG codé en CSharp ! Veuillez entrer le nom de votre personnage !");
var name = Console.ReadLine();

if (name == "")
{
    name = "Romain";
}

Hero Player = new Hero(name, 100, "🤴", WeaponList.MasterSword);
Monster Monstre = new Monster(50, "", WeaponList.Claw);

System.Console.WriteLine("Vous êtes un héros nommé " + Player.Pseudo + ". Vous venez d'arriver dans un donjon et la porte s'est fermée derrière vous. Votre objectif est donc d'atteindre la sortie du donjon en survivant aux pièges et monstres sur votre chemin... \nArriverez-vous " + Player.Pseudo + ", à relever le défi? \n");
System.Console.WriteLine("Appuyez sur une touche pour commencer !");
System.Console.ReadKey();

// Initialisation des variables et objets nécessaires.
Interface interface1 = new Interface(Player);
Matrix matrix1 = new Matrix();
interface1.clear();

// Mise en place de l'interface matrix.
interface1.top();
matrix1.ViewMap(Player);
interface1.bottom();

// Initialisation de la boucle de jeu et des variables de suivi.
while (matrix1.game)
{
    var adventureChoice = Console.ReadLine();
    Fight fight1 = new Fight(Player, Monstre);

    // Gestion des combats en fonction de l'état de la variable booléenne "fightingstatus".
    if (matrix1.fightingStatus == true)
    {
        interface1.clear();
        interface1.top();
        interface1.aideCombat();
        if (adventureChoice == "1")
        {
            interface1.clear();
            interface1.top();
            interface1.aideCombat();
            fight1.attack();
            fight1.monsterAction();
        }
        else if (adventureChoice == "2")
        {
            interface1.clear();
            interface1.top();
            interface1.aideCombat();
            fight1.violentAttack();
            fight1.monsterAction();
        }
        else if (adventureChoice == "3")
        {
            interface1.clear();
            interface1.top();
            interface1.aideCombat();
            fight1.heal();
            fight1.monsterAction();
        }
        else if (adventureChoice == "4")
        {
            interface1.clear();
            interface1.top();
            interface1.aideCombat();
            fight1.escape();
        }
        else
        {
            Console.WriteLine("Vous êtes en combat ! Vous devez utiliser les commandes de combat.");
        }
        if (fight1.Monster.Life <= 0)
        {
            Console.WriteLine("Vous avez tué le monstre!");
            System.Console.WriteLine("Pour continuer, appuyer sur une touche");
            Console.ReadLine();
            matrix1.fightingStatus = false;
            Console.Clear();
            interface1.top();
            matrix1.ViewMap(Player);
            interface1.bottom();
        }
    }

    // Gestion de l'interface et du déplacement sur la map pour le joueur.
    else
    {
        if (adventureChoice == "z" || adventureChoice == "q" || adventureChoice == "s" || adventureChoice == "d")
        {
            interface1.clear();
            interface1.top();
            matrix1.ViewMap(Player);
            interface1.bottom();

            matrix1.Move(adventureChoice);
            Console.ReadLine();
            interface1.clear();
            interface1.top();
            matrix1.ViewMap(Player);
            interface1.bottom();
        }
        else
        {
            Console.WriteLine("Vous êtes sur la carte, vous devez vous déplacer avec les touches ZQSD.");
        }
    }
}

Console.Clear();

if (interface1.Hero.Life == 0)
{
    Console.WriteLine("Vous avez perdu ! Vous êtes mort...");
}
else
{
    Console.WriteLine("Vous avez gagné " + Player.Pseudo + ", Bravo ! :D Merci d'avoir joué.");
}