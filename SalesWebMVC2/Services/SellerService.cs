using SalesWebMVC2.Data;
using SalesWebMVC2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC2.Services
{
    public class SellerService
    {
        private readonly SalesWebMVC2Context _context;

        public SellerService(SalesWebMVC2Context context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        } 


    }
}
