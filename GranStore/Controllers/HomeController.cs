using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GranStore.Models;

namespace GranStore.Controllers;

public class HomeController(ILogger<HomeController> logger) : Controller
{
    private readonly ILogger<HomeController> _logger = logger;

    public IActionResult Index()
    {
        Categoria categoria = new();

        categoria.Id = 1;
        categoria.Nome = "Produtos Diversos";

        Categoria categoria1 = new()
        {
            Id = 1,
            Nome = "Roupas"
        };

        Categoria categoria3 = new()
        {
            Id = 1,
            Nome = "Sapatos"
        };

        List<Produto> produtos = [
            new(){
                Id = 1,
                Nome = "Persiana",
                Descricao = "Persiana com flores",
                QtdeEstoque = 10,
                ValorCusto = 113.23m,
                ValorVenda = 230.33m,
                Categoria = categoria,
            }
        ];
 
        return View(categoria);
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
