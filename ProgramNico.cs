// .gitignore
using CSharpRPG.Models;

/*Hero Player = new Hero ("Romain",10,"🤴", WeaponList.MasterSword);
Monster Monstre = new Monster(5,"",WeaponList.Claw);*/

/*
Player.ViewLifes();
Player.WithdrawLifes(15);
Player.ViewLifes();
Player.AddLifes(20);
Player.ViewLifes();
Console.WriteLine(Player);*/


/*Interface interface1 = new Interface(Player);
interface1.top();

Matrix Matrix1 = new Matrix();
Matrix1.ViewMap(Player);

interface1.bottom();
interface1.aideCombat();

Fight fight1 = new Fight(Player, Monstre);
fight1.violentAttack();
fight1.attack();
fight1.heal();
fight1.escape();


Console.WriteLine(fightingStatus);*/
Console.Clear();
Console.WriteLine("Bienvenue dans ce RPG codé en CSharp ! Veuillez entrer le nom de votre personnage !");
var name = Console.ReadLine();
bool game = true;
if(name==""){
    name="Romain";
}

Hero Player = new Hero (name,10,"🤴", WeaponList.MasterSword);
Monster Monstre = new Monster(5,"",WeaponList.Claw);

System.Console.WriteLine("Vous êtes un héros nommé " + Player.Pseudo+ ". Vous venez d'arriver dans un donjon et la porte s'est fermée derrière vous. Votre objectif est donc d'atteindre la sortie du donjon en survivant aux pièges et monstres sur votre chemin... \nArriverez-vous "+Player.Pseudo+", à relever le défi? \n");
System.Console.WriteLine("Appuyez sur une touche pour commencer !");
System.Console.ReadKey();

Interface interface1 = new Interface(Player);
Matrix matrix1 = new Matrix();
interface1.clear();

interface1.top();
matrix1.ViewMap(Player);
interface1.bottom();

bool fightingStatus = false;

if(fightingStatus){
    Fight fight1 = new Fight(Player, Monstre);
    Interface interfaceCombat = new Interface(Player);
    interfaceCombat.top();
    interfaceCombat.aideCombat();
}

while(game){
var adventureChoice = Console.ReadKey();

if(fightingStatus==true){
    if(adventureChoice==1){

    }
    else if(adventureChoice==2){
        
    }
    else if(adventureChoice==3){
        
    }
    else if(adventureChoice==4){
        
    }
    else{
        Console.WriteLine("Vous êtes en combat ! Vous devez utiliser les commandes de combat.")
    }
}
else{
    if(adventureChoice=="z"){

    }
    else if(adventureChoice=="q"){

    }
    else if(adventureChoice=="s"){
        
    }    
    else if(adventureChoice=="d"){
        
    }
}

}

Console.Clear();
Console.WriteLine("Vous avez gagné " + Player.Pseudo + ", Bravo ! :D Merci d'avoir joué.");