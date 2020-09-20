using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Three.Models;

namespace Three.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly List<Department> _department = new List<Department>();
        public DepartmentService()
        {
            _department.Add(new Department
            {
                Id = 1,
                Name = "HR",
                EmployeeCount = 16,
                Location = "Beijing"
            });
            _department.Add(new Department
            {
                Id = 2,
                Name = "R$D",
                EmployeeCount = 52,
                Location = "Shanghai"
            });
            _department.Add(new Department
            {
                Id = 3,
                Name = "Sales",
                EmployeeCount = 200,
                Location = "China"
            });
        }
        public Task<IEnumerable<Department>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Department> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
