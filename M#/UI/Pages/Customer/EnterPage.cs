using MSharp;

namespace Customer
{
    public class EnterPage : SubPage<CustomerPage>
    {
        public EnterPage()
        {
            Layout(Layouts.AdminDefaultModal);

            Add<Modules.CustomerForm>();
        }
    }
}