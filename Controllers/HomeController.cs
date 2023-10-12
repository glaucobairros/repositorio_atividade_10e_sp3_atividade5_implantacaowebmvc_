using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPets.Models;

namespace LHPets.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()

    {
        // instâncias do tipo Cliente
        Cliente cliente1 = new Cliente(01, "Glauco de Souza de Bairros", "123.456.789-01", "glauco.bairros@aluno.senai.br", "Zé Pequeno");
        Cliente cliente2 = new Cliente(02, "William Henry Gates III", "987.654.321-09", "bill@microsoft.com", "Bug");
        Cliente cliente3 = new Cliente(03, "Ada Lovelace", "456.123.789-12", "ada@ada.language.com", "Byron");
        Cliente cliente4 = new Cliente(04, "Linus Torvalds", "789.456.321-34", "torvalds@osdl.org", "Pinguim");
        Cliente cliente5 = new Cliente(05, "Grace Hooper", "345.876.901-32", "grace.hooper@cobol.com", "Loboc");

        // Lista de Clientes e atribuição dos clientes 
        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;


        // instâncias do tipo Fornecedor
        Fornecedor fornecedor1 = new Fornecedor(01, "C# PET S/A", "14.182.102/0001-80", "c-sharp@pet.org");
        Fornecedor fornecedor2 = new Fornecedor(02, "Ctrl Alt Dog", "12.345.678/0001-90", "ctrl@alt.dog.br");
        Fornecedor fornecedor3 = new Fornecedor(03, "BootsPet INC", "98.765.432/0001-10", "boots.pet@gatomania.br");
        Fornecedor fornecedor4 = new Fornecedor(04, "Tik Tok Dogs", "34.567.890/0001-12", "tiktok@dogs.com");
        Fornecedor fornecedor5 = new Fornecedor(05, "Bifinho Forever", "76.543.210/0001-98", "contato@bifinho.com.br");

        // Lista de Fornecedores e atribuição dos fornecedores
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
