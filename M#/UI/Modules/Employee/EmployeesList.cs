using MSharp;

namespace Modules
{
    public class EmployeesList : ListModule<Domain.Employee>
    {
        public EmployeesList()
        {
            HeaderText("Employees")
                .ShowHeaderRow();

            Column(x => x.FirstName);

            Column(x => x.LastName);

            Column(x => x.Email).EmptyMarkup("N/A");

            Column(x => x.IDCard);

            Column(x => x.Warnings).DisplayExpression("@Html.Raw(item.Warnings)");

            column.Edit<Employee.EnterPage>();

            column.Delete();
           
            button.New<Employee.EnterPage>();
          
        }
    }
}