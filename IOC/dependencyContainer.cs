using Microsoft.Extensions.DependencyInjection;
using Repository;
using Repository.IRepository;
using Services.Interfaces;
using Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC
{
    public class dependencyContainer
    {
        public static void REgisterServices(IServiceCollection services)
        {
            services.AddScoped<ILibrary_Student, Library_StudentServices>();
            services.AddScoped<ILibrary_StudentRepository, Library_StudentRepository>();
        }
    }
}
