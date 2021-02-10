using MSharp;

namespace Modules
{
    public class AgencyForm : FormModule<Domain.Agency>
    {
        public AgencyForm()
        {
            HeaderText("Agency details");

            Field(x => x.Name);

            Field(x => x.Notes);

            button.Cancel();

            button.Save();
           
        }
    }
}