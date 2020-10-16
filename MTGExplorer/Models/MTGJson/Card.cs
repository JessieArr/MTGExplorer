using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MTGExplorer.Models.MTGJson
{
    public class Card
    {
        public string artist { get; set; }
        public List<string> availability { get; set; }
        public string borderColor { get; set; }
        public List<string> colorIdentity { get; set; }
        public List<string> colors { get; set; }
        public float convertedManaCost { get; set; }
        public int edhrecRank { get; set; }
        public List<JObject> foreignData { get; set; }
        public string frameVersion { get; set; }
        public bool hasFoil { get; set; }
        public bool hasNonFoil { get; set; }
        public Dictionary<string, string> identifiers { get; set; }
        public bool isReprint { get; set; }
        public string layout { get; set; }
        public Dictionary<string, string> legalities { get; set; }
        public string manaCost { get; set; }
        public string name { get; set; }
        public string number { get; set; }
        public string originalText { get; set; }
        public string originalType { get; set; }
        public List<string> printings { get; set; }
        public Dictionary<string, string> purchaseUrls { get; set; }
        public string rarity { get; set; }
        public List<JObject> rulings { get; set; }
        public string setCode { get; set; }
        public List<string> subtypes { get; set; }
        public List<string> supertypes { get; set; }
        public string text { get; set; }
        public string type { get; set; }
        public List<string> types { get; set; }
        public Guid uuid { get; set; }
    }
}
