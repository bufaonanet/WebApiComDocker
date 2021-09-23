using MongoDB.Driver;
using WebApiComDocker.Entities;

namespace WebApiComDocker.Data
{
    public interface IProductContext
    {
        IMongoCollection<Product> Products { get; }
    }
}
