using System.Collections.Generic;
using University.Group.Models.Faculties;

namespace University.Group.Models.Departments
{
    internal class MockDepartment : IDepartment
    {
        public List<Departments.Department> GetDepartment
        {
            get
            {
                return new List<Departments.Department>
                {
                    new Departments.Department
                    {
                        Name = "Кафедра буріння свердловин",
                        Director = "Фем'як Я. І.",
                        PhoneNumber = 0342727137,
                        Email = "drill@nung.edu.ua",
                        OfficeNumber = 0502,
                        //Faculty = "Інститут нафтогазової інженерії"
                    },

                    new Departments.Department
                    {
                        Name = "Кафедра видобування нафти і газу",
                        Director = "Кондрат О. Р.",
                        PhoneNumber = 0342727141,
                        Email = "rengr@nung.edu.ua",
                        OfficeNumber = 0513,
                        //Faculty = "Інститут нафтогазової інженерії"
                    },

                    new Departments.Department
                    {
                        Name = "Кафедра газонафтопроводів",
                        Director = "Чернова О. Т.",
                        PhoneNumber = 0342727139,
                        Email = "gnps@nung.edu.ua",
                        OfficeNumber = 0342,
                        //Faculty = "Інститут нафтогазової інженерії"
                    },

                    new Departments.Department
                    {
                        Name = "Кафедра нафтогазових машин",
                        Director = "Федорових Я. Т.",
                        PhoneNumber = 0342727101,
                        Email = "no@nung.edu.ua",
                        OfficeNumber = 7301,
                        //Faculty = "Інститут інженерної механіки"
                    },

                    new Departments.Department
                    {
                        Name = "Кафедра інженерної графіки",
                        Director = "Шкіца Л. Є.",
                        PhoneNumber = 0342724719,
                        Email = "ikg@nung.edu.ua",
                        OfficeNumber = 7301,
                        //Faculty = "Інститут інженерної механіки"
                    },

                    new Departments.Department
                    {
                        Name = "Кафедра автомобільного транспорту",
                        Director = "Криштопа С. І.",
                        PhoneNumber = 0342727148,
                        Email = "trans@nung.edu.ua",
                        OfficeNumber = 4109,
                        //Faculty = "Інститут інженерної механіки"
                    },

                    new Departments.Department
                    {
                        Name = "Кафедра геології",
                        Director = "Михайлів І. Р.",
                        PhoneNumber = 0342727121,
                        Email = "grn@nung.edu.ua",
                        OfficeNumber = 5321,
                        //Faculty = "Інститут природничих наук"
                    },

                    new Departments.Department
                    {
                        Name = "Кафедра екології",
                        Director = "Адаменко Я. О.",
                        PhoneNumber = 0342505942,
                        Email = "ecology@nung.edu.ua",
                        OfficeNumber = 5211,
                        //Faculty = "Інститут природничих наук"
                    },

                    new Departments.Department
                    {
                        Name = "Кафедра менеджменту",
                        Director = "Полянська А. С.",
                        PhoneNumber = 0342725875,
                        Email = "reg@nung.edu.ua",
                        OfficeNumber = 3227,
                        //Faculty = "Інститут економіки та менеджменту"
                    },

                    new Departments.Department
                    {
                        Name = "Кафедра обліку",
                        Director = "Кафка С. М.",
                        PhoneNumber = 0342727117,
                        Email = "oa@nung.edu.ua",
                        OfficeNumber = 1501,
                        //Faculty = "Інститут економіки та менеджменту"
                    },

                    new Departments.Department
                    {
                        Name = "Кафедра архітектури",
                        Director = "Василишин Я. В.",
                        PhoneNumber = 0342727192,
                        Email = "kafap@nung.edu.ua",
                        OfficeNumber = 4411,
                        //Faculty = "Інститут архітектури"
                    },

                    new Departments.Department
                    {
                        Name = "Кафедра будівництва",
                        Director = "Артим В. І.",
                        PhoneNumber = 4110,
                        Email = "budmech@nung.edu.ua",
                        OfficeNumber = 4110,
                        //Faculty = "Інститут архітектури"
                    },

                    new Departments.Department
                    {
                        Name = "Кафедра інженерії програмного забезпечення",
                        Director = "Шекета В. І.",
                        PhoneNumber = 0973376402,
                        Email = "",
                        OfficeNumber = 1416,
                        //Faculty = "Інститут інформаційних технологій"
                    },

                    new Departments.Department
                    {
                        Name = "Кафедра комп'ютерних систем і мереж",
                        Director = "Мельничук С. І.",
                        PhoneNumber = 0342504521,
                        Email = "ksm@nung.edu.ua",
                        OfficeNumber = 1413,
                        //Faculty = "Інститут інформаційних технологій"
                    },

                    new Departments.Department
                    {
                        Name = "Кафедра англійської мови",
                        Director = "Тимків Н. М.",
                        PhoneNumber = 0342727169,
                        Email = "english@nung.edu.ua",
                        OfficeNumber = 5217,
                        //Faculty = "Інститут гуманітарної підготовки"
                    },

                    new Departments.Department
                    {
                        Name = "Кафедра документознавства",
                        Director = "Романишин Ю. Л.",
                        PhoneNumber = 0342724956,
                        Email = "doc@nung.edu.ua",
                        OfficeNumber = 0405,
                        //Faculty = "Інститут гуманітарної підготовки"
                    }
                };
            }
        }
    }
}
