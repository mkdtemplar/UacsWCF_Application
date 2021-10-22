using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityApplication.Data;
using UniversityApplication.Data.Models;
using UniversityApplication.Services;

namespace Repository
{
    public class ExamRepository : RepositoryBase<Exam>, IExamRepository
    {
        public ExamRepository(UniversityDataContext universityDataContext) : base(universityDataContext)
        {
        }
    }
}
