using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MTGExplorer.Models.MTGJson
{
    public class Set
    {
        public int baseSetSize { get; set; }
        public string block { get; set; }
        public JObject boosters { get; set; }
        public List<Card> cards { get; set; }
        public string code { get; set; }
        public bool isFoilOnly { get; set; }
        public bool isOnlineOnly { get; set; }
        public string keyruneCode { get; set; }
        public int msmId { get; set; }
        public string msmName { get; set; }
        public string mtgoCode { get; set; }
        public string name { get; set; }
        public DateTime releaseDate { get; set; }
        public int tcgplayerGroupId { get; set; }
        //public JObject tokens { get; set; }
        public int totalSetSize { get; set; }
        public JObject translations { get; set; }
        public string type { get; set; }
    }
}
