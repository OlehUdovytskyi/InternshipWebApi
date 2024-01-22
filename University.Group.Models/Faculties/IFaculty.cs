using System.Collections.Generic;

namespace University.Group.Models.Faculties
{
    interface IFaculty
    {
        List<Faculty> GetFaculty { get; }
    }
}
