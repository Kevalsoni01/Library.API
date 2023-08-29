using Application;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.IRepository
{
    public interface ILibrary_StudentRepository
    {
        Task<string> AddAsync(Library_Student objstud);

        Task<List<Library_Student>> GetAllAsync();

        Task<int> UpdateStudent(Library_Student student);

        Task<int> DelStudent(int id);
    }
}
