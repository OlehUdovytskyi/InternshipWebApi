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
    }
}
