using System.Collections.Generic;
using University.Group.Models.Faculties;


namespace University.Group.Models
{
    public sealed class University
    {
        public List<Faculty> Faculties;
        public string Name { get; set; } = "ІФНТУНГ";
        public string Rector { get; set; } = "Крижанівський Є. І.";

        public University()
        {
            Faculties = new List<Faculty>()
            {
                new Faculty
                {
                    Name = "Інститут нафтогазової інженерії",
                    Director = "Витязь О. Ю.",
                    PhoneNumber = 0342727182,
                    Address = "Карпатська 15",
                    Email = "ingi@nung.edu.ua"
                },
                new Faculty
                {
                    Name = "Інститут інженерної механіки",
                    Director = "Романишин Л. І.",
                    PhoneNumber = 0342727181,
                    Address = "Карпатська 15",
                    Email = "iim@nung.edu.ua"
                },
                new Faculty
                {
                    Name = "Інститут природничих наук",
                    Director = "Омельченко В. Г.",
                    PhoneNumber = 0342727181,
                    Address = "Карпатська 15",
                    Email = "grf@nung.edu.ua"
                }
            };
        }

        //public List<Faculty> GetFaculty
        //{
        //    get
        //    {
        //        return new List<Faculty>
        //        {
        //            new Faculty
        //            {
        //                Name = "Інститут нафтогазової інженерії",
        //                Director = "Витязь О. Ю.",
        //                PhoneNumber = 0342727182,
        //                Address = "Карпатська 15",
        //                Email = "ingi@nung.edu.ua"
        //            },
        //            new Faculty
        //            {
        //                Name = "Інститут інженерної механіки",
        //                Director = "Романишин Л. І.",
        //                PhoneNumber = 0342727181,
        //                Address = "Карпатська 15",
        //                Email = "iim@nung.edu.ua"
        //            },
        //            new Faculty
        //            {
        //                Name = "Інститут природничих наук",
        //                Director = "Омельченко В. Г.",
        //                PhoneNumber = 0342727181,
        //                Address = "Карпатська 15",
        //                Email = "grf@nung.edu.ua"
        //            },
        //            new Faculty
        //            {
        //                Name = "Інститут економіки та менеджменту",
        //                Director = "Запухляк І. Б.",
        //                PhoneNumber = 0342725876,
        //                Address = "Шопена 1",
        //                Email = "ineu@nung.edu.ua"
        //            },
        //            new Faculty
        //            {
        //                Name = "Інститут архітектури",
        //                Director = "Мазур М. П.",
        //                PhoneNumber = 0342725874,
        //                Address = "Карпатська 15",
        //                Email = "abe@nung.edu.ua"
        //            },
        //            new Faculty
        //            {
        //                Name = "Інститут інформаційних технологій",
        //                Director = "Лютак І. З.",
        //                PhoneNumber = 0342727400,
        //                Address = "Карпатська 15",
        //                Email = "fit@nung.edu.ua"
        //            },
        //            new Faculty
        //            {
        //                Name = "Інститут гуманітарної підготовки",
        //                Director = "Дзвінчук Д. І.",
        //                PhoneNumber = 0342754741,
        //                Address = "Короля Данила 13",
        //                Email = "fuid@nung.edu.ua"
        //            }
        //        };
        //    }
        //}

        //public override string ToString() => Name;
    }
}
