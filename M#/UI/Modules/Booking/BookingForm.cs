using MSharp;

namespace Modules
{
    public class BookingForm : FormModule<Domain.Booking>
    {
        public BookingForm()
        {
            HeaderText("Booking details");

            Field(x => x.Customer);

            Field(x => x.Destination);

            Field(x => x.Date).AsDatePicker();

            button.Cancel();

            button.Save();

            AutoSet(x => x.Agency);
        }
    }
}