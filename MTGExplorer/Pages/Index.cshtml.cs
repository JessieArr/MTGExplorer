﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using MTGExplorer.Models.MTGJson;
using MTGExplorer.Services;

namespace MTGExplorer.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private MTGService _MTGService;
        public List<Card> Cards;

        public IndexModel(ILogger<IndexModel> logger, MTGService mtgService)
        {
            _logger = logger;
            _MTGService = mtgService;
        }

        public void OnGet()
        {
            var allSets = _MTGService.ReadData();
            var firstSet = allSets.data.First();
            Cards = firstSet.Value.cards;
        }
    }
}
