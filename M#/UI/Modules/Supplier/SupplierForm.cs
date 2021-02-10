using MSharp;

namespace Modules
{
    public class SupplierForm : FormModule<Domain.Supplier>
    {
        public SupplierForm()
        {
            HeaderText("Supplier details");

            Field(x => x.CompanyName);

            Field(x => x.AddressLine1);

            Field(x => x.AddressLine2);

            Field(x => x.Town);

            Field(x => x.Postcode);

            MasterDetail(x => x.Services, s =>
            {
                s.HeaderText("Supplier service details");

                s.Field(x => x.ServiceType).Control(ControlType.DropdownList);

                s.Field(x => x.Price);

                s.Button("Add service").OnClick(x => x.AddMasterDetailRow());
            }).MinCardinality(3);

            button.Cancel();

            button.Save();
        }
    }
}