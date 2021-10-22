using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UniversityApplication.Data;
using UniversityApplication.Data.Models;
using UniversityApplication.Services;

namespace Repository
{
    public class StudentRepository : RepositoryBase<Student>, IStudentRepository
    {
        public StudentRepository(UniversityDataContext universityDataContext) : base(universityDataContext)
        {
        }

        public IEnumerable<Student> GetallStudents(bool trackChanges) =>
            FindAll(trackChanges).OrderBy(c => c.FirstName).ToList();

        public Student GetStudent(int studentId, bool trackChanges) =>
            FindByCondition(c => c.Id.Equals(studentId), trackChanges).SingleOrDefault();

        public Student GetStudentByAddress(int studentId, int addressId, bool trackChanges) =>
            FindByCondition(s => s.Id.Equals(studentId) && s.AddressId.Equals(addressId), trackChanges).SingleOrDefault();

        public void CreateStudent(Student student) => Create(student);
    }
}
