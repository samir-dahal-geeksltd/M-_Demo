using MSharp;

namespace Modules
{
    public class ProjectForm : FormModule<Domain.Project>
    {
        public ProjectForm()
        {
            HeaderText("Project details");

            Field(x => x.Name);

            button.Cancel();

            button.Save();
        }
    }
}