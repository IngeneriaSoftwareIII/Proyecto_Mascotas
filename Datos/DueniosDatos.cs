using Entidades.Entidades;
using Entidades.Interfaces;
using System;
using System.Collections.Generic;

namespace Datos
{
    public class DueniosDatos : IDatos<Duenios, string>
    {
        public int Actualizar(Duenios entidad)
        {
            throw new NotImplementedException();
        }

        public int Eliminar(string id)
        {
            throw new NotImplementedException();
        }

        public int Insertar(Duenios entidad)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Duenios> Obtener()
        {
            throw new NotImplementedException();
        }

        public Duenios Obtener(string id)
        {
            throw new NotImplementedException();
        }
    }
}
