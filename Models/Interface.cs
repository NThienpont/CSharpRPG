namespace CSharpRPG.Models;

public class Interface
{
    public Hero Hero;
    public bool game;

    public Interface(Hero hero)
    {
        Hero = hero;
        game = true;
    }

    // Interface du haut du RPG, avec le nom, les HP, et les dégats d'arme du héros
    public void top()
    {
        Console.WriteLine("\n-----------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("           NOM :" + Hero.Pseudo + "                            HP : " + Hero.Life + "                                       DAMAGE : " + Hero.Weapon.Damage + "");
        Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
    }

    // Interface du bas avec les infos gameplay et les actions possibles pour le joueur
    public void bottom()
    {
        Console.WriteLine("\n-----------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("POUR VOUS DEPLACER SUR LA CARTE, UTILISEZ LES FLECHES DU ZQSD");
        Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
    }

    // Interface permettant de montrer les actions possibles en combat
    public void aideCombat()
    {
        Console.WriteLine("\n-----------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine(" 1 : ATTAQUE NORMALE                 2 : ATTAQUE VIOLENTE                3 : SOIN                4 : FUITE       ");
        Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
    }

    // Permet de clear la console par clarté, on utiliserait ca surtout pour le début de combat et la fin de combat
    public void clear()
    {
        Console.Clear();
    }
}