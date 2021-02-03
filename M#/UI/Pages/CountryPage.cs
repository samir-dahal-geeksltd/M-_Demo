using MSharp;

public class CountryPage : RootPage
{
    public CountryPage()
    {
        Add<Modules.MainMenu>();

        OnStart(x => x.Go<Country.CountriesPage>().RunServerSide());
    }
}