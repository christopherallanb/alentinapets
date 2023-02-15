using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using valentinapets.Models;

namespace valentinapets.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger) => _logger = logger;

    public IActionResult Index()
    {

        //instancia tipo cliente
        Cliente cliente1 = new Cliente(01, "Ethan Winters", "997.679.464-97", "Ethan@gmail.com", "cachorro");
        Cliente cliente2 = new Cliente(02, "leon s. keneddy", "576.089.004-23", "leons@gmail.com", "gato");
        Cliente cliente3 = new Cliente(03, "Claire Redfield", "264.770.804-51", "claire@gmail.com", "macaco");
        Cliente cliente4 = new Cliente(04, "Chris Redfield", "142.481.634-38", "chris@gmail.com", "zumbi");
        Cliente cliente5 = new Cliente(05, "Jill Valentine", "808.640.524-99", "jill@gmail.com", "nemezin" );

        //lista de clientes e atribuii os clientes
        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;

    
        //instancia tipo fornecedor e atribuii os fornecedores
        Fornecedor fornecedor1 = new Fornecedor(01, "Vonirze", "42.726.261/0001-33", "vonirze@gmail.com");
        Fornecedor fornecedor2 = new Fornecedor(02, "Xoesral", "76.050.618/0001-28", "xoer@gmail.com");
        Fornecedor fornecedor3 = new Fornecedor(03, "Roirim", "84.137.426/0001-81", "roirrim@gmail.com");
        Fornecedor fornecedor4 = new Fornecedor(04, "Luebo", "11.310.168/0001-10", "luebo@gmail.com");
        Fornecedor fornecedor5 = new Fornecedor(05, "Coerpen", "21.074.661/0001-31", "coerp@gmail.com");

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
