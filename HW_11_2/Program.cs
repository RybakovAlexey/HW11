using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace HW_11_2
{
    internal class Program
    {

        static async Task Main(string[] args)
        {
            Bank.Clients = new List<Client>();

            Consultant user;

            using (FileStream fs = new FileStream("bankClients.json", FileMode.OpenOrCreate))
            {
              Bank.Clients = await JsonSerializer.DeserializeAsync<List<Client>>(fs);
            }

            Console.WriteLine("кем вы себя индентифицируете в данный момент?");
            Console.WriteLine("Менеджер - введите 1");
            Console.WriteLine("Консультант - введите 2");

            string readValue = Console.ReadLine();

            if (readValue == "1")
            {
                user = new Manager();
            }
            else
            {
                user = new Consultant();
            }

            bool runProgram = true;

            while (runProgram)
            {
                Console.WriteLine("Для просмотра списка клиентов нажмите 1");
                Console.WriteLine("Для изменения данных нажмите 2");
                if (user.GetType() == typeof(Manager))
                {
                    Console.WriteLine("Для Добавления клиента нажмите 3");
                }
                Console.WriteLine("Для выхода нажмите q");

                string answer = Console.ReadLine();

                switch (answer)
                {
                    case "0":
                        for (int i = 0; i < 10; i++)
                        {
                            Bank.Clients.Add(new Client(Bank.Clients.Count,
                                                        $"Фамилия{i}",
                                                        $"Имя{i}",
                                                        $"Отчество{i}",
                                                        $"8999888776{i}",
                                                        $"987654321{i}"));
                        }
                        break;
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
                    case "3":
                        if (user.GetType() == typeof(Manager))
                        {
                            Console.WriteLine("Введите ФИО через пробел");
                            string fullNewName = Console.ReadLine();
                            Console.WriteLine("Введите номер телефона");
                            string newTelefonNumber = Console.ReadLine();
                            Console.WriteLine("Введите номер паспорта");
                            string newPasportNumber = Console.ReadLine();
                            (user as Manager).AddClient(fullNewName, newTelefonNumber, newPasportNumber);
                        }
                        break;
                    case "q":
                        runProgram = false;

                        using (FileStream fs = new FileStream("bankClients.json", FileMode.OpenOrCreate))
                        {
                            await JsonSerializer.SerializeAsync<List<Client>>(fs, Bank.Clients);
                            Console.WriteLine("Data has been saved to file");
                        }
                        break;
                    default: break;
                }

            }
        }
    }
}
