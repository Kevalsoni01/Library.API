using Application;
using Repository;
using Repository.IRepository;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class Library_StudentServices : ILibrary_Student
    {
        private ILibrary_StudentRepository _StudentRepository;

        public Library_StudentServices(ILibrary_StudentRepository Repository)
        {
            _StudentRepository = Repository;
        }

        public string AddLibStud(Library_Student objstudent)
        {
            return _StudentRepository.AddAsync(objstudent).Result;
        }

        public List<Library_Student> GetAllStudents()
        {
            return _StudentRepository.GetAllAsync().Result;
        }


        public int UpdateStudent(Library_Student objstudent)
        {
            return _StudentRepository.UpdateStudent(objstudent).Result;
        }

        public int DelStudent(int studid)
        {
            return _StudentRepository.DelStudent(studid).Result;
        }
    }
}
