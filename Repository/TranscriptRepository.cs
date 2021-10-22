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
    public class TranscriptRepository : RepositoryBase<Transcript>, ITranscriptRepository
    {
        public TranscriptRepository(UniversityDataContext universityDataContext) : base(universityDataContext)
        {
        }
    }
}
