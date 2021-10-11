using Entidades.Entidades;
using Entidades.Interfaces;
using System;
using System.Collections.Generic;

namespace Datos
{
    public class MedicoDatos : IDatos<Medico, string>
    {
        public int Actualizar(Medico entidad)
        {
            throw new NotImplementedException();
        }

        public int Eliminar(string id)
        {
            throw new NotImplementedException();
        }

        public int Insertar(Medico entidad)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Medico> Obtener()
        {
            throw new NotImplementedException();
        }

        public Medico Obtener(string id)
        {
            throw new NotImplementedException();
        }
    }
}
