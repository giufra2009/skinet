using Core.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class ProductBrandSeed : ISeedData
    {
        public async Task FillSeedData(string pathUrl, StoreContext context)
        {
            if (!context.ProductBrands.Any())
            {
                var brandsData = File.ReadAllText(pathUrl);

                var brands = JsonSerializer.Deserialize<List<ProductBrand>>(brandsData);

                foreach (var item in brands)
                {
                    context.ProductBrands.Add(item);
                }

                await context.SaveChangesAsync();
            }
        }
    }
}
