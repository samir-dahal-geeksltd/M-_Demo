using MSharp;

public class ContactPage : RootPage
{
    public ContactPage()
    {
        Add<Modules.MainMenu>();

        //will be implemented soon
        OnStart(x => x.Go<Contact.ContactsPage>().RunServerSide());
    }
}