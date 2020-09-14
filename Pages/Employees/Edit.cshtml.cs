using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Models;
using Services;

namespace RazorProject.Pages.Employees
{
    public class EditModel : PageModel
    {
        private readonly IEmployeeRepository employeeRepository;

        public EditModel(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        public void OnGet(int Id)
        {
        }

        public void OnPut(Employee employee)
        {

        }
    }
}
