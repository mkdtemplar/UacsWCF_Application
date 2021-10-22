using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityApplication.Data.Models;

namespace UniversityApplication.Services
{
    public interface IAddressRepository
    {
        IEnumerable<Address> GetAddresses(int addressId, bool trackChanges);
        Address GetStudentAddress(int studentId, int addressId, bool trackChanges);
    }
}
