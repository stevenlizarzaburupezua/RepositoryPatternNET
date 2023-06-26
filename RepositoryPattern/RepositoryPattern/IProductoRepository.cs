using RepositoryPattern.Models;

namespace RepositoryPattern.RepositoryPattern
{
    public interface IProductoRepository
    {
        ProductoModel ObtenerPorId(int id);
        void Agregar(ProductoModel producto);
        void Actualizar(ProductoModel producto);
        void Eliminar(int id);
    }
}
