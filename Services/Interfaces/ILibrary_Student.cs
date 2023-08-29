using Application;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface ILibrary_Student
    {
        string AddLibStud(Library_Student objstudent);
         List<Library_Student> GetAllStudents();

        int UpdateStudent(Library_Student objstudent);
        int DelStudent(int studid);
    }
}
