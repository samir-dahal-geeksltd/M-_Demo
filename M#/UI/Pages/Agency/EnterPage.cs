using MSharp;

namespace Agency
{
    class EnterPage : SubPage<AgencyPage>
    {
        public EnterPage()
        {
            Layout(Layouts.AdminDefault);

            Add<Modules.AgencyForm>();
        }
    }
}