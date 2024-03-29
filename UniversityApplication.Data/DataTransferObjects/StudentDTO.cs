﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApplication.Data.DataTransferObjects
{
    public class StudentDTO
    {
        public int id { get; set; }
        
        public DateTime? EnrollmentDate { get; set; }

        public DateTime? DOB { get; set; }

        public string Mail { get; set; }

        public string StudentIndex { get; set; }

        public decimal? GPA { get; set; }

        public int AddressId { get; set; }
        public string FullName { get; set; }
        
    }
}
