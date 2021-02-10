using MSharp;

namespace Shop
{
    class EnterPage : SubPage<ShopPage>
    {
        public EnterPage()
        {
            Add<Modules.ShopForm>();
        }
    }
}