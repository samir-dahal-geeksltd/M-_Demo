using MSharp;

namespace Contact
{
    public class ContactsPage : SubPage<ContactPage>
    {
        public ContactsPage()
        {
            Layout(Layouts.AdminDefault);

            //will be implemented soon
            Add<Modules.ContactsList>();
        }
    }
}