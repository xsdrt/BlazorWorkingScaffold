global using BlazorWorkingScaffold.Shared;

namespace BlazorWorkingScaffold.Client.Services.EmployeeService
{
    public interface IEmployeeService
    {
        List<Employee> Employees { get; set; }
        Task GetEmployees();
    }
}
