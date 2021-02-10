using MSharp;

namespace Modules
{
    public class BookingsList : ListModule<Domain.Booking>
    {
        public BookingsList()
        {
            HeaderText("Bookings");

            Column(x => x.Customer);

            Column(x => x.Date);

            Column(x => x.Destination);

            column.Edit<Booking.EnterPage>().OnClick(x => x.PopUp<Booking.EnterPage>()
                   .Send("item", "item.ID")
                   .Send("agency", "item.AgencyId"));

            //ButtonColumn("Edit").Icon(FA.Edit)
            //   .OnClick(x => x.PopUp<Booking.EnterPage>()
            //       .Send("item", "item.ID")
            //       .Send("agency", "item.AgencyId"));

            button.New<Booking.EnterPage>().Icon(FA.Plus)
                .OnClick(x => x.PopUp<Booking.EnterPage>()
                    .Send("agency", "info.Agency.ID"));

            ViewModelProperty("Agency", "Agency").FromRequestParam("item");

            DataSource("await info.Agency.Bookings.GetList()");
        }
    }
}