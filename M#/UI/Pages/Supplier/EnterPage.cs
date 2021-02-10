using MSharp;

namespace Supplier
{
    class EnterPage : SubPage<SupplierPage>
    {
        public EnterPage()
        {
            Layout(Layouts.AdminDefault);

            Add<Modules.SupplierForm>();
        }
    }
}