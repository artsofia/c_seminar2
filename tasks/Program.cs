namespace New_folder;
class Program
{
    static void Main(string[] args)
    {
        int Input(string text)
            {
                Console.Write(text);
                return Convert.ToInt32(Console.ReadLine());
            }


        void Task10()
            {
                int num = Input("Введите трехзначное число: ");
                
                Console.WriteLine(num / 10 % 10);
            }


        void Task13()
            {
                int num = Input("Введите число: ");
                num = Math.Abs(num);

                if (num > 99)
                {
                    while (num > 999)
                    {
                        num /= 10;
                    }
                    Console.WriteLine($"Третья цифра числа {num % 10}");
                }
                else
                {
                    Console.WriteLine("Третьей цифры нет");
                }
            }


        void Task15()
            {
                int num_day = Input("Ведите номер дня недели: ");

                if (num_day == 6 || num_day == 7)
                {
                    Console.WriteLine("Этот день является выходным");
                }
                else
                {
                    Console.WriteLine("Этот день не является выходным");
                }
            }


        // Для проверки кода
        // Console.Clear();
        // Task10();
    }
}