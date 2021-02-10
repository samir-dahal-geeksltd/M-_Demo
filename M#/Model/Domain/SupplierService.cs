using MSharp;

namespace Domain
{
    public class SupplierService : EntityType
    {
        public SupplierService()
        {
            Associate<Supplier>("Supplier");

            Associate<ServiceType>("Service type");

            Money("Price");

            ToStringExpression("ServiceType?.Name");
        }
    }
}