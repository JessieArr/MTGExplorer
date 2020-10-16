using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MTGExplorer.Models.MTGJson;
using MTGExplorer.Services;

namespace MTGExplorer.Pages
{
    public class CardModel : PageModel
    {
        public Card Card { get; set; }
        private MTGService _MTGService;

        public CardModel(MTGService mtgService)
        {
            _MTGService = mtgService;
        }

        public void OnGet(Guid uuid)
        {
            var sets = _MTGService.ReadData();
            Card = sets.data.Values.First(x => x.cards.Any(y => y.uuid == uuid))
                .cards.First(x => x.uuid == uuid);
        }
    }
}
