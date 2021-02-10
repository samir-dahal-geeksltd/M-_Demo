using MSharp;

namespace Modules
{
    public class ShopForm : FormModule<Domain.Shop>
    {
        public ShopForm()
        {
            HeaderText("Shop details");

            Field(x => x.Name);
            Field(x => x.Address);
            Field(x => x.ProductsLinks).AsCheckBoxes(Arrange.Vertical);

           // Field(x => x.ProductsLinks).Control(ControlType.VerticalCheckBoxes);

            button.Save();
            button.Cancel();

            //Button("Cancel").OnClick(x => x.ReturnToPreviousPage());

            //Button("Save").IsDefault().Icon(FA.Check)
            //.OnClick(x =>
            //{
            //    x.SaveInDatabase();
            //    x.GentleMessage("Saved successfully.");
            //    x.ReturnToPreviousPage();
            //});
        }
    }
}