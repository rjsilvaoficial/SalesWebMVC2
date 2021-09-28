using Microsoft.EntityFrameworkCore;
using SalesWebMVC2.Data;
using SalesWebMVC2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC2.Services
{
    public class SalesRecordService
    {
        private readonly SalesWebMVC2Context _context;

        public SalesRecordService(SalesWebMVC2Context context)
        {
            _context = context;
        }

        public async Task<List<SalesRecord>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)
        {
            IQueryable<SalesRecord> result = from obj in _context.SalesRecord select obj; //se der ruim colocar var no tipo
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Date >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Date <= maxDate.Value);
            }
            return await result
                .Include(x => x.Seller)
                .Include(x => x.Seller.Department)
                .OrderByDescending(x => x.Date)
                .ToListAsync();

        }
    }
}
