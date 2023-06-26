using RepositoryPattern.Models;

namespace RepositoryPattern.RepositoryPattern
{
    public class ProductoService
    {
        private IProductoRepository _productoRepository;

        public ProductoService(IProductoRepository productoRepository)
        {
            _productoRepository = productoRepository;
        }

        public void AgregarProducto(ProductoModel producto)
        {
            _productoRepository.Agregar(producto);
        }

        public void ActualizarProducto(ProductoModel producto)
        {
            _productoRepository.Actualizar(producto);
        }

        public void EliminarProducto(int id)
        {
            _productoRepository.Eliminar(id);
        }
    }
}
