using Entidades.Entidades;
using System;
using System.Collections.Generic;

namespace Entidades.Interfaces
{
    public interface IReporteDatos
    {
        IEnumerable<VisitasAtencion> Reporte(DateTime fechaIni, DateTime fechaFin);
        IEnumerable<VisitasAtencion> Reporte(string documentoMedico);
    }
}
