using MSharp;

namespace Modules
{
    public class ServiceTypesList : ListModule<Domain.ServiceType>
    {
        public ServiceTypesList()
        {
            HeaderText("Service types")
                .ShowHeaderRow()
                .ShowFooterRow();

            Column(x => x.Name);

            column.Edit<ServiceType.EnterPage>();

            column.Delete();

            button.New<ServiceType.EnterPage>();       
        }
    }
}