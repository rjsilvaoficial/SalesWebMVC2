using SalesWebMVC2.Data;
using SalesWebMVC2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC2.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMVC2Context _context;

        public DepartmentService (SalesWebMVC2Context context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(department => department.Name).ToList();
        }
    }
}
