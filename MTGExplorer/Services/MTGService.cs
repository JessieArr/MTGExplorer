using MTGExplorer.Models.MTGJson;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MTGExplorer.Services
{
    public class MTGService
    {
        private const string _FileName = "AllPrintings.json";
        public AllPrintings ReadData()
        {
            var contents = File.ReadAllText(_FileName);
            var obj = JsonConvert.DeserializeObject<AllPrintings>(contents, new JsonSerializerSettings()
            {
                Error = (sender, args) =>
                {

                }
            });
            return obj;
        }
    }
}
