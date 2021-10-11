using Entidades.Entidades;
using Entidades.Interfaces;
using System;
using System.Collections.Generic;

namespace Datos
{
    public class MascotaDatos : IDatos<Mascota, int>,IReporteMascotasDatos
    {
        public int Actualizar(Mascota entidad)
        {
            throw new NotImplementedException();
        }

        public int Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public int Insertar(Mascota entidad)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Mascota> Obtener()
        {
            throw new NotImplementedException();
        }

        public Mascota Obtener(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Mascota> Reporte(string documentoDuenio)
        {
            throw new NotImplementedException();
        }
    }
}
