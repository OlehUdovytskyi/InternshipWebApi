using System.Collections.Generic;
using University.Group.Models.Groups;

namespace University.Group.Models.Faculties
{
    public sealed class Faculty : StructureUnit, IFaculty
    {
        List<IGroup> groups = new List<IGroup>();

        public Faculty(string name, string director, int phoneNumber, string adress, string email, string info)
        {
            Name = name;
            Director = director;
            PhoneNumber = phoneNumber;
            Address = adress;
            Email = email;
            AboutStructuralUnit = info;
        }

        public IEnumerable<IGroup> GetGroups()
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            return "Faculty";
        }
    }
}
