using MSharp;

namespace Modules
{
    public class ClientForm : FormModule<Domain.Client>
    {
        public ClientForm()
        {
            HeaderText("Client details");

            Field(x => x.Company);

            button.Cancel();
            button.Save();
        }
    }
}