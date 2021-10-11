using System.Collections.Generic;
using System.Text;

namespace Entidades.Interfaces
{
    public interface IDatos<T,TId> where T : class
    {
        IEnumerable<T> Obtener();
        T Obtener(TId id);
        int Insertar(T entidad);
        int Actualizar(T entidad);
        int Eliminar(TId id);
    }
}
