using Microsoft.EntityFrameworkCore;
using MobileCrudPwa.Api.Models;

namespace MobileCrudPwa.Api.Data
{
    public static class SeedData
    {
        public static void Initialize(AppDbContext db)
        {
            db.Database.EnsureCreated();
            
                if (db.Produtos.Any()) return;


                var produtos = new Produto[]
                {
                    new Produto
                    {
                        Nome = "Notebook Dell",
                        Preco = 3500.00m,
                        Estoque = 15
                    },
                    new Produto
                    {
                        Nome = "Mouse Logitech",
                        Preco = 120.00m,
                        Estoque = 50
                    },
                    new Produto
                    {
                        Nome = "Teclado Mecânico",
                        Preco = 450.00m,
                        Estoque = 25
                    },
                    new Produto
                    {
                        Nome = "Monitor LG 24\"",
                        Preco = 899.00m,
                        Estoque = 10
                    },
                    new Produto
                    {
                        Nome = "Webcam Full HD",
                        Preco = 280.00m,
                        Estoque = 30
                    }
                };

                db.Produtos.AddRange(produtos);
                db.SaveChanges();
            
        }
    }
}
