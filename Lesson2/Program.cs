namespace Lesson2
{
    internal class Program
    {
        static void Main()
        {
            /*
             * Калькулятор с разбиением на отдельные функции и проверкой корректности введенных данных
             * (то есть, если вводим не число, то программа не вылетает)
            */

            //int res1 = CalculateSum(2, 3);
            //int a = 20;
            //int b = 20;
            //int res2 = CalculateSum(a, b);
            //WriteResult(res1);
            //WriteResult(res2);
            //WriteResult(CalculateSum(4,5));
            //WriteResult(CalculateSum(6,7,8));

            //int n = 20;
            //ChangeNum(ref n);
            //Console.WriteLine(n);
            //string operationStatus;
            //MultipleReturn(3, 3, out operationStatus);
            //Console.WriteLine(operationStatus);
            //MultipleReturn(4, 4, out string t);
            //Console.WriteLine(t);

            string input = Console.ReadLine();
            int n1 = 0;
            int n2 = 0;

            if (n1 > 0 ||/*or*/ n2 > 0)
            {

            }
            else if (n1 > 0 &&/*and*/ n2 > 0)
            {

            }

            if (double.TryParse(input, out double inputNumber) == true)
            {
                double res = Math.Round(inputNumber / 3, 4);
                Console.WriteLine("Удвоенное значение: " + res);
                string output = string.Format("{0:C2}", inputNumber/3);
                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine("Вы ввели не число");
            }


        }
        //Модификатор доступа static-не static Возвращаемый тип Название метода (Аргументы)
        static int CalculateSum(int n1, int n2)
        {
            int res = n1 + n2;
            return res;
        }

        static int CalculateSum(int n1, int n2, int n3)
        {
            return n1 + n2 + n3;
        }        

        static void WriteResult(int res)
        {
            Console.WriteLine("Ваш ответ: "+ res);
        }

        static void ChangeNum(ref int n)
        {
            n = n * 2;
        }

        static int MultipleReturn(int n1, int n2, out string s)
        {
            s = "Операция совершена";
            return n1 + n2;
        }
    }   
}