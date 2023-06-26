using RepositoryPattern.Models;

namespace RepositoryPattern.RepositoryPattern
{
    public class ProductoRepository : IProductoRepository
    {
        private List<ProductoModel> _productos;

        public ProductoRepository()
        {
            _productos = new List<ProductoModel>();
        }

        public ProductoModel ObtenerPorId(int id)
        {
            return _productos.FirstOrDefault(p => p.Id == id);
        }

        public void Agregar(ProductoModel producto)
        {
            _productos.Add(producto);
        }

        public void Actualizar(ProductoModel producto)
        {
            var productoExistente = _productos.FirstOrDefault(p => p.Id == producto.Id);
            if (productoExistente != null)
            {
                productoExistente.Nombre = producto.Nombre;
                productoExistente.Precio = producto.Precio;
            }
        }

        public void Eliminar(int id)
        {
            var producto = _productos.FirstOrDefault(p => p.Id == id);
            if (producto != null)
            {
                _productos.Remove(producto);
            }
        }
    }
}
