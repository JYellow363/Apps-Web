using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiTodo.Dto;

namespace WebApiTodo.Service
{
    public interface ProductService
    {
        List<ProductDto> GetAll();
        ProductDto GetById(int id);
        ProductDto Create(ProductCreateDto model);
        void Update(int id, ProductUpdateDto model);
        void Remove(int id);
    }
}
