using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models.Entities;
using Models.Interface;
using Newtonsoft.Json;

namespace Database.Context
{
    public class HabilitadoContext : IHabilitadoContext
    {
        public List<Habilitado> Query()
        {
            var habilitadojson = File.ReadAllText(@"../Database\JsonDb\Habilitado.json", Encoding.GetEncoding("iso-8859-1"));
            var result = JsonConvert.DeserializeObject<List<Habilitado>>(habilitadojson);

            return result;
        }

    }
}
