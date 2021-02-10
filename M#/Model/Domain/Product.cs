using MSharp;

namespace Domain
{
    public class Product : EntityType
    {
        public Product()
        {
            String("Name");

            Associate<ProductCategory>("Category");

            InverseManyToMany<Shop>("Shops", "Products");
        }
    }
}