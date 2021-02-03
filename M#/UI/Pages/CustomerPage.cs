using MSharp;

public class CustomerPage : RootPage
{
    public CustomerPage()
    {
        Add<Modules.MainMenu>();

        OnStart(x => x.Go<Customer.CustomersPage>().RunServerSide());
    }
}