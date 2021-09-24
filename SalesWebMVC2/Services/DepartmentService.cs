using Microsoft.EntityFrameworkCore;
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

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(department => department.Name).ToListAsync();
        }
    }
}
