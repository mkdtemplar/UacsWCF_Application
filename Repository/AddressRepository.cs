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
    public class AddressRepository : RepositoryBase<Address>, IAddressRepository
    {
        public AddressRepository(UniversityDataContext universityDataContext) : base(universityDataContext)
        {
        }

        public IEnumerable<Address> GetAddresses(int addressId, bool trackChanges) =>
            FindByCondition(e => e.Id.Equals(addressId), trackChanges).OrderBy(e => e.City);

        public Address GetStudentAddress(int studentId, int addressId, bool trackChanges) =>
            FindByCondition(s => s.Id.Equals(studentId) && s.Id.Equals(addressId), trackChanges).SingleOrDefault();
    }
}
