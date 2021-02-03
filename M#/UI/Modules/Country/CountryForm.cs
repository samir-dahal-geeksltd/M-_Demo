using MSharp;

namespace Modules
{
    public class CountryForm : FormModule<Domain.Country>
    {
        public CountryForm()
        {
            Field(x => x.Name);

            Button("Cancel").CausesValidation(false).Icon(FA.Stop)
                .OnClick(x => x.CloseModal());

            Button("Save").IsDefault().Icon(FA.Save).OnClick(x =>
            {
                x.SaveInDatabase();
                x.GentleMessage("Saved successfully.");
                x.CloseModal(Refresh.Full);
            });
        }
    }
}