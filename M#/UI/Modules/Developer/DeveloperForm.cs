using MSharp;

namespace Modules
{
    public class DeveloperForm : FormModule<Domain.Developer>
    {
        public DeveloperForm()
        {
            HeaderText("Developer details");

            Field(x => x.FirstName);

            Field(x => x.LastName);

            button.Cancel();

            button.Save();
        }
    }
}