using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ExemploAspNetMvc.Models;

namespace ExemploAspNetMvc.Controllers;

//UserDto, UserCreateDto, UserFormDto
public class UserRequest
{
    public string Nome { get; set; }
    public string Email { get; set; }
}

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult PrimeiraAction()
    {
        return View();
    }

    public string TesteQuerryString([FromQuery] string q, string nome)
    {
        return $"Chegou aqui {q} para {nome}";
    }

    public string TesteFormData([FromForm] UserRequest userRequest, [FromHeader] string valor) 
    {
        return $"Nome:  {userRequest.Nome}, Email: {userRequest.Email}, valor: {valor}";
    }

    public IActionResult Formulario()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
