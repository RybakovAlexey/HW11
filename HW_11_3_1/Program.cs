using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace HW_11_3_1
{
    internal class Program
    {

        static async Task Main(string[] args)
        {
            Bank.Clients = new List<Client>();

            IbankWorker user;

            using (FileStream fs = new FileStream("bankClients.json", FileMode.OpenOrCreate))
            {
                if (fs.Length > 0)
                {
                    Bank.Clients = JsonSerializer.Deserialize<List<Client>>(fs);

                }
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
                Console.WriteLine("Для Добавления клиента нажмите 1");
                Console.WriteLine("Для изменения данных нажмите 2");
                Console.WriteLine("Для удаления данных о клиенте нажмите 3");
                Console.WriteLine("Для просмотра списка клиентов нажмите 4");
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
                                    $"987654321{i}",
                                    $"{DateTime.Now}",
                                    "admin",
                                    "created"
                                    ));
                        }
                        break;
                    case "1":
                        Console.WriteLine("Введите ФИО через пробел");
                        string fullNewName = Console.ReadLine();
                        Console.WriteLine("Введите номер телефона");
                        string newTelefonNumber = Console.ReadLine();
                        Console.WriteLine("Введите номер паспорта");
                        string newPasportNumber = Console.ReadLine();
                        user.AddClient(fullNewName, newTelefonNumber, newPasportNumber, $"{DateTime.Now}", $"{user.GetType()}", "created");
                        break;

                    case "2":
                        Console.WriteLine("Введите ID клиента для изменения его данных");
                        int id = Convert.ToInt32(Console.ReadLine());
                        user.PrintClient(id);
                        Console.WriteLine("Для изменения ФИО нажмите 1");
                        Console.WriteLine("Для изменения телефона нажмите 2");
                        Console.WriteLine("Для изменения номера паспорта нажмите 3");
                        switch (Console.ReadLine())
                        {
                            case "1":
                                Console.WriteLine("Введите ФИО через пробел");
                                user.ChangeFullName(id, Console.ReadLine());
                                break;
                            case "2":
                                Console.WriteLine("Введите новый номер телефона");
                                user.ChangeTelefonNumber(id, Console.ReadLine());
                                break;
                            case "3":
                                Console.WriteLine("Введите номер паспорта");
                                user.ChangePassportNumber(id, Console.ReadLine());
                                break;
                            default:
                                Console.WriteLine("неверная команда");
                                break;
                        }
                        user.PrintClient(id);
                        break;

                    case "3":
                        Console.WriteLine("Введите ID клиента");
                        int idDel = Convert.ToInt32(Console.ReadLine());
                        user.DelClient(idDel);
                        break;
                    case "4":
                        user.PrintClients();
                        break;
                    case "q":
                        runProgram = false;
                        using (FileStream fs = new FileStream("bankClients.json", FileMode.OpenOrCreate))
                        {
                            await JsonSerializer.SerializeAsync<ObservableCollection<Client>>(fs, Bank.Clients);
                            Console.WriteLine("Data has been saved to file");
                        }
                        break;
                    default: break;
                }

                Console.ReadLine();
            }


        }



    }
}
