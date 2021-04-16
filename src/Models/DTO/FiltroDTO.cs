using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
    public class FiltroDTO
    {

        public int AId { get; set; }

        public string ANome { get; set; }

        public string ACPF { get; set; }

        public string ATelefone { get; set; }

        public string AEmail { get; set; }

        public int AIdade { get; set; }

        public FiltroDTO() { }

        public FiltroDTO(int aId, string aNome, string aCPF, string aTelefone, string aEmail, int aIdade)
        {
            AId = aId;
            ANome = aNome;
            ACPF = aCPF;
            ATelefone = aTelefone;
            AEmail = aEmail;
            AIdade = aIdade;
        }
    }
}
