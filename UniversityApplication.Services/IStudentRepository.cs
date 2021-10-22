using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityApplication.Data.Models;

namespace UniversityApplication.Services
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetallStudents(bool trackChanges);
        Student GetStudent(int studentId, bool trackChanges);

        Student GetStudentByAddress(int studentId,int addressId, bool trackChanges);
        
    }
}
