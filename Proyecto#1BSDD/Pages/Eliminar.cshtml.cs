using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Proyecto_1BSDD.Pages
{
    public class EliminarModel : PageModel
    {
        private readonly IConfiguration _configuration;

        public EliminarModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public bool ShowModal32 { get; set; }
        public bool ShowModal33 { get; set; }
        public bool ShowModal34 { get; set; }
        public bool ShowModal35 { get; set; }
        public bool ShowModal36 { get; set; }
        public bool ShowModal37 { get; set; }
        public bool ShowModal38 { get; set; }
        public bool ShowModal39 { get; set; }
        public bool ShowModal40 { get; set; }
        public bool ShowModal41 { get; set; }
        public bool ShowModal42 { get; set; }
        public bool ShowModal43 { get; set; }
        public bool ShowModal44 { get; set; }
        public bool ShowModal45 { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPostAbrirModal32()
        {

            ShowModal32 = true;
            return Page();
        }
        public IActionResult OnPostAbrirModal33()
        {

            ShowModal33 = true;
            return Page();
        }

        public IActionResult OnPostAbrirModal34()
        {

            ShowModal34 = true;
            return Page();
        }

        public IActionResult OnPostAbrirModal35()
        {

            ShowModal35 = true;
            return Page();
        }

        public IActionResult OnPostAbrirModal36()
        {

            ShowModal36 = true;
            return Page();
        }

        public IActionResult OnPostAbrirModal37()
        {

            ShowModal37 = true;
            return Page();
        }


        public IActionResult OnPostAbrirModal38()
        {

            ShowModal38 = true;
            return Page();
        }

        public IActionResult OnPostAbrirModa39()
        {

            ShowModal39 = true;
            return Page();
        }

        public IActionResult OnPostAbrirModal40()
        {

            ShowModal40 = true;
            return Page();
        }

        public IActionResult OnPostAbrirModal41()
        {

            ShowModal41 = true;
            return Page();
        }

        public IActionResult OnPostAbrirModal42()
        {

            ShowModal42 = true;
            return Page();
        }

        public IActionResult OnPostAbrirModal43()
        {

            ShowModal43 = true;
            return Page();
        }

        public IActionResult OnPostAbrirModal44()
        {

            ShowModal44 = true;
            return Page();
        }

        public IActionResult OnPostAbrirModal45()
        {

            ShowModal44 = true;
            return Page();
        }

    }
}
