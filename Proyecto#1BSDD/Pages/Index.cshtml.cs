using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

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
    public bool ShowModal46 { get; set; }
    public bool ShowModal47 { get; set; }
    public bool ShowModal48 { get; set; }
    public bool ShowModal49 { get; set; }

    // Cambiado a List<string> para almacenar códigos de departamentos
    public List<string> Departamentos { get; set; } = new List<string>(); // Inicialización
    public List<string> Familias { get; set; } = new List<string>(); // Inicialización
    public List<string> Zonas { get; set; } = new List<string>(); // Inicialización
    public List<string> Sectores { get; set; } = new List<string>(); // Inicialización
    public List<string> Estados { get; set; } = new List<string>(); // Inicialización
    public List<string> Prioridades { get; set; } = new List<string>();
    public List<string> TipoCasos { get; set; } = new List<string>();
    public List<string> Probabilidades { get; set; } = new List<string>();
    public List<string> Puestos { get; set; } = new List<string>();
    public List<string> Generos { get; set; } = new List<string>();

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

        // Inicializar listas
        Familias = new List<string>();
        Zonas = new List<string>();
        Sectores = new List<string>();
        Estados = new List<string>();
        Prioridades = new List<string>();
        TipoCasos = new List<string>();
        Probabilidades = new List<string>();
        Puestos = new List<string>();
        Generos = new List<string>();
        // Obtener los departamentos de la base de datos
        string connectionString = _configuration.GetConnectionString("DefaultConnection");

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string query = "SELECT Codigo FROM Departamento"; // Asegúrate de que este campo existe en tu tabla
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Departamentos.Add(reader.GetString(0)); // Agregar el código del departamento como string
                    }
                }
            }
        }

        // Aquí podrías agregar lógica adicional para llenar Familias, Zonas, Sectores y Estados si es necesario





        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string query = "SELECT CodigoFamilia FROM Familia";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Familias.Add(reader.GetString(0));
                    }
                }
            }


        }


        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string query = "SELECT Nombre FROM Zona";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Zonas.Add(reader.GetString(0));
                    }
                }
            }




        }

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string query = "SELECT Nombre FROM Sector";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Sectores.Add(reader.GetString(0));
                    }
                }
            }


        }

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string query = "SELECT TipoEstado FROM Estado"; // Asegúrate de que este campo existe en tu tabla
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Estados.Add(reader.GetString(0)); // Asegúrate de que esto se ajusta a tu tipo de datos
                    }
                }
            }


        }



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

        ShowModal45 = true;
        return Page();
    }
    public IActionResult OnPostAbrirModal46()
    {

        ShowModal46 = true;
        return Page();
    }
    public IActionResult OnPostAbrirModal47()
    {

        ShowModal47 = true;
        return Page();
    }
    public IActionResult OnPostAbrirModal48()
    {

        ShowModal48 = true;
        return Page();
    }
    public IActionResult OnPostAbrirModal49()
    {

        ShowModal49 = true;
        return Page();
    }



    public IActionResult OnPostGuardarDepartamento(string projectCodigoDepar, string projectNombreDepartamento)
    {
        Console.WriteLine($"Código Departamento: {projectCodigoDepar}, Nombre Departamento: {projectNombreDepartamento}");

        string connectionString = _configuration.GetConnectionString("DefaultConnection");

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string query = "INSERT INTO Departamento (Codigo, Nombre) VALUES (@Codigo, @Nombre)";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Codigo", projectCodigoDepar);
                command.Parameters.AddWithValue("@Nombre", projectNombreDepartamento);
                command.ExecuteNonQuery();
            }

        }

        return RedirectToPage();
    }




    public IActionResult OnPostEliminarDepartamento(string projectCodigoDeparEli)
    {
        Console.WriteLine($"Código Departamento a Eliminar: {projectCodigoDeparEli}");

        string connectionString = _configuration.GetConnectionString("DefaultConnection");

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string query = "DELETE FROM Departamento WHERE Codigo = @Codigo";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Codigo", projectCodigoDeparEli);
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("Departamento eliminado correctamente.");
                }
                else
                {
                    Console.WriteLine("No se encontró un departamento con ese código.");
                }
            }
        }

        // Actualizar la lista de departamentos después de la eliminación
        return RedirectToPage();
    }









    public IActionResult OnPostGuardarFamilias(string projectCodigoFamilias, string projectFamilias, string projectDescripcionFamilia, byte projectActivoF)
    {

        string connectionString = _configuration.GetConnectionString("DefaultConnection");

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string query = "INSERT INTO Familia (CodigoFamilia, Nombre,Descripcion,Activo) VALUES (@CodigoFamilia, @Nombre,@Descripcion,@Activo)";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@CodigoFamilia", projectCodigoFamilias);
                command.Parameters.AddWithValue("@Nombre", projectFamilias);
                command.Parameters.AddWithValue("@Descripcion", projectDescripcionFamilia);
                command.Parameters.AddWithValue("@Activo", projectActivoF);
                command.ExecuteNonQuery();
            }
        }


        return RedirectToPage();
    }


    public IActionResult OnPostEliminarFamilias(string projectCodigoFamiliaEli)
    {
        Console.WriteLine($"Código Familia a Eliminar: {projectCodigoFamiliaEli}");

        string connectionString = _configuration.GetConnectionString("DefaultConnection");

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string query = "DELETE FROM Familia WHERE CodigoFamilia = @CodigoFamilia";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@CodigoFamilia", projectCodigoFamiliaEli);
                command.ExecuteNonQuery();
            }
        }

        // Actualizar la lista de departamentos después de la eliminación
        return RedirectToPage();
    }


    public IActionResult OnPostEliminarZonas(String projectNombreEliZ)
    {

        string connectionString = _configuration.GetConnectionString("DefaultConnection");

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string query = "DELETE FROM Zona WHERE Nombre = @Nombre";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Nombre", projectNombreEliZ);
                command.ExecuteNonQuery();
            }
        }

        // Actualizar la lista de departamentos después de la eliminación
        return RedirectToPage();
    }

    public IActionResult OnPostGuardarSector(string projectNombreSector, string projectSectorDescripcion)
    {

        string connectionString = _configuration.GetConnectionString("DefaultConnection");

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string query = "INSERT INTO Sector (Nombre,Descripcion) VALUES (@Nombre,@Descripcion)";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Nombre", projectNombreSector);
                command.Parameters.AddWithValue("@Descripcion", projectSectorDescripcion);

                command.ExecuteNonQuery();
            }
        }


        return RedirectToPage();
    }

    public IActionResult OnPostEliminarSectores(String projectNombreEliS)
    {

        string connectionString = _configuration.GetConnectionString("DefaultConnection");

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string query = "DELETE FROM Sector WHERE Nombre = @Nombre";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Nombre", projectNombreEliS);
                command.ExecuteNonQuery();
            }
        }

        // Actualizar la lista de departamentos después de la eliminación
        return RedirectToPage();
    }


    public IActionResult OnPostGuardarEstado(string projectTipoEstado, string projectEstadoDescripcion)
    {

        string connectionString = _configuration.GetConnectionString("DefaultConnection");

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string query = "INSERT INTO Estado (TipoEstado,Descripcion) VALUES (@TipoEstado,@Descripcion)";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@TipoEstado", projectTipoEstado);
                command.Parameters.AddWithValue("@Descripcion", projectEstadoDescripcion);

                command.ExecuteNonQuery();
            }
        }


        return RedirectToPage();
    }

    public IActionResult OnPostEliminarEstados(String projectTipoEstadoEli)
    {

        string connectionString = _configuration.GetConnectionString("DefaultConnection");

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string query = "DELETE FROM Estado WHERE TipoEstado = @TipoEstado";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@TipoEstado", projectTipoEstadoEli);
                command.ExecuteNonQuery();
            }
        }

        // Actualizar la lista de departamentos después de la eliminación
        return RedirectToPage();
    }




    public IActionResult OnPostGuardarProbabilidades(byte projectPorcentaje, string projectNombreProb)
    {

        string connectionString = _configuration.GetConnectionString("DefaultConnection");

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string query = "INSERT INTO Probabilidad (Porcentaje , ProbabilidadEstimada) VALUES (@Porcentaje, @ProbabilidadEstimada)";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Porcentaje", projectPorcentaje);
                command.Parameters.AddWithValue("@ProbabilidadEstimada", projectNombreProb);
                command.ExecuteNonQuery();
            }
        }


        return RedirectToPage();
    }

}




