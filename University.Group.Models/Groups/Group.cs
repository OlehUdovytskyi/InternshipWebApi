namespace University.Group.Models.Groups
{
    internal class Group : StructureUnit
    {
        public Group(string name, string director, int phoneNumber, string adress, string email, string info)
        {
            Name = name;
            Director = director;
            PhoneNumber = phoneNumber;
            Address = adress;
            Email = email;
            AboutStructuralUnit = info;
        }
    }
}