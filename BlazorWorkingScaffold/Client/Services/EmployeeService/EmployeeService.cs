using System.Net.Http.Json;

namespace BlazorWorkingScaffold.Client.Services.EmployeeService
{
    public class EmployeeService : IEmployeeService
    {
        private readonly HttpClient _http;

        public EmployeeService(HttpClient http)
        {
            _http = http;
        }
        public List<Employee> Employees { get ; set; } = new List<Employee>();

        public async Task GetEmployees()
        {
            Employees = await _http.GetFromJsonAsync<List<Employee>>("api/employee");
        }
    }
}
