using MSharp;

namespace Country
{
    public class EnterPage : SubPage<CountriesPage>
    {
        public EnterPage()
        {
            Layout(Layouts.AdminDefaultModal);

            Add<Modules.CountryForm>();
        }
    }
}