using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityApplication.Data;
using UniversityApplication.Services;

namespace Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private UniversityDataContext _universityDataContext;
        private IStudentRepository _studentRepository;
        private IAddressRepository _addressRepository;
        private ITranscriptRepository _transcriptRepository;
        private IExamRepository _examRepository;

        public RepositoryManager(UniversityDataContext universityDataContext)
        {
            _universityDataContext = universityDataContext;
        }


        public IStudentRepository Student
        {
            get
            {
                if (_studentRepository == null)
                {
                    _studentRepository = new StudentRepository(_universityDataContext);
                }

                return _studentRepository;
            }
        }

        public IAddressRepository Address
        {
            get
            {
                if (_addressRepository == null)
                {
                    _addressRepository = new AddressRepository(_universityDataContext);
                }

                return _addressRepository;
            }
        }

        public ITranscriptRepository Transcript
        {
            get
            {
                if (_transcriptRepository == null)
                {
                    _transcriptRepository = new TranscriptRepository(_universityDataContext);
                }

                return _transcriptRepository;
            }
        }

        public IExamRepository Exam
        {
            get
            {
                if (_examRepository == null)
                {
                    _examRepository = new ExamRepository(_universityDataContext);
                }

                return _examRepository;
            }
        }

        public void Save() => _universityDataContext.SaveChanges();
    }

}
