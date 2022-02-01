namespace BlazorWorkingScaffold.Server.Services.EmployeeService
{
    public class EmployeeService : IEmployeeService
    {
        private readonly DataContext _context;

        public EmployeeService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Employee>> GetAll()
        {
            var employees = await _context.Employees.ToListAsync();
            return employees;
        }
    }
}
