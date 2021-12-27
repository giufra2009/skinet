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
    public class ProductSeed : ISeedData
    {
        public async Task FillSeedData(string pathUrl, StoreContext context)
        {
            if (!context.Products.Any())
            {
                var productsData = File.ReadAllText(pathUrl);

                var products = JsonSerializer.Deserialize<List<Product>>(productsData);

                foreach (var item in products)
                {
                    context.Products.Add(item);
                }

                await context.SaveChangesAsync();
            }
        }
    }
}
