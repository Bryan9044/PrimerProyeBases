using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;

public class IndexModel : PageModel
{
    private readonly IConfiguration _configuration;

    public IndexModel(IConfiguration configuration)
    {
        _configuration = configuration;
    }


    // Propiedades para mostrar u ocultar los modales
    public bool ShowModal1 { get; set; }
    public bool ShowModal2 { get; set; }
    public bool ShowModal3 { get; set; }
    public bool ShowModal4 { get; set; }
    public bool ShowModal5 { get; set; }
    public bool ShowModal6 { get; set; }
    public bool ShowModal7 { get; set; }
    public bool ShowModal8 { get; set; }
    public bool ShowModal9 { get; set; }
    public bool ShowModal10 { get; set; }
    public bool ShowModal11 { get; set; }
    public bool ShowModal12 { get; set; }
    public bool ShowModal13 { get; set; }
    public bool ShowModal14 { get; set; }


    // Método GET para inicializar los valores
    public void OnGet()
    {
        ShowModal1 = false;
        ShowModal2 = false;
        ShowModal3 = false;
        ShowModal4 = false;
        ShowModal5 = false;
        ShowModal6 = false;
        ShowModal7 = false;
        ShowModal8 = false;
        ShowModal9 = false;
        ShowModal10 = false;
        ShowModal11 = false;
        ShowModal12 = false;
    }

    // Método POST para abrir un modal específico
    public IActionResult OnPostAbrirModal()
    {
        ShowModal1 = true;
        ShowModal2 = false;
        ShowModal3 = false;
        ShowModal4 = false;
        ShowModal5 = false;
        ShowModal6 = false;
        ShowModal7 = false;
        ShowModal8 = false;
        ShowModal9 = false;
        return Page();
    }
    public IActionResult OnPostAbrirModal2()
    {

        ShowModal2 = true;
        return Page();
    }
    public IActionResult OnPostAbrirModal3()
    {

        ShowModal3 = true;
        return Page();
    }

    public IActionResult OnPostAbrirModal4()
    {

        ShowModal4 = true;
        return Page();
    }

    public IActionResult OnPostAbrirModal5()
    {

        ShowModal5 = true;
        return Page();
    }

    public IActionResult OnPostAbrirModal6()
    {

        ShowModal6 = true;
        return Page();
    }

    public IActionResult OnPostAbrirModal7()
    {

        ShowModal7 = true;
        return Page();
    }


    public IActionResult OnPostAbrirModal8()
    {

        ShowModal8 = true;
        return Page();
    }

    public IActionResult OnPostAbrirModal9()
    {

        ShowModal9 = true;
        return Page();
    }

    public IActionResult OnPostAbrirModal10()
    {

        ShowModal10 = true;
        return Page();
    }

    public IActionResult OnPostAbrirModal11()
    {

        ShowModal11 = true;
        return Page();
    }

    public IActionResult OnPostAbrirModal12()
    {

        ShowModal12 = true;
        return Page();
    }

    public IActionResult OnPostAbrirModal13()
    {

        ShowModal13 = true;
        return Page();
    }

    public IActionResult OnPostAbrirModal114()
    {

        ShowModal14 = true;
        return Page();
    }
}
