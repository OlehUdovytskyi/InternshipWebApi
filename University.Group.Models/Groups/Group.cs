namespace University.Group.Models.Groups
{
    internal class Group
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Curator { get; set; }
        public int Course { get; set; }
        public string EducationDegree { get; set; }

        public int FacultyId { get; set; }
        public Faculties.Faculty Faculty { get; set; }
    }
}
