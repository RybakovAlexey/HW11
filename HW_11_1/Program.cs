using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace HW_11_1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Bank.Clients = new List<Client>();

            for (int i = 0; i < 10; i++)
            {
                Bank.Clients.Add(new Client(Bank.Clients.Count,
                                            $"Фамилия{i}",
                                            $"Имя{i}",
                                            $"Отчество{i}",
                                            $"8999888776{i}",
                                            $"987654321{i}"));
            }

            bool runProgram = true;

            Consultant user = new Consultant();

            while (runProgram)
            {
                Console.WriteLine("Для просмотра списка клиентов нажмите 1");
                Console.WriteLine("Для изменения данных нажмите 2");
                Console.WriteLine("Для выхода нажмите q");
                string answer = Console.ReadLine();

                switch (answer)
                {
                    case "1":
                        user.PrintClients();
                        break;

                    case "2":
                        Console.WriteLine("Введите ID клиента для изменения его данных");
                        int id = Convert.ToInt32(Console.ReadLine());
                        user.PrintClient(id);

                        Console.WriteLine("Введите новый номер телефона");
                        user.ChangeTelefonNumber(id, Console.ReadLine());

                        user.PrintClient(id);
                        break;
                    case "q":
                        runProgram = false;
                        break;
                    default: break;
                }

            }


        }



    }
}
