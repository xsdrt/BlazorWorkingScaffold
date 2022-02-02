using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorWorkingScaffold.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)     //Inject our EmployeeService, create the field...
        {
            _employeeService = employeeService;
        }

        [HttpGet]       //Using this call so can test with Swagger otherwise the web api would recogonize the GetAll
                        //as an HttpGet call anyway, so other than using swagger do not need it, but no damage antway... 
        public async Task<ActionResult<List<Employee>>> GetAll()  //This is for SwaggerUi use also to test the
                                                                  //calls to get the values and types
                                                                  //(using the class with the type)
                                                                  //instead of just the interface...
        {
            return Ok(await _employeeService.GetAll());  //So we will return a 200 code...
        }
    }
}
