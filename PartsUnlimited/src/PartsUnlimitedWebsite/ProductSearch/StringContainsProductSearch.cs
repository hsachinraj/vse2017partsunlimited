using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using PartsUnlimited.Models;
using System;

namespace PartsUnlimited.ProductSearch
{
    public class StringContainsProductSearch : IProductSearch
    {
        private readonly IPartsUnlimitedContext _context;

        public StringContainsProductSearch(IPartsUnlimitedContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> Search(string query)
        {
            var lowercase_query = query.ToLower();

            var q = _context.Products
                .Where(p => p.Title.ToLower().Contains(lowercase_query));

            if (q == null || q.Count() == 0)
            {
                try
                {
                    throw new System.Exception("Missing or Can't find product: " + lowercase_query);
                }
                catch(Exception)
                {
                    //log this for product identification
                }

            }
            
            return await q.ToListAsync();
        }
    }
}
