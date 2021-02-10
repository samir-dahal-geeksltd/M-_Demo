using MSharp;

namespace Modules
{
    public class CategoryForm : FormModule<Domain.ProductCategory>
    {
        public CategoryForm()
        {
            HeaderText("Category details");

            Field(x => x.Name);

           // Button("Cancel").OnClick(x => x.ReturnToPreviousPage());
            button.Save();
            button.Cancel();

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