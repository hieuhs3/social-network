using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

using Data.Entity;
using Microsoft.EntityFrameworkCore;
namespace Repository.Repository
{
    public interface IProductRepository : IRepositoryBase<Product>
    {

    }
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }

    }
}
