using System;
using System.IO;
namespace lyas_avtorizacya
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Новый или уже смешарик? (Выберите 1, если зарегестрированы или 2 если нет)");
            string switch1 = Console.ReadLine();
            
            switch (switch1)
                {
                case "1":
                    string username, password, username1,  password1 = string.Empty;
                    Console.WriteLine("Вход");

                    Console.Write("Введите имя: ");
                    username = Console.ReadLine();
                    Console.Write("Введите пароль: ");
                    password = Console.ReadLine();

                    using (StreamReader sr = new StreamReader(File.Open("D:\\1.txt", FileMode.Open)))
                    {
                        username1 = sr.ReadLine();
                        password1 = sr.ReadLine();
                        sr.Close();
                    }

                    if (username == username1 && password == password1)
                    {
                        Console.Write("Выполнено успешно");
                    }
                    else
                    {
                        Console.Write("Данные не верны");
                    }

                    Console.Read();


                    break;
                case "2":
                    
                    Console.WriteLine("Новый пользователь");

                    Console.Write("Введите имя: ");
                    username = Console.ReadLine();
                    Console.Write("Введите пароль: ");
                    password = Console.ReadLine();
                    using (StreamWriter sw = new StreamWriter(File.Create("D:\\1.txt")))
                    {
                        sw.WriteLine(username);
                        sw.WriteLine(password);
                        sw.Close();
                    }

                    Console.Write("Выполнено");

                    Console.Read();
                    break;
            }


           
        }
    }
}
