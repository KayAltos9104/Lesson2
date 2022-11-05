namespace Lesson3
{
    public class Program
    {
        static void Main()
        { 
            /*
             * Создайте класс покемона. Характеристики: здоровье, атака, броня, ловкость
             * Умеет атаковать, умеет блокировать, умеет уворачиваться
             * Создать 2 покемонов с разными характеристиками и заставить их драться. Обрабатывать каждый
             * ход и выбрать, кто победит. 
             * Оба атака-блок, блок-атака, атака-уворот, уворот-атака
            */
            Sheep sheep1 = new Sheep(100);            
            
            Sheep sheep2 = new Sheep(50,1);
            

            sheep2.Eat();
            sheep1.Eat();

            sheep2.Attack(sheep1);

            Console.WriteLine(sheep1.Health);

            Console.WriteLine($"Возраст овцы {sheep1.IncrementAge(2)}");
        }
    }
    public class Sheep
    {
        //Поля класса
        public int Health;
        public byte Age;
        
        public Sheep(int health)
        {
            Health = health;
            Age = 0;
        }
        public Sheep(int health, byte age)
        {
            
            Health = health;
            Age = age;           
            
        }

        public void Attack(Sheep otherSheep)
        {
            otherSheep.Health -= Age;
        }

        public void Eat ()
        {            
            Health += 10;
            Console.WriteLine($"Овца покушала. Здоровье: {Health} ");
        }

        public int IncrementAge(byte incAge)
        {
            Age += incAge;
            return Age;
        }
    }
}