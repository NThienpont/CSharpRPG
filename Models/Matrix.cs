namespace CSharpRPG.Models;

public class Matrix
{
    private int[,] matrix1 = new int[,]
        {
        { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
        { 6, 9, 0, 0, 0, 0, 0, 0, 0, 8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
        { 1, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 1 },
        { 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 1 },
        { 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 1 },
        { 1, 0, 1, 0, 0, 8, 0, 0, 1, 0, 0, 1, 0, 0, 8, 0, 0, 1, 0, 1 },
        { 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 1 },
        { 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 1 },
        { 1, 0, 1, 1, 1, 0, 1, 1, 1, 0, 0, 1, 1, 1, 0, 1, 1, 1, 0, 1 },
        { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
        { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
        { 1, 0, 1, 1, 1, 0, 1, 1, 1, 0, 0, 1, 1, 1, 0, 1, 1, 1, 0, 1 },
        { 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 1 },
        { 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 1 },
        { 1, 0, 1, 0, 0, 8, 0, 0, 1, 0, 0, 1, 0, 0, 8, 0, 0, 1, 0, 1 },
        { 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 1 },
        { 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 1 },
        { 1, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 1 },
        { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 6 },
        { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }
        };

    int PlayerPositionX = 1;
    int PlayerPositionY = 1;
    int tempDestX;
    int tempDestY;
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
                    default:
                        Console.Write("|");
                        break;
                }
            }
        }
    }

    public void Move(string direction){
        if(direction=="z"){
            tempDestX=PlayerPositionX-1;
            tempDestY=PlayerPositionY;
            System.Console.WriteLine(PlayerPositionX + PlayerPositionY);
            if(matrix1[tempDestX,tempDestY]==1){
                Console.WriteLine("Deplacement impossible vers un mur !");
            }
            else if(matrix1[tempDestX,tempDestY]==8){
                Console.WriteLine("Combat initié !");
            }
            else if(matrix1[tempDestX,tempDestY]==6){
            System.Console.WriteLine("Ceci est l'entrée ou la sortie du donjon, vous ne pouvez pas aller la, sinon ca va bugger ^^");
            }        
            else{
                matrix1[tempDestX,tempDestY]=matrix1[PlayerPositionX,PlayerPositionY];
                matrix1[PlayerPositionX,PlayerPositionY]=0;
                System.Console.WriteLine(PlayerPositionX + PlayerPositionY);

                PlayerPositionX-=1;
            }
        }
        if(direction=="q"){
                            System.Console.WriteLine(PlayerPositionX + PlayerPositionY);
            tempDestX=PlayerPositionX;
            tempDestY=PlayerPositionY-1;
            if(matrix1[tempDestX,tempDestY]==1){
                Console.WriteLine("Deplacement impossible vers un mur !");
            }
            else if(matrix1[tempDestX,tempDestY]==8){
                Console.WriteLine("Combat initié !");
            }
            else if(matrix1[tempDestX,tempDestY]==6){
            System.Console.WriteLine("Ceci est l'entrée ou la sortie du donjon, vous ne pouvez pas aller la, sinon ca va bugger ^^");
            }
            else{
                matrix1[tempDestX,tempDestY]=matrix1[PlayerPositionX,PlayerPositionY];
                matrix1[PlayerPositionX,PlayerPositionY]=0;       

                PlayerPositionX--;    
            }
        }
        if(direction=="s"){
                            System.Console.WriteLine(PlayerPositionX + PlayerPositionY);
            tempDestX=PlayerPositionX+1;
            tempDestY=PlayerPositionY;
            if(matrix1[tempDestX,tempDestY]==1){
                Console.WriteLine("Deplacement impossible vers un mur !");
            }
            else if(matrix1[tempDestX,tempDestY]==8){
                Console.WriteLine("Combat initié !");
            }
            else if(matrix1[tempDestX,tempDestY]==6){
            System.Console.WriteLine("Ceci est l'entrée ou la sortie du donjon, vous ne pouvez pas aller la, sinon ca va bugger ^^");
            }
            else{
                matrix1[tempDestX,tempDestY]=matrix1[PlayerPositionX,PlayerPositionY];
                matrix1[PlayerPositionX,PlayerPositionY]=0; 

                PlayerPositionX+=1;               
            }
        }
        if(direction=="d"){
                            System.Console.WriteLine(PlayerPositionX + PlayerPositionY);
            tempDestX=PlayerPositionX;
            tempDestY=PlayerPositionY+1;
            if(matrix1[tempDestX,tempDestY]==1){
                Console.WriteLine("Deplacement impossible vers un mur !");
            }
            else if(matrix1[tempDestX,tempDestY]==8){
                Console.WriteLine("Combat initié !");
                            }
            else if(matrix1[tempDestX,tempDestY]==6){
                System.Console.WriteLine("Ceci est l'entrée ou la sortie du donjon, vous ne pouvez pas aller la, sinon ca va bugger ^^");
            }
            else{
                matrix1[tempDestX,tempDestY]=matrix1[PlayerPositionX,PlayerPositionY];
                matrix1[PlayerPositionX,PlayerPositionY]=0; 

                PlayerPositionY++;               
            }
        }
    }
}
