using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Interface
{
   public interface IHabilitadoRepository : IBaseRepository<Habilitado>
    {
        Task<Habilitado> GetByEmail(string email);

    }
}
