using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int  Age { get; set; }
        virtual public IQueryable<TeachersStudent> Teachers { get; set; }
    }
}
