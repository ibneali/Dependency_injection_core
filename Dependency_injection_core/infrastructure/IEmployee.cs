using Dependency_injection_core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dependency_injection_core
{
   public interface IEmployee
    {
        List<Employee> getall();
        Employee getbyId(int id);
        void create(Employee obj);
        void dalete(int id);
        void update(Employee obj);
        void save();

    }
}
