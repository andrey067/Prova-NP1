using System.Collections.Generic;

namespace Prova_NP1.Models.Interface
{
    public interface IHabilitadoRepository
    {
        List<Habilitado> Query();

        public bool Reescrever(List<Habilitado> habilitado);

    }
}
