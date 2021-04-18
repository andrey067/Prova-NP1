namespace Prova_NP1.View.FilterDTO
{
    public class HabilitadoDTO
    {
        public int AId { get; set; }

        public string ANome { get; set; }

        public string ACPF { get; set; }

        public string ATelefone { get; set; }

        public string AEmail { get; set; }

        public int AIdade { get; set; }



        public HabilitadoDTO() { }

        public HabilitadoDTO(int aId, string aNome, string aCPF, string aTelefone, string aEmail, int aIdade)
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


