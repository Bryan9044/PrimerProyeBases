using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace Proyecto_1BSDD.Pages
{
    public class Index1Model : PageModel
    {
        private readonly IConfiguration _configuration;
        public Index1Model(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public bool ShowModal18 { get; set; }
        public bool ShowModal19 { get; set; }
        public bool ShowModal20 { get; set; }
        public bool ShowModal21 { get; set; }
        public bool ShowModal22 { get; set; }
        public bool ShowModal23 { get; set; }
        public bool ShowModal24 { get; set; }
        public bool ShowModal25 { get; set; }
        public bool ShowModal26 { get; set; }
        public bool ShowModal27 { get; set; }
        public bool ShowModal28 { get; set; }
        public bool ShowModal29 { get; set; }
        public bool ShowModal30 { get; set; }
        public bool ShowModal31 { get; set; }
        public void OnGet()
        {
        } 

        public IActionResult OnPostAbrirModal18()
        {
            ShowModal18 = true;
            return Page();
        }

        public IActionResult OnPostAbrirModal19()
        {
            ShowModal19 = true;
            return Page();
        }
        public IActionResult OnPostAbrirModal20()
        {
            ShowModal20 = true;
            return Page();
        }
        public IActionResult OnPostAbrirModal21()
        {
            ShowModal21 = true;
            return Page();
        }

        public IActionResult OnPostAbrirModal22()
        {
            ShowModal22 = true;
            return Page();
        }
        public IActionResult OnPostAbrirModal23()
        {
            ShowModal23 = true;
            return Page();
        }
        public IActionResult OnPostAbrirModal24()
        {
            ShowModal24 = true;
            return Page();
        }
        public IActionResult OnPostAbrirModal25()
        {
            ShowModal25 = true;
            return Page();
        }
        public IActionResult OnPostAbrirModal26()
        {
            ShowModal26 = true;
            return Page();
        }

        public IActionResult OnPostAbrirModal27()
        {
            ShowModal27 = true;
            return Page();
        }

        public IActionResult OnPostAbrirModal28()
        {
            ShowModal28 = true;
            return Page();
        }

        public IActionResult OnPostAbrirModal29()
        {
            ShowModal29 = true;
            return Page();
        }

        public IActionResult OnPostAbrirModal30()
        {
            ShowModal30 = true;
            return Page();
        }

        public IActionResult OnPostAbrirModal31()
        {
            ShowModal31 = true;
            return Page();
        }


    }
}
