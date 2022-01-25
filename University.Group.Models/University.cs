using System.Collections.Generic;
using University.Group.Models.Faculties;


namespace University.Group.Models
{
    public sealed class University : StructureUnit
    {
        public List<Faculty> faculties = new List<Faculty>();

        public University(string name, string director, int phoneNumber, string adress, string email, string info)
        {
            Name = name;
            Director = director;
            PhoneNumber = phoneNumber;
            Address = adress;
            Email = email;
            AboutStructuralUnit = info;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
