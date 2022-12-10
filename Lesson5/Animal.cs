namespace Lesson5;
public abstract class Animal
{
    public int X { get; private set; }
    public int Y { get; private set; }
    public int Health { get; set; }
    public string Name { get; protected set; }
    public Animal(int x, int y)
    {        
        X = x;      
        Y = y;
        Health = 100;        
    }
    
    public void Move (int direction)
    {        
        if (direction == 0)
            X += 1;
        else if (direction == 1)
            Y += 1;
        if (direction == 2)
            X -= 1;
        if (direction == 3)
            Y -= 1;

        //switch(direction)
        //{
        //    case 0:
        //        {
        //            X += 1;
        //            break;
        //        }
        //    case 1:
        //        {
        //            Y += 1;
        //            break;
        //        }
        //    case 2:
        //        {
        //            X -= 1;
        //            break;
        //        }
        //    case 3:
        //        {
        //            Y -= 1;
        //            break;
        //        }
        //}
    }
}
