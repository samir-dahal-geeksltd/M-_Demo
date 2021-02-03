using MSharp;

namespace Contact
{
    public class EnterPage : SubPage<ContactsPage>
    {
        public EnterPage()
        {
            Layout(Layouts.AdminDefault);

            Add<Modules.ContactForm>();
        }
    }

}