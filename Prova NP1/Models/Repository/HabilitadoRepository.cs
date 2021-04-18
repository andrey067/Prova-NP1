using Newtonsoft.Json;
using Prova_NP1.Models.Interface;
using System.Collections.Generic;
using System.IO;

namespace Prova_NP1.Models.Repository
{
    public class HabilitadoRepository : IHabilitadoRepository
    {

        public List<Habilitado> Query()
        {
            var caminhoArquivo = File.ReadAllText(Path.GetFullPath(@"./Database/Habilitado.json"));
            var result = JsonConvert.DeserializeObject<List<Habilitado>>(caminhoArquivo);
            return result;
        }
        public bool Reescrever(List<Habilitado> habilitado)
        {
            var caminhoArquivo = Path.GetFullPath(@"./Database/Habilitado.json");
            var Habilitado_Json = JsonConvert.SerializeObject(habilitado, Formatting.Indented);
            File.WriteAllText(caminhoArquivo, Habilitado_Json);
            return true;
        }



    }
}
