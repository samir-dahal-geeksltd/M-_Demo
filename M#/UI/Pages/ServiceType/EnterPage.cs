using MSharp;

namespace ServiceType
{
    class EnterPage : SubPage<ServiceTypePage>
    {
        public EnterPage()
        {
            Layout(Layouts.AdminDefault);

            Add<Modules.ServiceTypeForm>();
        }
    }
}