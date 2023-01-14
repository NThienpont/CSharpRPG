namespace CSharpRPG.Models;

public class Matrix
{
    private int[,] matrix1 = new int[,]
        {
        { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
        { 3, 9, 0, 0, 0, 0, 0, 0, 0, 8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
        { 1, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 1 },
        { 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 1 },
        { 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 1 },
        { 1, 0, 0, 0, 0, 8, 0, 0, 0, 0, 0, 1, 0, 0, 8, 0, 0, 1, 0, 1 },
        { 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 1 },
        { 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 1 },
        { 1, 0, 1, 1, 1, 0, 1, 1, 1, 0, 0, 1, 1, 1, 0, 1, 1, 1, 0, 1 },
        { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
        { 1, 0, 0, 0, 0, 0, 0, 0, 0, 8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
        { 1, 0, 1, 1, 1, 0, 1, 1, 1, 0, 0, 1, 1, 1, 0, 1, 1, 1, 8, 1 },
        { 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 1 },
        { 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 1 },
        { 1, 0, 1, 0, 0, 8, 0, 0, 0, 0, 0, 1, 0, 0, 8, 0, 0, 1, 0, 1 },
        { 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 1 },
        { 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 1 },
        { 1, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 1, 1, 1, 0, 1, 1, 1, 0, 1 },
        { 1, 8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 6 },
        { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }
        };

    int PlayerPositionX = 1;
    int PlayerPositionY = 1;
    int tempDestX;
    int tempDestY;

    public bool fightingStatus = false;
    public bool game = true;
    public void ViewMap(Hero p)
    {
        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            Console.WriteLine();
            for (int j = 0; j < matrix1.GetLength(1); j++)
            {
                switch (matrix1[i, j])
                {
                    case 1:
                        Console.Write('x');
                        break;
                    case 8:
                        Console.Write('!');
                        break;
                    case 9:
                        Console.Write("?");
                        break;
                    case 0:
                        Console.Write(" ");
                        break;
                    case 3:
                        Console.Write("+");
                        break;
                    default:
                        Console.Write("|");
                        break;
                }
            }
        }
    }

    public void replace(){
        matrix1[tempDestX,tempDestY]=0;
    }
    public void Move(string direction){
        if(direction=="z"){
            tempDestX=PlayerPositionX-1;
            tempDestY=PlayerPositionY;
            if(matrix1[tempDestX,tempDestY]==1){
                Console.WriteLine("Deplacement impossible vers un mur !");
            }
            else if(matrix1[tempDestX,tempDestY]==8){
                Console.WriteLine("Combat initié !");
                fightingStatus=true;
                replace();   
            }
            else if(matrix1[tempDestX,tempDestY]==3){
            System.Console.WriteLine("Ceci est l'entrée du donjon, vous ne pouvez pas aller la, la porte est fermé !");
            }
            else if(matrix1[tempDestX,tempDestY]==6){
                game=false;
            }      
            else{
                matrix1[tempDestX,tempDestY]=matrix1[PlayerPositionX,PlayerPositionY];
                matrix1[PlayerPositionX,PlayerPositionY]=0;
                System.Console.WriteLine(PlayerPositionX + PlayerPositionY);

                PlayerPositionX-=1;
            }
        }
        if(direction=="q"){
            tempDestX=PlayerPositionX;
            tempDestY=PlayerPositionY-1;
            if(matrix1[tempDestX,tempDestY]==1){
                Console.WriteLine("Deplacement impossible vers un mur !");
            }
            else if(matrix1[tempDestX,tempDestY]==8){
                Console.WriteLine("Combat initié !");
                fightingStatus=true;
                replace();              
            }
            else if(matrix1[tempDestX,tempDestY]==3){
            System.Console.WriteLine("Ceci est l'entrée du donjon, vous ne pouvez pas aller la, la porte est fermé !");
            }
            else if(matrix1[tempDestX,tempDestY]==6){
                game=false;
            } 
            else{
                matrix1[tempDestX,tempDestY]=matrix1[PlayerPositionX,PlayerPositionY];
                matrix1[PlayerPositionX,PlayerPositionY]=0;       

                PlayerPositionY--;    
            }
        }
        if(direction=="s"){
            tempDestX=PlayerPositionX+1;
            tempDestY=PlayerPositionY;
            if(matrix1[tempDestX,tempDestY]==1){
                Console.WriteLine("Deplacement impossible vers un mur !");
            }
            else if(matrix1[tempDestX,tempDestY]==8){
                Console.WriteLine("Combat initié !");
                fightingStatus=true;
                replace();   
            }
            else if(matrix1[tempDestX,tempDestY]==3){
            System.Console.WriteLine("Ceci est l'entrée du donjon, vous ne pouvez pas aller la, la porte est fermé !");
            }
            else if(matrix1[tempDestX,tempDestY]==6){
                game=false;
            } 
            else{
                matrix1[tempDestX,tempDestY]=matrix1[PlayerPositionX,PlayerPositionY];
                matrix1[PlayerPositionX,PlayerPositionY]=0; 

                PlayerPositionX++;               
            }
        }
        if(direction=="d"){
            tempDestX=PlayerPositionX;
            tempDestY=PlayerPositionY+1;
            if(matrix1[tempDestX,tempDestY]==1){
                Console.WriteLine("Deplacement impossible vers un mur !");
            }
            else if(matrix1[tempDestX,tempDestY]==8){
                Console.WriteLine("Combat initié !");
                fightingStatus=true;
                replace();   
            }
            else if(matrix1[tempDestX,tempDestY]==3){
                System.Console.WriteLine("Ceci est l'entrée du donjon, vous ne pouvez pas aller la, la porte est fermé !");
            }
            else if(matrix1[tempDestX,tempDestY]==6){
                game=false;
            } 
            else{
                matrix1[tempDestX,tempDestY]=matrix1[PlayerPositionX,PlayerPositionY];
                matrix1[PlayerPositionX,PlayerPositionY]=0; 

                PlayerPositionY++;               
            }
        }
    }
}
