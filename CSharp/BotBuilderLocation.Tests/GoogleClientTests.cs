using Microsoft.Bot.Builder.Location.Bing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Microsoft.Bot.Builder.Location.Tests
{
    [TestClass]
    public class GoogleClientTests
    {
        [TestMethod]
        public void TestGoogleGeoService()
        {
            var query = "Level 3, 26 Marine Parade Southport QLD 4216";
            var service = new GoogleGeocodingService(String.Empty);
            var result = service.GetLocationsByQueryAsync(query).Result;
        }
    }
}
