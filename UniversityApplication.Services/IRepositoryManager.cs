using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApplication.Services
{
    public interface IRepositoryManager
    {
        IStudentRepository Student { get; }
        IAddressRepository Address { get; }
        ITranscriptRepository Transcript { get; }
        IExamRepository Exam { get; }

        void Save();
    }
}
