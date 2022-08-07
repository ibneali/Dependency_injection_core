using Dependency_injection_core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dependency_injection_core.Reposiory
{
    public class EmployeeRepo : IEmployee
    {
        private readonly applicationconnection _context;

        public EmployeeRepo(applicationconnection context)
        {
            _context = context;
        }

        public void create(Employee obj)
        {
            _context.Employees.Add(obj);
            
        }

        public void dalete(int id)
        {
            var data = _context.Employees.Find(id);
            _context.Remove(data);
        }

        public List<Employee> getall()
        {
            return _context.Employees.ToList();
        }

        public Employee getbyId(int id)
        {
            return _context.Employees.FirstOrDefault(x => x.EmployeeId == id);
        }

        public void save()
        {
            _context.SaveChanges();
        }

        public void update(Employee obj)
        {
            _context.Employees.Update(obj);
        }
    }
}
