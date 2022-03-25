using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using WindowsServiceExample.Data.Contexts;
using WindowsServiceExample.Data.Models;

namespace WindowsServiceExample.Business.ServiceBusiness
{
    public class WindowsServiceBusiness
    {
        private static readonly HttpClient _Client = new HttpClient();
        public async Task MigrateData()
        {
            try
            {
                HttpResponseMessage response = await _Client.GetAsync("https://localhost:5003/api/Product");
                if (response.EnsureSuccessStatusCode().IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    var allProducts = JsonConvert.DeserializeObject<List<ModelHttp>>(responseBody);
                    using (var context = new ProductsHttpContext())
                    {
                        var productsList = new List<Product>();
                        foreach (var product in allProducts)
                        {
                            var dataToInsert = new Product
                            {
                                Description = product.Description,
                                Price = product.Price,
                                PurchaseDate = product.PurchaseDate,
                                Type = product.Type
                            };
                            productsList.Add(dataToInsert);
                        }
                        context.Product.AddRange(productsList);
                        await context.SaveChangesAsync();
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
