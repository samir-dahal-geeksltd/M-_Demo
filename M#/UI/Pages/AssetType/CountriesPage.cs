using MSharp;

namespace Country
{
    public class CountriesPage : SubPage<CountryPage>
    {
        public CountriesPage()
        {
            //will be implemented soon
            Add<Modules.CountriesList>();
        }
    }
}