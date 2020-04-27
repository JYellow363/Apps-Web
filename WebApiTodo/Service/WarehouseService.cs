using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiTodo.Dto;

namespace WebApiTodo.Service
{
    public interface WarehouseService
    {
        List<WarehouseProductDto> GetAllWithProducts();
    }
    }