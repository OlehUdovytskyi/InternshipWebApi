using System.Collections.Generic;
using University.Group.Models.Departments;

namespace University.Group.Models.Faculties
{
    public sealed class Faculty
    {
        public string Name { get; set; }
        public string Director { get; set; }
        public uint PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public List<Department> Departments;

        public Faculty()
        {
            Departments = new List<Department>()
            {
                new Department
                {
                    Name = "Кафедра буріння свердловин",
                    Director = "Фем'як Я. І.",
                    PhoneNumber = 0342727137,
                    Email = "drill@nung.edu.ua",
                    OfficeNumber = 0502,
                },

                new Department
                {
                    Name = "Кафедра видобування нафти і газу",
                    Director = "Кондрат О. Р.",
                    PhoneNumber = 0342727141,
                    Email = "rengr@nung.edu.ua",
                    OfficeNumber = 0513,
                },

                new Department
                {
                    Name = "Кафедра газонафтопроводів",
                    Director = "Чернова О. Т.",
                    PhoneNumber = 0342727139,
                    Email = "gnps@nung.edu.ua",
                    OfficeNumber = 0342,
                }
            };
        }
    }
}
