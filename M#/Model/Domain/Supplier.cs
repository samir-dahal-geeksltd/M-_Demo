using MSharp;

namespace Domain
{
    public class Supplier : EntityType
    {
        public Supplier()
        {
            String("Company name");

            String("Address line 1");

            String("Address line 2");

            String("Town");

            String("Postcode");

            String("Address")
                .Calculated()
                .Getter("new[] { AddressLine1, AddressLine2, Town, Postcode }.ToString(\", \")");

            InverseAssociate<SupplierService>("Services", "Supplier");
        }
    }
}