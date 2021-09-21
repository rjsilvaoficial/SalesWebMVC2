using SalesWebMVC2.Models;
using SalesWebMVC2.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC2.Data
{
    public class SeedingService
    {
        private SalesWebMVC2Context _context;

        public SeedingService(SalesWebMVC2Context context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() || _context.Seller.Any() || _context.SalesRecord.Any())
            {
                return;
            }

            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Eletronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");

            Seller s1 = new Seller(1, "Bob", "bob@gmail.com", new DateTime(1998, 4, 21), 100.0, d1);
            Seller s2 = new Seller(2, "Doug", "bob@gmail.com", new DateTime(1999, 1, 21), 100.0, d2);
            Seller s3 = new Seller(3, "Snoop", "bob@gmail.com", new DateTime(1980, 2, 21), 100.0, d3);
            Seller s4 = new Seller(4, "Sand", "bob@gmail.com", new DateTime(1993, 3, 21), 100.0, d4);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2018, 09, 25), 1100.0, SalesStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2018, 08, 20), 1100.0, SalesStatus.Pending, s2);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2018, 07, 15), 1100.0, SalesStatus.Pending, s3);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2018, 06, 10), 1100.0, SalesStatus.Canceled, s4);

            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4);
            _context.SalesRecord.AddRange(r1, r2, r3, r4);

            _context.SaveChanges();


        }
    }
}
