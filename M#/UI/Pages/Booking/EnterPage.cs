using MSharp;

namespace Booking
{
    class EnterPage : SubPage<BookingPage>
    {
        public EnterPage()
        {
            Layout(Layouts.AdminDefaultModal);

            Add<Modules.BookingForm>();
        }
    }
}
