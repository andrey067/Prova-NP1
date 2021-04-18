using System;

namespace Prova_NP1.Models
{
    public class Habilitado
    {
        public int AId { get; set; }

        public string ANome { get; private set; }

        public string ACPF { get; private set; }

        public string ATelefone { get; private set; }

        public string AEmail { get; private set; }

        public int AIdade { get; private set; }

        protected Habilitado() { }

        public Habilitado(string aNome, string aCPF, string aTelefone, string aEmail, int aIdade)
        {
            ANome = aNome;
            ACPF = aCPF;
            ATelefone = aTelefone;
            AEmail = aEmail;
            AIdade = aIdade;
        }
    }



}
