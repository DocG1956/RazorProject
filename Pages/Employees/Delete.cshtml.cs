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
    public class DeleteModel : PageModel
    {
        private readonly IEmployeeRepository employeeRepository;

        public DeleteModel(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        public void OnGet(int Id)
        {
        }

        public void OnPut(int Id)
        {

        }

        public void OnPost(Employee employee)
        {

        }
    }
}
