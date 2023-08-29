using Application;
using Dapper;
using Data.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dapper.SqlMapper;

namespace Repository
{
    public class Library_StudentRepository : ILibrary_StudentRepository
    {

        public LibraryContext _Context; 
        public Library_StudentRepository(LibraryContext context)
        {
            _Context = context;

        }
        public async Task<string> AddAsync(Library_Student objstud)
        {
            using (IDbConnection dbConnection = new SqlConnection(_Context.Database.GetConnectionString()))
            {
                dbConnection.Open();
                var dynamicParameter = new DynamicParameters();
                var args = new Dictionary<string, object>()
                {
                    ["FirstName"] = objstud.FirstName,
                    ["LastName"] = objstud.LastName,
                    ["Mobile"] = objstud.Mobile,
                    ["Emnail"] = objstud.Emnail,
                };
                dynamicParameter.AddDynamicParams(args);
                var details = dbConnection.QuerySingleOrDefault< LibraryContext > ("AddStudents", dynamicParameter, commandType: CommandType.StoredProcedure);
                return null;
            }

                
            //return ExecuteScalar<string>(StoreProcedure.AddStudents, dynamicParameter);
        }

        public async Task<List<Library_Student>> GetAllAsync()
        {
            return _Context.Library_Students.ToList();  
        }

        public async Task<int> UpdateStudent(Library_Student student)
        {
            using (IDbConnection dbConnection = new SqlConnection(_Context.Database.GetConnectionString()))
            {
                dbConnection.Open();
                var dynamicParameters = new DynamicParameters();
                var args = new Dictionary<string, object>()
                {
                    ["id"] = student.id,
                    ["FirstName"] = student.FirstName,
                    ["LastName"] = student.LastName,
                    ["Mobile"] = student.Mobile,
                    ["Emnail"] = student.Emnail,
                };
                dynamicParameters.AddDynamicParams(args);
                var details = dbConnection.QuerySingleOrDefault<LibraryContext>("AddStudents", dynamicParameters, commandType: CommandType.StoredProcedure);
                return 1;
            }

        }
        public async Task<int> DelStudent(int id)
        {
            using (IDbConnection dbConnection = new SqlConnection(_Context.Database.GetConnectionString()))
            {
                dbConnection.Open();
                var dynamicParameters = new DynamicParameters();
                var args = new Dictionary<string, object>()
                {
                    ["id"] = id
                };
                dynamicParameters.AddDynamicParams(args);
                var details = dbConnection.QuerySingleOrDefault<LibraryContext>("DeleteStudent", dynamicParameters, commandType: CommandType.StoredProcedure);
                return 1;
            }

        }


    }
}
