using Entidades.Entidades;
using Entidades.Interfaces;
using System;
using System.Collections.Generic;

namespace Datos
{
    public class VeterinariaDatos : IDatos<Veterinaria, int>
    {
        public int Actualizar(Veterinaria entidad)
        {
            throw new NotImplementedException();
        }

        public int Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public int Insertar(Veterinaria entidad)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Veterinaria> Obtener()
        {
            throw new NotImplementedException();
        }

        public Veterinaria Obtener(int id)
        {
            throw new NotImplementedException();
        }
    }
}
