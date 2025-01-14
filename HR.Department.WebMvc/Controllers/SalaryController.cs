﻿using System.Threading.Tasks;
using HR.Department.WebMvc.Filters;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HR.Department.WebMvc.Controllers
{
    [RefreshToken]
    public class SalaryController : BaseController
    {
        public SalaryController(IHttpContextAccessor contextAccessor) : base(contextAccessor) { }

        public async Task<IActionResult> UpdateSalary()
        {
            var response = await HttpClient
                .PutAsync("employee", default);

            if (response.IsSuccessStatusCode)
            {
                var count = await response.Content.ReadAsStringAsync();
                return RedirectToAction("Index", new { count });
            }
            return RedirectToAction("Index", "Home");
        }

        [HttpGet("{count}")]
        public IActionResult Index(string count) => View("Index", count);
    }
}
