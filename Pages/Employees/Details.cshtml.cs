using Microsoft.AspNetCore.Mvc.RazorPages;
using Models;
using Services;

namespace RazorProject.Pages.Employees
{
    public class DetailsModel : PageModel
    {
        private readonly IEmployeeRepository employeeRepository;

        public DetailsModel(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        public Employee Employee { get; private set; }

        public void OnGet(int id)
        {
            Employee = employeeRepository.GetEmployee(id);
        }
    }
}
