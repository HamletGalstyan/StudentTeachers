using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication7.Models;

namespace WebApplication7.Services
{
    public interface IStudentService
    {
        Task AddAsinc(SudentRequestModel student);
        Task DeleteAsinc(Student student);
        Task EditAsinc(SudentRequestModel student);
        IEnumerable<Student> GetAllAsinc();
        Student GetbyId(int id);
        Task UpdateAsync(Student student);

    }
}
