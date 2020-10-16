using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MTGExplorer.Models.MTGJson;
using MTGExplorer.Services;

namespace MTGExplorer.Pages
{
    public class SearchModel : PageModel
    {
        private MTGService _MTGService;
        public IEnumerable<Card> Cards;

        public SearchModel(MTGService mtgService)
        {
            _MTGService = mtgService;
        }

        public void OnGet(string text)
        {
            var allSets = _MTGService.ReadData();
            Cards = allSets.data.SelectMany(
                x => x.Value.cards.Where(
                    y => y.name.Contains(text, StringComparison.OrdinalIgnoreCase)));
        }
    }
}
