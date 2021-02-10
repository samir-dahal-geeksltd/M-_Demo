using MSharp;

namespace Modules
{
    public class InvoiceForm : FormModule<Domain.Invoice>
    {
        public InvoiceForm()
        {
            HeaderText("Invoice details");

            RequestParam("clientId");

            Field(x => x.Client);
            Field(x => x.Date).AsDatePicker();
            Field(x => x.Amount);
            Field(x => x.Description);

            button.Cancel();
            button.Save();
           
            AutoSet(x => x.Client);
        }
    }
}