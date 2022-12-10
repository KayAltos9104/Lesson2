namespace Lesson5;
internal class Program
{
    /*
     * Есть двухмерное поле 10х10
     * Рандомно генерируются на нем однопалубные корабли
     * Игроку показывается пустое поле.
     * Мы выбираем, куда бить. Если попали по кораблю, то там рисуется Х,
     * если промахнулись, то *
     */
    static List<Animal> animals = new List<Animal>();
    static Field field = new Field(15, 15);
    static void Main()
    {
        Wolf w = new Wolf(5, 5);
        animals.Add(w);        

        while(true)
        {
            field.InitializeField();

            ConsoleKeyInfo pushedKey = Console.ReadKey();
            int dir = 0;
            if (pushedKey.Key == ConsoleKey.RightArrow)
                dir = 0;
            else if (pushedKey.Key == ConsoleKey.DownArrow)
                dir = 1;
            else if (pushedKey.Key == ConsoleKey.LeftArrow)
                dir = 2;
            else if (pushedKey.Key == ConsoleKey.UpArrow)
                dir = 3;

            // Логика         
            w.Move(dir);

            PlaceObjects();
            // Отрисовка
            RenderField();            
        }        
    }
    static void PlaceObjects()
    {
        foreach (Animal a in animals)
        {
            char sprite = '\0';
            switch(a.Name)
            {
                case "Wolf":
                    {
                        sprite = 'w';
                        break;
                    }
                case "Sheep":
                    {
                        sprite = 's';
                        break;
                    }
            }
            field.Space[a.X, a.Y] = sprite;
        }
            
    }
    static void RenderField ()
    {
        Console.Clear();
        for (int y = 0; y < field.Space.GetLength(1); y ++)
        {            
            for (int x = 0; x < field.Space.GetLength(0); x++)
            {
                if (field.Space[x, y] == 'w')
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write(field.Space[x, y]);
                    Console.ResetColor();
                }                    
                else if (field.Space[x, y] == '\0')
                {
                    Console.Write('.');
                }                
            }
            Console.WriteLine();
        }
    }
}