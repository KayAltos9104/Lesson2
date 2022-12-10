namespace Lesson7;
internal class Program
{
    static void Main()
    {
        //char c = 'q';
        //string s = "qwerty";
        //for (int i = 0; i < s.Length; i++)
        //{
        //    Console.WriteLine(s[i]);
        //}
        //// Массивы изменяемые
        //var array1 = new int[10];
        //array1[5] = 10;

        //// Строки неизменяемые
        ////s[0] = 'r';

        //string s2 = new string(new char[3] {'q', 'q' , 'q' });
        //string row = "Igor \nLebedev\tктн";
        //Console.WriteLine(row);
        //if (row.Contains("Igor"))
        //    Console.WriteLine(true);

        //var surnameIndex = row.IndexOf("Lebedev");

        //string s = "cat cat cat catcatcat";

        //Console.WriteLine(s.Replace("cat", "dog"));

        string s = "В худой котомк поклав ржаное хлебо\nЯ ухожу туда, где птичья звон.\n" +
            "И вижу над собою синий небо,\nКосматый облак и высокий крон";
        //var sub = s.Substring(10, 15);
        //Console.WriteLine(sub);
        //s = s.Insert(1, "qwerty");
        //Console.WriteLine(s);
        //string order = Console.ReadLine();
        //string[] splitted = order.Split('=');
        //if (splitted[0] == "имя")
        //    Console.WriteLine($"Ваше имя: {splitted[1]}");
        //else if (splitted[0] == "фамилия")
        //    Console.WriteLine($"Ваша фамилия: {splitted[1]}");
        string s1 = "Игорь";
        string s2 = "Витальевич";
        string s3 = "Лебедев";

        //string united = string.Concat(s1,s2,s3);
        string united = string.Join(" ", new string[] { s1, s2, s3 });
        // Console.WriteLine(united);
        //Console.WriteLine($"Имя: {s1}");
        //string name = $"Имя :{s1}";
        //name = string.Format("Имя : {0}; Фамилия {1}", s1, s2);
        //Console.WriteLine(name);
        //double salary = 7000.329541925412;
        //Console.WriteLine(string.Format("{0:f2}", salary));
        //int integer = 1234;
        //string r = integer.ToString();
        //Console.WriteLine(string.Format("{0:d5}", integer));

        Class2 c = new Class2("Игорь", "Лебедев");
        Console.WriteLine(c.ToString());
        string[,] chars = new string[2, 100];
        chars[0, 0] = "Игорь";  chars[1, 0] = "Лебедев";
        chars[0, 1] = "Павел";  chars[1, 1] = "Калугин";
        chars[0, 2] = "Сергей"; chars[1, 2] = "Сорокин";

        var list = new List<Class2>();
        for (int i = 0; i < 3; i++)
        {
            Class2 man = new Class2(chars[0, i], chars[1, i]);
            list.Add(man);
        }

        foreach (var m in list)
        {
            if (m is Class2)
            {
                var c3 = m as Class3;
                c3.SomeAction();
            }
        }

    }
}


class Class2
{
    private string _name;
    private string _surname;

    public Class2(string name, string surname)
    {
        _name = name;
        _surname = surname;
    }

    public override string ToString()
    {
        return string.Join(" ", new string[] { _name, _surname });
    }
}

class Class3 : Class2
{
    public Class3(string name, string surname) : base(name, surname)
    {
    }

    public void SomeAction()
    {

    }
}