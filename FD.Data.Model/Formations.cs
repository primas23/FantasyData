using System.Collections.Generic;
using Newtonsoft.Json;

namespace FD.Data.Model
{
    public class Formations
    {

        [JsonProperty("1-5-2-3")]
        public IList<IList<int>> Formation1523 { get; set; }

        [JsonProperty("1-5-3-2")]
        public IList<IList<int>> Formation1532 { get; set; }

        [JsonProperty("1-3-5-2")]
        public IList<IList<int>> Formation1352 { get; set; }

        [JsonProperty("1-2-5-3")]
        public IList<IList<int>> Formation1253 { get; set; }

        [JsonProperty("1-4-5-1")]
        public IList<IList<int>> Formation1451 { get; set; }

        [JsonProperty("1-5-4-1")]
        public IList<IList<int>> Formation1541 { get; set; }

        [JsonProperty("1-4-3-3")]
        public IList<IList<int>> Formation1433 { get; set; }

        [JsonProperty("1-3-4-3")]
        public IList<IList<int>> Formation1343 { get; set; }

        [JsonProperty("1-4-4-2")]
        public IList<IList<int>> Formation1442 { get; set; }
    }
}