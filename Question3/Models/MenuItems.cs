using Newtonsoft.Json;
using System.Collections.Generic;

namespace Question3.Models
{
    public class Choice
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        public bool Checked { get; set; }
    }

    public class Related
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("choices")]
        public List<Choice> Choices { get; set; }

        public bool Checked { get; set; }
    }

    public class MenuItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("choices")]
        public List<Choice> Choices { get; set; }

        [JsonProperty("related")]
        public List<Related> Related { get; set; }

        public bool Checked { get; set; }
    }
}
