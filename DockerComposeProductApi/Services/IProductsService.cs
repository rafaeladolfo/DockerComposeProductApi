using DockerComposeProductApi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DockerComposeProductApi.Services
{
    public interface IProductsService
    {
        public ICollection<Product> GetAll();
    }
}
