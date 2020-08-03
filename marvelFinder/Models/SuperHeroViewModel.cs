using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace marvelFinder.Models
{
    public class SuperHeroViewModel
    {
        public class Root
        {
            [JsonProperty("response")]
            public string response { get; set; }
            [JsonProperty("results-for")]
            public string results_for { get; set; }
            [JsonProperty("results")]
            public List<Result> results { get; set; }
            //---------------------
          
            [JsonProperty("id")]
            public string id { get; set; }
            [JsonProperty("name")]
            public string name { get; set; }
            [JsonProperty("powerstats")]
            public Powerstats powerstats { get; set; }
            [JsonProperty("biography")]
            public Biography biography { get; set; }
            [JsonProperty("appearance")]
            public Appearance appearance { get; set; }
            [JsonProperty("work")]
            public Work work { get; set; }
            [JsonProperty("connections")]
            public Connections connections { get; set; }
            [JsonProperty("image")]
            public Image image { get; set; }
        }

        public class Result
        {
            [JsonProperty("response")]
            public string response { get; set; }
            [JsonProperty("id")]
            public string id { get; set; }
            [JsonProperty("name")]
            public string name { get; set; }
            [JsonProperty("powerstats")]
            public Powerstats powerstats { get; set; }
            [JsonProperty("biography")]
            public Biography biography { get; set; }
            [JsonProperty("appearance")]
            public Appearance appearance { get; set; }
            [JsonProperty("work")]
            public Work work { get; set; }
            [JsonProperty("connections")]
            public Connections connections { get; set; }
            [JsonProperty("image")]
            public Image image { get; set; }
        }


        public class Powerstats
        {
            public string intelligence { get; set; }
            public string strength { get; set; }
            public string speed { get; set; }
            public string durability { get; set; }
            public string power { get; set; }
            public string combat { get; set; }
        }

        public class Biography
        {
            [JsonProperty("full-name")]
            public string full_name { get; set; }
            [JsonProperty("alter-egos")]
            public string alter_egos { get; set; }
            public string[] aliases { get; set; }
            [JsonProperty("place-of-birth")]
            public string place_of_birth { get; set; }
            [JsonProperty("first-appearance")]
            public string first_appearance { get; set; }
            public string publisher { get; set; }
            public string alignment { get; set; }
        }

        public class Appearance
        {
            public string gender { get; set; }
            public string race { get; set; }
            public string[] height { get; set; }
            public string[] weight { get; set; }
            [JsonProperty("eye-color")]
            public string eye_color { get; set; }
            [JsonProperty("hair-color")]
            public string hair_color { get; set; }
        }

        public class Work
        {
            public string occupation { get; set; }
            [JsonProperty("base")]
            public string basee { get; set; }
        }

        public class Connections
        {
            [JsonProperty("group-affiliation")]
            public string group_affiliation { get; set; }
            public string relatives { get; set; }
        }

        public class Image
        {
            public string url { get; set; }
        }


    }

}
