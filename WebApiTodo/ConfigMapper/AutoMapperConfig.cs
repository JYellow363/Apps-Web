using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiTodo.Commons;
using WebApiTodo.Dto;
using WebApiTodo.Model;

namespace WebApiTodo.ConfigMapper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Client, ClientDto>();
            CreateMap<Product, ProductDto>();

            CreateMap<DataCollection<Client>, DataCollection<ClientDto>>();

            CreateMap<DataCollection<Product>, DataCollection<ProductDto>>();

            CreateMap<WarehouseProduct, WarehouseProductDto>();

            CreateMap<Order, OrderDto>();
            CreateMap<OrderDetail, OrderDetailDto>();
            CreateMap<DataCollection<Order>, DataCollection<OrderDto>>();

            // Order Create
            CreateMap<OrderCreateDto, Order>();
            CreateMap<OrderDetailCreateDto, OrderDetail>();
        }
    }
}
