using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiTodo.Dto;
using WebApiTodo.Persistence;

namespace WebApiTodo.Service.Impl
{
    public class WarehouseServiceImpl : WarehouseService
    {
        private readonly ApplicationDbContext _context;

        public WarehouseServiceImpl(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<WarehouseProductDto> GetAllWithProducts()
        {
            return (
               from w in _context.Warehouses
               from wp in _context.WarehouseProduct.Where(x => x.WarehouseId == w.WarehouseId)
               select new WarehouseProductDto
               {
                   WarehouseName = w.Name,
                   ProductName = wp.Product.Name,
                   ProductPrice = wp.Product.Price
               }
           ).ToList();
        }
    }
}
