namespace BlazorWorkingScaffold.Server.Services.EmployeeService
{
    public interface IEmployeeService
    {
        Task<List<Employee>> GetAll();
    }
}
