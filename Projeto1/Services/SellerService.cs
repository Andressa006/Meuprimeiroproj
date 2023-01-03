using Projeto1.Models;
using Projeto1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto1.Services
{
    public class SellerService
    {
        private readonly Projeto1Context _context;

        public SellerService(Projeto1Context context)
        {
            _context = context;
        }
      
        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
     
    }
}
