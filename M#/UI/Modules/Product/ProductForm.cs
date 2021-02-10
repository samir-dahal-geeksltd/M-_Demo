using MSharp;

namespace Modules
{
    public class ProductForm : FormModule<Domain.Product>
    {
        public ProductForm()
        {
            HeaderText("Product details");

            Field(x => x.Name);
            Field(x => x.Category).AsDropDown();
           // Field(x => x.Category).Control(ControlType.DropdownList);

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