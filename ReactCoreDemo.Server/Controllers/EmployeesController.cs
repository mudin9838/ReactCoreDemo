using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReactCoreDemo.Server.Models;

namespace ReactCoreDemo.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EmployeesController : ControllerBase
{
    private readonly ReactDemoCoreSpanishContext _context;

    public EmployeesController(ReactDemoCoreSpanishContext context)
    {
        _context = context;
    }

    [HttpGet]
    [Route("employees")]
    public async Task<IActionResult> GetEmployees()
    {
        List<Employee> employees = await _context.Employees.ToListAsync();
        return StatusCode(StatusCodes.Status200OK, employees);
    }
}
