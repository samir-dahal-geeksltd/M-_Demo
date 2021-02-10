using MSharp;

namespace Modules
{
    public class ServiceTypeForm : FormModule<Domain.ServiceType>
    {
        public ServiceTypeForm()
        {
            HeaderText("Add/Edit Service type");

            Field(x => x.Name);

            button.Cancel();

            button.Save();
            
        }
    }
}