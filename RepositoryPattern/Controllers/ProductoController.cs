using Microsoft.AspNetCore.Mvc;
using RepositoryPattern.Models;
using RepositoryPattern.RepositoryPattern;

namespace RepositoryPattern.Controllers
{
    public class ProductoController : Controller
    {
        public IActionResult Index()
        {
            // Creación del Repositorio
            IProductoRepository productoRepository = new ProductoRepository();

            // Creación del servicio de productos utilizando el Repositorio
            ProductoService productoService = new ProductoService(productoRepository);

            // Ejemplo de uso del servicio y el Repositorio
            var producto1 = new ProductoModel { Id = 1, Nombre = "Camiseta", Precio = 29.99m };
            productoService.AgregarProducto(producto1);

            var producto2 = new ProductoModel { Id = 2, Nombre = "Pantalón", Precio = 49.99m };
            productoService.AgregarProducto(producto2);

            var productoActualizado = new ProductoModel { Id = 1, Nombre = "Camiseta actualizada", Precio = 39.99m };
            productoService.ActualizarProducto(productoActualizado);

            productoService.EliminarProducto(2);

            return View();
        }
    }
}
