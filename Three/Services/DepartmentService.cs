using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
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
            return Task.Run(() => _department.AsEnumerable());
        }

        public Task<Department> GetById(int id)
        {
            return Task.Run(() => _department.FirstOrDefault(x => x.Id == id));
        }
        public Task<CompanySummary> GetCompanySummary() {
            return Task.Run(() =>
            {
                return new CompanySummary
                {
                    EmployeeCount = _department.Sum(x => x.EmployeeCount),
                    AverageDepartmentEmployeeCount=(int)_department.Average(x=>x.EmployeeCount)
                };
            });                
        }
        public Task Add(Department department)
        {
            department.Id = _department.Max(x => x.Id) + 1;
            _department.Add(department);
            return Task.CompletedTask;
        }
    }
}
