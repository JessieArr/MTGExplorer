using MTGExplorer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace MTGExplorer.Test.Integration.Services
{
    public class MTGServiceTests
    {
        [Fact]
        public void Test()
        {
            var svc = new MTGService();
            var data = svc.ReadData();
            var firstSet = data.data.First().Value;
            var firstCard = firstSet.cards.First();
        }
    }
}
