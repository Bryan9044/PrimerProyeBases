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
