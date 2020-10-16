using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MTGExplorer.Models.MTGJson
{
    public class AllPrintings
    {
        public Dictionary<string, Set> data { get; set; }
        public JObject meta { get; set; }
    }
}
