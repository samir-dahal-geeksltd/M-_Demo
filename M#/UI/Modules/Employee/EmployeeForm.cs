using MSharp;

namespace Modules
{
    public class EmployeeForm : FormModule<Domain.Employee>
    {
        public EmployeeForm()
        {
            HeaderText("Employee details");

            Field(x => x.FirstName);

            Field(x => x.LastName);

            Field(x => x.Email);

            Field(x => x.IDCard);

            button.Cancel();

            button.Save();

        }
    }
}