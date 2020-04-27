using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiTodo.Model;

namespace WebApiTodo.Persistence.Config
{
    public class WarehouseConfig
    {
        public WarehouseConfig(EntityTypeBuilder<Warehouse> entityBuilder)
        {
            entityBuilder.HasData(

                new Warehouse
                {
                    WarehouseId = 101,
                    Name = "Zona A"
                },
                new Warehouse
                {
                WarehouseId = 102,
                Name = "Zona B"

                }
            );
        }
    }
}
