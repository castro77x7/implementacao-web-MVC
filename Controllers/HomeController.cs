using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;
using LH.Pet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Cliente cliente1 = new Cliente(01, "Arthur A. Ferreira", "857.032.950-41", "arthur.antunes@sp.senai.br", "Madruga");
        Cliente cliente2 = new Cliente(02, "William Henry Gates", "039.618.250-09", "bill@microsoft.com", "Wind");
        Cliente cliente3 = new Cliente(03, "Thomas Faraday", "800.777.920-50", "thomas@billy.language.com", "Billy");
        Cliente cliente4 = new Cliente(04, "Jimmy O'Flannagan", "933.622.400-03", "jimyy@osdl.org", "Jamerson");
        Cliente cliente5 = new Cliente(05, "Grace Hopper", "911.702.988-00", "grace.hopper@cobol.com", "loboc");

        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag. listaClientes = listaClientes;

        Fornecedor fornecedor1 = new Fornecedor(01, "C# PET S/A", "14.182.102/0001-80", "C-SHARP@PET.org");
        Fornecedor fornecedor2 = new Fornecedor(02, "C# PET S/ASSS", "15.582.502/0001-50" , "C-SHARRP@PET.org");
        Fornecedor fornecedor3 = new Fornecedor(03, "C# PETBOOT S/A", "17.142.002/0001-60", "C-SHHARP@PET.org");
        Fornecedor fornecedor4 = new Fornecedor(04, "C# PETTIK S/A", "13.522.102/0001-10", "C-SHARPP@PET.org");
        Fornecedor fornecedor5 = new Fornecedor(05, "C# PETTKS S/A", "14.182.142/0001-00", "C-SSHARP@PET.org");
        
        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);

        ViewBag.listaFornecedores = listaFornecedores;

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
