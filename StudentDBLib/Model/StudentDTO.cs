using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDBLib.Model
{
    public class StudentDTO
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public bool IsMale { get; set; }
        public string Date { get; set; }
    }
}
