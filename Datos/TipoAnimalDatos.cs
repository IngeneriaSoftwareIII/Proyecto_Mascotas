using Entidades.Entidades;
using Entidades.Interfaces;
using System;
using System.Collections.Generic;

namespace Datos
{
    public class TipoAnimalDatos : IDatos<TipoAnimal, int>
    {
        public int Actualizar(TipoAnimal entidad)
        {
            throw new NotImplementedException();
        }

        public int Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public int Insertar(TipoAnimal entidad)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TipoAnimal> Obtener()
        {
            throw new NotImplementedException();
        }

        public TipoAnimal Obtener(int id)
        {
            throw new NotImplementedException();
        }
    }
}
