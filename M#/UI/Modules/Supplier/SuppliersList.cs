using MSharp;

namespace Modules
{
    public class SuppliersList : ListModule<Domain.Supplier>
    {
        public SuppliersList()
        {
            HeaderText("Suppliers")
                .ShowHeaderRow()
                .ShowFooterRow();

            Column(x => x.CompanyName);

            Column(x => x.Address);

            Column(x => x.Services);

            column.Edit<Supplier.EnterPage>();

            column.Delete();

            button.New<Supplier.EnterPage>();
        }
    }
}