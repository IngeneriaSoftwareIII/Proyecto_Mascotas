using Entidades.Entidades;
using Entidades.Interfaces;
using System;
using System.Collections.Generic;

namespace Datos
{
    public class RazaDatos : IDatos<Raza, int>
    {
        public int Actualizar(Raza entidad)
        {
            throw new NotImplementedException();
        }

        public int Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public int Insertar(Raza entidad)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Raza> Obtener()
        {
            throw new NotImplementedException();
        }

        public Raza Obtener(int id)
        {
            throw new NotImplementedException();
        }
    }
}
