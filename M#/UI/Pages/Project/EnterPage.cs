using MSharp;

namespace Project
{
    class EnterPage : SubPage<ProjectPage>
    {
        public EnterPage()
        {
            Layout(Layouts.AdminDefault);

            Add<Modules.ProjectForm>();
        }
    }
}
