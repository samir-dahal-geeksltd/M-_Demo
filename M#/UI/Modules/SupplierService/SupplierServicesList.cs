using MSharp;

namespace Modules
{
    public class SupplierServicesList : ListModule<Domain.SupplierService>
    {
        public SupplierServicesList()
        {
            HeaderText("Supplier services")
                .ShowHeaderRow()
                .ShowFooterRow();

            Column(x => x.Supplier);

            Column(x => x.ServiceType);

            Column(x => x.Price);
        }
    }
}