using MSharp;

namespace Car
{
    class EnterPage : SubPage<CarPage>
    {
        public EnterPage()
        {
            Add<Modules.CarForm>();
        }
    }
}