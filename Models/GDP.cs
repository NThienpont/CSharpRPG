/*
namespace RPG
{
    internal class Map
    {
        // La carte est repr�sent�e par une matrice de cellules
        private Cell[,] cells;

        // La largeur et la hauteur de la carte en nombre de cellules
        public int Width { get; private set; }

        public int Height { get; private set; }

        // Constructeur qui initialise la carte en fonction de sa largeur et de sa hauteur
        public Map(int width, int height)
        {
            Width = width;
            Height = height;
            cells = new Cell[width, height];

            // Initialise toutes les cellules de la carte avec des valeurs par d�faut
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    cells[x, y] = new Cell();
                }
            }
        }

        // Obtient la cellule � une coordonn�e donn�e
        public Cell GetCell(int x, int y)
        {
            if (x >= 0 && x < Width && y >= 0 && y < Height)
            {
                return cells[x, y];
            }
            else
            {
                // Si les coordonn�es sont en dehors de la carte, renvoie une cellule "mur"
                return Cell.Wall;
            }
        }

        // D�place une entit� sur la carte dans une direction donn�e
        public void MoveEntity(Entity entity, Direction direction)
        {
            int x = entity.X;
            int y = entity.Y;

            // Modifie les coordonn�es de l'entit� en fonction de la direction
            switch (direction)
            {
                case Direction.North:
                    y--;
                    break;

                case Direction.East:
                    x++;
                    break;

                case Direction.South:
                    y++;
                    break;

                case Direction.West:
                    x--;
                    break;
            }

            // V�rifie que la nouvelle position de l'entit� est valide (dans la carte et non occup�e par un mur)
            Cell cell = GetCell(x, y);
            if (!cell.IsWall && cell.Entity == null)
            {
                // Si la position est valide, d�place l'entit� et met � jour sa position sur la carte
                entity.X = x;
                entity.Y = y;
                cells[entity.X, entity.Y].Entity = entity;
                cells[x, y].Entity = null;
            }
        }
    }

    // Classe repr�sentant une cellule de la carte
    internal class Cell
    {
        // Un bool�en indiquant si la cellule est un mur ou non
        public bool IsWall { get; set; }

        // Un bool�en indiquant si la cellule est traversable ou non
        public bool IsPassable { get; set; }

        // Classe repr�sentant une entit� sur la carte
        private class Entity
        {
            // Les coordonn�es de l'entit� sur la carte
            public int X { get; set; }

            public int Y { get; set; }
        }

        // Classe repr�sentant un objet collectible sur la carte
        private class Item
        {
            // Les coordonn�es de l'objet sur la carte
            public int X { get; set; }

            public int Y { get; set; }
        }

        // Classe repr�sentant un �l�ment d�coratif sur la carte
        private class Decoration
        {
            // Les coordonn�es de l'�l�ment d�coratif sur la carte
            public int X { get; set; }

            public int Y { get; set; }
        }

        // Classe principale du jeu
        private class Game
        {
            // La carte du jeu
            private Map map;

            // La liste des entit�s pr�sentes sur la carte
            private List<Entity> entities;

            // La liste des objets collectibles pr�sents sur la carte
            private List<Item> items;

            // La liste des �l�ments d�coratifs pr�sents sur la carte
            private List<Decoration> decorations;

            // Constructeur du jeu qui initialise la carte et les listes d'entit�s, d'objets collectibles et d'�l�ments d�coratifs
            public Game(int mapWidth, int mapHeight)
            {
                map = new Map(mapWidth, mapHeight);
                entities = new List<Entity>();
                items = new List<Item>();
                decorations = new List<Decoration>();
            }

            // Ajoute une entit� � la liste et � la carte
            public void AddEntity(Entity entity)
            {
                entities.Add(entity);
                map.GetCell(entity.X, entity.Y).Entity = entity;
            }

            // Ajoute un objet collectible � la liste et � la carte
            public void AddItem(Item item)
            {
                items.Add(item);
                map.GetCell(item.X, item.Y).Item = item;
            }

            // Ajoute un �l�ment d�coratif � la liste et � la carte
            public void AddDecoration(Decoration decoration)
            {
                decorations.Add(decoration);
                map.GetCell(decoration.X, decoration.Y).Decoration = decoration;
            }

            // D�place une entit� dans une direction donn�e
            public void MoveEntity(Entity entity, Direction direction)
            {
                map.MoveEntity(entity, direction);
            }
        }

        // Programme principal qui cr�e un jeu et ajoute des entit�s, des objets collectibles et des �l�ments d�coratifs
        private static void Main(string[] args)
        {
            // Cr�e un jeu avec une carte de 20x20 cellules
            Game game = new Game(20, 20);

            // Cr�e et ajoute une entit� au jeu
            Entity entity1 = new Entity { X = 5, Y = 5 };
            game.AddEntity(entity1);

            // Cr�e et ajoute un objet collectible au jeu
            Item item1 = new Item { X = 10, Y = 10 };
            game.AddItem(item1);

            // Cr�e et ajoute un �l�ment d�coratif au jeu
            Decoration decoration1 = new Decoration { X = 15, Y = 15 };
            game.AddDecoration(decoration1);

            // Boucle principale du jeu qui g�re les entr�es de l'utilisateur et met � jour l'�tat du jeu
            while (true)
            {
                // Lit les entr�es de l'utilisateur et d�place l'entit� en fonction de la direction choisie
                Console.WriteLine("Entrez une direction (Z, Q, S, D) pour d�placer l'entit� ou O pour quitter :");
                string input = Console.ReadLine().ToLower();
                if (input == "o")
                {
                    break;
                }
                else if (input == "z")
                {
                    game.MoveEntity(entity1, Direction.North);
                }
                else if (input == "d")
                {
                    game.MoveEntity(entity1, Direction.East);
                }
                else if (input == "s")
                {
                    game.MoveEntity(entity1, Direction.South);
                }
                else if (input == "q")
                {
                    game.MoveEntity(entity1, Direction.West);
                }

                // Mise � jour de l'�tat du jeu (par exemple, d�placement des ennemis

                // Mise � jour de l'�tat du jeu (par exemple, d�placement des ennemis, v�rification des collisions, etc.)
                UpdateGameState();

                // Affichage de l'�tat du jeu (par exemple, affichage de la carte et des entit�s sur la console)
                RenderGame();
            }

            // M�thode de mise � jour de l'�tat du jeu
            private void UpdateGameState()
            {
                // Parcours de la liste des entit�s et mise � jour de leur �tat (par exemple, d�placement des ennemis)
                foreach (Entity entity in entities)
                {
                    // Si l'entit� est un ennemi, d�place l'ennemi dans une direction al�atoire
                    if (entity is Enemy)
                    {
                        Enemy enemy = (Enemy)entity;
                        enemy.MoveRandom();
                    }
                }

                // V�rification des collisions entre les entit�s et les objets collectibles
                foreach (Entity entity in entities)
                {
                    foreach (Item item in items)
                    {
                        // Si l'entit� et l'objet collectible ont les m�mes coordonn�es, supprime l'objet collectible de la liste et de la carte
                        if (entity.X == item.X && entity.Y == item.Y)
                        {
                            items.Remove(item);
                            map.GetCell(item.X, item.Y).Item = null;
                            break;
                        }
                    }
                }
            }

            // M�thode d'affichage de l'�tat du jeu
            private void RenderGame()
            {
                // Affiche la carte en utilisant des caract�res de type "mur" ou "espace" en fonction de la valeur de la propri�t� IsWall des cellules
                for (int y = 0; y < map.Height; y++)
                {
                    for (int x = 0; x < map.Width; x++)
                    {
                        Cell cell = map.GetCell(x, y);
                        if (cell.IsWall)
                        {
                            Console.Write("#");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }

                // Affiche les entit�s sur la carte en utilisant des caract�res diff�rents selon le type d'entit�
                foreach (Entity entity in entities)
                {
                    if (entity is Player)
                    {
                        Console.SetCursorPosition(entity.X, entity.Y);
                        Console.Write("P");
                    }
                    else if (entity is Enemy)
                    {
                        Console.SetCursorPosition(entity.X, entity.Y);
                        Console.Write("E");
                    }
                }

                foreach (Item item in items)
                {
                    Console.SetCursorPosition(item.X, item.Y);
                    Console.Write("I");
                }

                // Affiche les �l�ments d�coratifs sur la carte en utilisant un caract�re sp�cifique
                foreach (Decoration decoration in decorations)
                {
                    Console.SetCursorPosition(decoration.X, decoration.Y);
                    Console.Write("D");
                }

                // Affiche l'interface utilisateur avec des informations sur le jeu (par exemple, le nombre d'objets collectibles restants)
                RenderUI();

                // Attend une entr�e de l'utilisateur avant de passer au tour suivant
                WaitForInput();

                // Fin de la boucle principale du jeu
            }
        }

        private static void RenderUI()
        {
            Console.SetCursorPosition(0, map.Height);
            Console.WriteLine("Objets collectibles restants : {0}", items.Count);
        }

        private static void EndGame()
        {
            Console.Clear();
            Console.WriteLine("F�licitations, vous avez gagn� !");
        }

        private static void WaitForInput()
        {
            Console.ReadLine();
        }
    }
}
*/