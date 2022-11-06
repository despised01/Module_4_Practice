using System;

namespace Module_4_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            (string FirstName, string LastName, string Login, int LoginLength, bool HasPet, double Age, string[] favcolors) User;

            for (int k = 0; k < 3; k++)
            {

                Console.WriteLine("Введите имя: ");
                User.FirstName = Console.ReadLine();

                Console.WriteLine("Введите фамилию: ");
                User.LastName = Console.ReadLine();

                Console.WriteLine("Введите логин: ");
                User.Login = Console.ReadLine();

                User.LoginLength = User.Login.Length;
                Console.WriteLine("Длина вашего логина {0} символов.", User.LoginLength);

                Console.WriteLine("Есть ли у вас животные? Да или Нет");
                var result = Console.ReadLine();

                if (result == "Да")
                {
                    User.HasPet = true;
                }
                else
                {
                    User.HasPet = false;
                }

                Console.WriteLine("Введите ваш возраст: ");
                User.Age = double.Parse(Console.ReadLine());

                User.favcolors = new string[3];
                
                Console.WriteLine("Введите три ваших любимых цвета: ");

                for (int i = 0; i < User.favcolors.Length; i++)
                    User.favcolors[i] = Console.ReadLine();
            }
        }
    }
}
