using MSharp;

namespace Customer
{
    public class CustomersPage : SubPage<CustomerPage>
    {
        public CustomersPage()
        {
            Add<Modules.CustomersList>();
        }
    }
}