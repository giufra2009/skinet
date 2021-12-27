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
    public class ProductTypesSeed : ISeedData
    {
        public async Task FillSeedData(string pathUrl, StoreContext context)
        {
            if (!context.ProductTypes.Any())
            {
                var typesData = File.ReadAllText(pathUrl);

                var types = JsonSerializer.Deserialize<List<ProductType>>(typesData);

                foreach (var item in types)
                {
                    context.ProductTypes.Add(item);
                }

                await context.SaveChangesAsync();
            }
        }
    }
}
