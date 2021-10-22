using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApplication.Data.DataTransferObjects
{
    public class StudentDTO
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string FullAddress { get; set; }
    }
}
