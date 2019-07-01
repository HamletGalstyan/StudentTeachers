using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Services
{
    public static class StudentServiceExtension
    {
        public static IServiceCollection AddStudent(this IServiceCollection servicecollection)
        {
            return servicecollection.AddScoped<IStudentService, StudentService>();
        }
    }
}
