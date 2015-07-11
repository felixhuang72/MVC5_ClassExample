using System;
using System.Linq;
using System.Collections.Generic;
	
namespace WebApplication2.Models
{   
	public  class ProductRepository : EFRepository<Product>, IProductRepository
	{
        public override IQueryable<Product> All()
        {
            return base.All().Where(p=>p.Active==true);
        }

        public IQueryable<Product> getTop10Data()
        {
            return this.All().Take(10);
        }

        public Product Find(int id)
        {
            return this.All().FirstOrDefault(p => p.ProductId == id);
        }
	}

	public  interface IProductRepository : IRepository<Product>
	{

	}
}