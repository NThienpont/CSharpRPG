// .gitignore
using CSharpRPG.Models;

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


while(game){
var adventureChoice = Console.ReadLine();
Fight fight1 = new Fight(Player,Monstre);
bool fightingStatus = true;
int PlayerPositionX = 2;
int PlayerPositionY = 2;


if(fightingStatus==true){
    if(adventureChoice=="1"){
interface1.clear();
interface1.top();
interface1.aideCombat();
interface1.bottom();
fight1.attack();
fight1.monsterAction();

    }
    else if(adventureChoice=="2"){
interface1.clear();
interface1.top();
interface1.aideCombat();
interface1.bottom();
fight1.violentAttack();
fight1.monsterAction();
    }
    else if(adventureChoice=="3"){
interface1.clear();
interface1.top();
interface1.aideCombat();
interface1.bottom();
fight1.heal();
fight1.monsterAction();    
    }
    else if(adventureChoice=="4"){
interface1.clear();
interface1.top();
interface1.aideCombat();
interface1.bottom();
fight1.escape();      
    }
    else{
            Console.WriteLine("Vous êtes en combat ! Vous devez utiliser les commandes de combat.");
    }
    if(fight1.Monster.Life<=0){
        Console.WriteLine("Vous avez tué le monstre!");
        System.Console.WriteLine("Pour continuer, appuyer sur une touche");
        Console.ReadLine();
        fightingStatus=false;
        Console.Clear();
        interface1.top();
        matrix1.ViewMap(Player);
        interface1.bottom();
    }
}
else{
    if(adventureChoice=="z"){
//Permettrait de détecter un mur dans la matrice et empêcher le déplacement
/*if(true){}*/
//Permettrait de détecter un monstre dans la matrice et lancer le combat
/*if(true){}*/
PlayerPositionY=-1;
System.Console.WriteLine(PlayerPositionY);
interface1.clear();
interface1.top();
matrix1.ViewMap(Player);
interface1.bottom();

}
    else if(adventureChoice=="q"){
//Permettrait de détecter un mur dans la matrice et empêcher le déplacement
/*if(true){}*/
//Permettrait de détecter un monstre dans la matrice et lancer le combat
/*if(true){}*/
PlayerPositionX =-1;
Console.WriteLine(PlayerPositionX);    
interface1.clear();
interface1.top();
matrix1.ViewMap(Player);
interface1.bottom();
}

    else if(adventureChoice=="s"){
//Permettrait de détecter un mur dans la matrice et empêcher le déplacement
/*if(true){}*/
//Permettrait de détecter un monstre dans la matrice et lancer le combat
/*if(true){}*/
PlayerPositionY=+1;
System.Console.WriteLine(PlayerPositionY);
interface1.clear();
interface1.top();
matrix1.ViewMap(Player);
interface1.bottom(); 
}    
    else if(adventureChoice=="d"){
//Permettrait de détecter un mur dans la matrice et empêcher le déplacement
/*if(true){}*/
//Permettrait de détecter un monstre dans la matrice et lancer le combat
/*if(true){}*/
PlayerPositionX =+1;
Console.WriteLine(PlayerPositionX);    
interface1.clear();
interface1.top();
matrix1.ViewMap(Player);
interface1.bottom();     
    }
    else{
        Console.WriteLine("Vous êtes sur la carte, vous devez vous déplacer avec les touches ZQSD.");
    }
}

}

Console.Clear();
Console.WriteLine("Vous avez gagné " + Player.Pseudo + ", Bravo ! :D Merci d'avoir joué.");