﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiTodo.Dto;
using WebApiTodo.Model;
using WebApiTodo.Persistence;

namespace WebApiTodo.Service.Impl
{
    public class ProductServiceImpl : ProductService
    {

        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public ProductServiceImpl(ApplicationDbContext context,
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<ProductDto> GetAll()
        {
            return _mapper.Map<List<ProductDto>>(
                  _context.Products.OrderByDescending(x => x.ProductId)
                               .AsQueryable()
                               .ToList()
             );
        }

        public ProductDto GetById(int id)
        {
            return _mapper.Map<ProductDto>(
                _context.Products.Single(x => x.ProductId == id)
           );
        }


        public ProductDto Create(ProductCreateDto model)
        {
            var entry = new Product
            {
                Name = model.Name,
                Description = model.Description,
                Price = model.Price
            };

            _context.Add(entry);
            _context.SaveChanges();

            return _mapper.Map<ProductDto>(entry);
        }

        public void Update(int id, ProductUpdateDto model)
        {
            var entry = _context.Products.Single(x => x.ProductId == id);

            entry.Name = model.Name;
            entry.Description = model.Description;
            entry.Price = model.Price;
            _context.SaveChanges();
        }

        public void Remove(int id)
        {
            _context.Remove(new Product
            {
                ProductId = id
            });
            _context.SaveChanges();
        }
    }
}
