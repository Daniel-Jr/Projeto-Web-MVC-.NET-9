using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GranStore.Models;

namespace GranStore.Controllers;

public class HomeController(ILogger<HomeController> logger) : Controller
{
    private readonly ILogger<HomeController> _logger = logger;

    public IActionResult Index()
    {
        List<Categoria> categorias = new List<Categoria>
        {
            new Categoria {
                Id = 1,
                Nome = "SSD"
            },
            new Categoria {
                Id = 2,
                Nome = "Placa de vídeo (VGA)"
            }
        };

        List<Produto> produtos = [
            new(){
                Id = 1,
                Nome = "SSD Kingston NV3, 1 TB, M.2 2280.",
                Descricao = @"Liberte todo o potencial do seu sistema com a incrível velocidade do SSD Kingston NV3 PCIe 4.0! Experimente taxas de leitura de até 6.000 MB/s e gravação de até 4.000 MB/s.",
                QtdeEstoque = 13,
                ValorCusto = 334.99m,
                ValorVenda = 444.99m,
                Categoria = categorias[0],
                Foto = "/img/produtos/1.webp"
            },
            new(){
                Id = 2,
                Nome = "SSD Kingston 1TB Nv3 M.2 Nvme PCIe 4.",
                Descricao = @"Kingston nv3 pcie 4.0 nvme ssd é uma solução de última geração para armazenamento com um driver nvme gen 4x4, conforto de leitura/gravação de até 6.000/5.000mb/s",
                QtdeEstoque = 15,
                ValorCusto = 208.00m,
                ValorVenda =  408.00m,
                Categoria = categorias[0],
                Foto = "/img/produtos/2.webp"
            },
            new(){
                Id = 3,
                Nome = "SSD Kingston Fury Renegade, 1TB, M.2 2280",
                Descricao = @"A ultrarrápida Kingston FURY Renegade DDR4 RGB1 é a atualização de memória perfeita para o gamer que deseja desempenho superior e estilo RGB brilhante no seu sistema AMD ou baseado em Intel. Os efeitos dinâmicos de iluminação RGB.",
                QtdeEstoque = 20,
                ValorCusto = 529.99m,
                ValorVenda = 679.99m,
                Categoria = categorias[0],
                Foto = "/img/produtos/3.webp"
            },
            new(){
                Id = 4,
                Nome = "SSD SanDisk Plus NVMe, 1TB, M.2, PCle",
                Descricao = @"Eleve o desempenho do seu PC com o SSD SanDisk SSD PLUS M.2 NVMe, a unidade que é 5x mais rápida que os SSDs SATA tradicionais, para que você possa continuar fazendo o que faz de melhor, com mais rapidez. E armazene mais do que você ama com os 1TB de capacidade para armazenar fotos, vídeos, músicas e documentos importantes.",
                QtdeEstoque = 23,
                ValorCusto = 339.99m,
                ValorVenda = 449.99m,
                Categoria = categorias[0],
                Foto = "/img/produtos/4.webp"
            },

            new(){
                Id = 5,
                Nome = "Placa de Vídeo ASRock RX 9070 XT Steel Legend AMD Radeon",
                Descricao = @"Velocidade, desempenho e visuais trabalham juntos para quadros suaves e imersão total. As placas gráficas ultrarrápidas Radeon RX 9000 Series são equipadas com unidades de computação AMD RDNA™ 4.",
                QtdeEstoque = 23,
                ValorCusto = 4119.99m,
                ValorVenda = 5319.99m,
                Categoria = categorias[1],
                Foto = "/img/produtos/5.webp"
            }
            ,
            new(){
                Id = 6,
                Nome = "Placa de Vídeo DUAL RX 7600 O8G EVO AMD Radeon.",
                Descricao = @"Oferecendo a mais recente experiência da arquitetura AMD RDNA™ 3 em sua forma mais pura, a Dual Radeon™ RX 7600 EVO combina desempenho e simplicidade como nenhuma outra.",
                QtdeEstoque = 10,
                ValorCusto = 1349.99m,
                ValorVenda = 1749.99m,
                Categoria = categorias[1],
                Foto = "/img/produtos/6.webp"
            },
            new(){
                Id = 7,
                Nome = "Placa de Vídeo RX 7600 Series Graphics Cards XFX AMD Radeon.",
                Descricao = @"Experimente desempenho, visual e eficiência sem precedentes para jogos e streaming em 1080p com a placa de vídeo AMD Radeon RX 7600, desenvolvida com arquitetura RDNA 3.",
                QtdeEstoque = 11,
                ValorCusto = 1499.99m,
                ValorVenda = 1799.99m,
                Categoria = categorias[1],
                Foto = "/img/produtos/7.webp"
            },
            new(){
                Id = 8,
                Nome = "Placa de Vídeo XFX Swift RX 9070 XT TRIPLE FAN GAMING EDITION",
                Descricao = @"Velocidade, desempenho e visuais trabalham juntos para quadros suaves e imersão total. As placas gráficas ultrarrápidas Radeon RX série 9000 são alimentadas por unidades de computação AMD RDNA™ 4 unificadas com recursos de raytracing aprimorados para uma experiência ultraimersiva em todas as principais resoluções de jogos.",
                QtdeEstoque = 16,
                ValorCusto = 4379.99m,
                ValorVenda = 5379.99m,
                Categoria = categorias[1],
                Foto = "/img/produtos/8.webp"
            }
        ];
 
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
