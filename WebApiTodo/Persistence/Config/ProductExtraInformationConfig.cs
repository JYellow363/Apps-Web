using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiTodo.Model;

namespace WebApiTodo.Persistence.Config
{
    public class ProductExtraInformationConfig
    {
        public ProductExtraInformationConfig(EntityTypeBuilder<ProductExtraInformation> entityBuilder)
        {
            entityBuilder.Property(x => x.SKU).IsRequired().HasMaxLength(20);
            entityBuilder.Property(x => x.Description).IsRequired().HasMaxLength(500);
        }
    }
}
