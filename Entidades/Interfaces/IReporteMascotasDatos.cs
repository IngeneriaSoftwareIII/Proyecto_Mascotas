using Entidades.Entidades;
using System.Collections.Generic;

namespace Entidades.Interfaces
{
    public interface IReporteMascotasDatos
    {
        IEnumerable<Mascota> Reporte(string documentoDuenio);
    }
}
