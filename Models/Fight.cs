namespace CSharpRPG.Models;
using CSharpRPG.Utils;


// Objet permettant d'initialiser un combat et toutes les features utilisables en combat.//
public class Fight{

    public Hero Hero{get; set;}
    public Monster Monster{get;set;}

    public Fight(Hero hero, Monster monster){
        Hero = hero;
        Monster = monster;
    }
// Attaque simple, permettant attaquant d'un montant égal aux dégats de l'arme du héros//
    public void attack(){
        Monster.WithdrawLifes(Hero.Weapon.Damage);
        Console.WriteLine("L'attaque a infligé " + Hero.Weapon.Damage + " dégat(s); au monstre !");
    }

// Attaque violente, a 1/4 chance de rater, mais inflige le double des dégats
    public void violentAttack(){
        int chance = Utils.RandomUtils.GetRandomBetween(1,4);
        if(chance==1){
            Console.WriteLine("Attaque ratée !");
        }
        else{
        Monster.WithdrawLifes(Hero.Weapon.Damage*2);
        Console.WriteLine("COUP CRITIQUE ! L'attaque a infligé " + Hero.Weapon.Damage*2 + " dégat(s); au monstre !");
        }
    }
// Permet au joueur de se soigner d'un montant égal à un nombre entre 3 et 6//
    public void heal(){
        int soin = Utils.RandomUtils.GetRandomBetween(3,6);
        Hero.AddLifes(soin);
        Console.WriteLine("Vous avez été soigné de " + soin + " point(s) de vie.");
    }
// Permet de fuir un combat, a 1/4 chance de rater//
    public void escape(){ 
        int fuite = Utils.RandomUtils.GetRandomBetween(1,4);
        if(fuite==1){
            Console.WriteLine("Le monstre vous rattrape !");
        }
        else{
        Monster.WithdrawLifes(Hero.Weapon.Damage*2);
        Console.WriteLine("Vous prenez la fuite...");
        }
    }

// ACTION DU MONSTRE :
// Attaque simple. réussit et inflige les dégats égaux à l'arme du monstre
    public void monsterAttack(){
        Hero.WithdrawLifes(Monster.Weapon.Damage);
        Console.WriteLine("Le monstre vous a infligé " + Monster.Weapon.Damage + " dégat(s)");
    }

// Attaque acharnée. A 50% de chances de rater
    public void monsterRecklessAttack(){
                int chance = Utils.RandomUtils.GetRandomBetween(1,4);
        if(chance<=2){
            Console.WriteLine("Attaque ratée !");
        }
        else{
        Monster.WithdrawLifes(Monster.Weapon.Damage*2);
        Console.WriteLine("COUP CRITIQUE ! L'attaque vous a infligé " + Monster.Weapon.Damage*2 + " dégat(s) !");
        }
    }
}