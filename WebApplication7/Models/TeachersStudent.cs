using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Models
{
    public class TeachersStudent
    {
        public int StudentId { get; set; }
        public int TeacherId { get; set; }

        public Student Student { get; set; }
        public Teacher Teacher { get; set; }
    }
}
