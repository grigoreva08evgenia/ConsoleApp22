using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User()
            {
                FirstName = "Григорьева",
                Name = "Евгения",
                Login = "Privet",
                Password = "Privet"
            };
            Console.WriteLine("Введите логин");
            string login = Console.ReadLine();

            user.AuthorizeUser(login, "");

            Console.ReadLine();

        }
    }

    class User
    {
        public string FirstName; // Фамилия
        public string Name; // Имя

        public string Login;
        public string Password;

        public void AuthorizeUser(string login, string password)
        {
            if(login == Login)
            {
                Console.WriteLine("Вы успешно авторизировались");
            }
            else
            {
                Console.WriteLine("Авторизация не удалась");
            }
        }
    }
}
