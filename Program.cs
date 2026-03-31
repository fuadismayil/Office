using Office.Models;

namespace Office
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> workers =
                [
                new Developer
                {
                    Id = 101,
                    FirstName = "Adem",
                    LastName = "Imanov",
                    PhoneNumber = "+994 10 212 34 56",
                    Address = "Baki, Xetai Rayonu",
                    Email = "imanovadem004@gmail.com",
                    ProjectCount = 10,
                    Speciality = "FrontEnd"
                },

                new Developer
                {
                    Id = 102,
                    FirstName = "Orxan",
                    LastName = "Aliyev",
                    PhoneNumber = "+994 50 123 45 67",
                    Address = "Baki, Yasamal",
                    Email = "orxan.aliyev@mail.com",
                    ProjectCount = 7,
                    Speciality = "Backend"
                },
                new Developer
                {
                    Id = 103,
                    FirstName = "Nicat",
                    LastName = "Mammadov",
                    PhoneNumber = "+994 55 765 43 21",
                    Address = "Sumqayit",
                    Email = "nicat.dev@mail.com",
                    ProjectCount = 5,
                    Speciality = "FullStack"
                },

                new Manager
                {
                    Id = 201,
                    FirstName = "Aysel",
                    LastName = "Huseynova",
                    PhoneNumber = "+994 70 111 22 33",
                    Address = "Baki, Nizami",
                    Email = "aysel.manager@mail.com",
                    Salary = 2500
                },
                new Manager
                {
                    Id = 202,
                    FirstName = "Rasim",
                    LastName = "Quliyev",
                    PhoneNumber = "+994 77 222 33 44",
                    Address = "Gence",
                    Email = "rasim.q@mail.com",
                    Salary = 2700
                },

                new SMMManager
                {
                    Id = 301,
                    FirstName = "Leyla",
                    LastName = "Karimova",
                    PhoneNumber = "+994 51 333 44 55",
                    Address = "Baki, Sabuncu",
                    Email = "leyla.smm@mail.com",
                    WorkHours = 40
                },
                new SMMManager
                {
                    Id = 302,
                    FirstName = "Gunel",
                    LastName = "Ismayilova",
                    PhoneNumber = "+994 55 444 55 66",
                    Address = "Baki, Suraxani",
                    Email = "gunel.smm@mail.com",
                    WorkHours = 35
                },
                new SMMManager
                {
                    Id = 303,
                    FirstName = "Tural",
                    LastName = "Abbasov",
                    PhoneNumber = "+994 50 555 66 77",
                    Address = "Mingecevir",
                    Email = "tural.smm@mail.com",
                    WorkHours = 45
                },
                new SMMManager
                {
                    Id = 304,
                    FirstName = "Sevda",
                    LastName = "Rahimova",
                    PhoneNumber = "+994 70 666 77 88",
                    Address = "Baki, Binagadi",
                    Email = "sevda.smm@mail.com",
                    WorkHours = 38
                },

                new Saler
                {
                    Id = 401,
                    FirstName = "Elvin",
                    LastName = "Hasanov",
                    PhoneNumber = "+994 77 777 88 99",
                    Address = "Baki, Narimanov",
                    Email = "elvin.sales@mail.com",
                    Salary = 1500,
                    Benefit = 300
                },
                new Saler
                {
                    Id = 402,
                    FirstName = "Kamran",
                    LastName = "Aliyev",
                    PhoneNumber = "+994 50 888 99 00",
                    Address = "Sumqayit",
                    Email = "kamran.sales@mail.com",
                    Salary = 1400,
                    Benefit = 250
                },
                new Saler
                {
                    Id = 403,
                    FirstName = "Murad",
                    LastName = "Jafarov",
                    PhoneNumber = "+994 55 999 00 11",
                    Address = "Baki, Khirdalan",
                    Email = "murad.sales@mail.com",
                    Salary = 1600,
                    Benefit = 400
                },
                new Saler
                {
                    Id = 404,
                    FirstName = "Rauf",
                    LastName = "Ismayilov",
                    PhoneNumber = "+994 70 000 11 22",
                    Address = "Gence",
                    Email = "rauf.sales@mail.com",
                    Salary = 1550,
                    Benefit = 350
                },
                new Saler
                {
                    Id = 405,
                    FirstName = "Zaur",
                    LastName = "Haciyev",
                    PhoneNumber = "+994 51 111 22 33",
                    Address = "Baki, Yasamal",
                    Email = "zaur.sales@mail.com",
                    Salary = 1450,
                    Benefit = 280
                },
                new Saler
                {
                    Id = 406,
                    FirstName = "Samir",
                    LastName = "Mammadli",
                    PhoneNumber = "+994 55 222 33 44",
                    Address = "Shirvan",
                    Email = "samir.sales@mail.com",
                    Salary = 1700,
                    Benefit = 500
                },
            ];
            
            workers.ForEach(worker => worker.GetInfo());
            Console.WriteLine();


            for (int i = 0; i < workers.Count; i++)
            {
                if (workers[i] is Saler saler)
                {
                    saler.Salary *= 1.10;
                }
                if (workers[i] is SMMManager smmManager && smmManager.Id == 302)
                {
                    smmManager.WorkHours -= 3;
                }
                if (workers[i] is Developer developer)
                {
                    developer.ProjectCount += 2;
                }
                if (workers[i] is Manager manager)
                {
                    manager.Salary *= 1.30;
                }
            }
            workers.ForEach(worker => worker.GetInfo());
        }
    }
}