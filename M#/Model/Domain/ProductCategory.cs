using MSharp;

namespace Domain
{
    public class ProductCategory : EntityType
    {
        public ProductCategory()
        {
            String("Name").Mandatory();

            InverseAssociate<Product>("Products", "Category");
        }
    }
}