using MSharp;

namespace Agency
{
    class ViewPage : SubPage<AgencyPage>
    {
        public ViewPage()
        {
            Add<Modules.AgencyView>();

            Add<Modules.BookingsList>();
        }
    }
}