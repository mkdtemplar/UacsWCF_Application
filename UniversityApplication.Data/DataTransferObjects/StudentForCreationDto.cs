using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApplication.Data.DataTransferObjects
{
    public class StudentForCreationDto
    {
        
        public string FirstName { get; set; }

        public string LastName { get; set; }

       

        public string Mail { get; set; }

        public string StudentIndex { get; set; }

      

        public int AddressId { get; set; }
    }
}
