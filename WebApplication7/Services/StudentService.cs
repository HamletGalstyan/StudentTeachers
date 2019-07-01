using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication7.Models;

namespace WebApplication7.Services
{
    public class StudentService : IStudentService
    {
        private  MyContext _myContext;
        
        public StudentService(MyContext myContext)
        {
            _myContext = myContext;
        }
        public async Task AddAsinc(SudentRequestModel studentmodel)
        {
            await _myContext.AddAsync(new Student {
                Name = studentmodel.Name,
                Surname = studentmodel.Surname,
                Age = studentmodel.Age
            });
            await _myContext.SaveChangesAsync();
        }

        public async Task DeleteAsinc(Student student)
        {
             _myContext.Students.Remove(student);
              await _myContext.SaveChangesAsync();
        }

        public Task EditAsinc(SudentRequestModel student)
        {
            throw new NotImplementedException();
        }

        public  IEnumerable<Student> GetAllAsinc()
        {
            IEnumerable<Student> entity = _myContext.Students;
            return entity;

        }

        public Student GetbyId(int id)
        {
            var student1 = _myContext.Students.Where(s => s.StudentId == id).SingleOrDefault();

            return student1;
        }

        public async Task UpdateAsync(Student student)
        {
            var studentUpdated = GetbyId(student.StudentId);

            studentUpdated.Name = student.Name;
            studentUpdated.Surname = student.Surname;
            studentUpdated.Age = student.Age;

            _myContext.Students.Update(studentUpdated);
            await _myContext.SaveChangesAsync();
        }
    }
}
