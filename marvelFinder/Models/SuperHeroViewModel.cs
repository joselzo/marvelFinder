using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace marvelFinder.Models
{
    public class SuperHeroViewModel
    {
        public class RootNum
        {
            [JsonPropertyName("response")]
            public string response { get; set; }
            [JsonPropertyName("id")]
            public string id { get; set; }
            [JsonPropertyName("name")]
            public string name { get; set; }
            [JsonPropertyName("powerstats")]
            public Powerstats powerstats { get; set; }
            [JsonPropertyName("biography")]
            public Biography biography { get; set; }
            [JsonPropertyName("appearance")]
            public Appearance appearance { get; set; }
            [JsonPropertyName("work")]
            public Work work { get; set; }
            [JsonPropertyName("connections")]
            public Connections connections { get; set; }
            [JsonPropertyName("image")]
            public Image image { get; set; }
        }

        public class Root
        {
            [JsonPropertyName("response")]
            public string response { get; set; }
            [JsonPropertyName("results-for")]
            public string results_for { get; set; }
            [JsonPropertyName("results")]
            public List<Result> results { get; set; }
            //---------------------
          
            [JsonPropertyName("id")]
            public string id { get; set; }
            [JsonPropertyName("name")]
            public string name { get; set; }
            [JsonPropertyName("powerstats")]
            public Powerstats powerstats { get; set; }
            [JsonPropertyName("biography")]
            public Biography biography { get; set; }
            [JsonPropertyName("appearance")]
            public Appearance appearance { get; set; }
            [JsonPropertyName("work")]
            public Work work { get; set; }
            [JsonPropertyName("connections")]
            public Connections connections { get; set; }
            [JsonPropertyName("image")]
            public Image image { get; set; }
        }

        public class Result
        {
            [JsonPropertyName("response")]
            public string response { get; set; }
            [JsonPropertyName("id")]
            public string id { get; set; }
            [JsonPropertyName("name")]
            public string name { get; set; }
            [JsonPropertyName("powerstats")]
            public Powerstats powerstats { get; set; }
            [JsonPropertyName("biography")]
            public Biography biography { get; set; }
            [JsonPropertyName("appearance")]
            public Appearance appearance { get; set; }
            [JsonPropertyName("work")]
            public Work work { get; set; }
            [JsonPropertyName("connections")]
            public Connections connections { get; set; }
            [JsonPropertyName("image")]
            public Image image { get; set; }
        }


        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
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
            [JsonPropertyName("full-name")]
            public string full_name { get; set; }
            [JsonPropertyName("alter-egos")]
            public string alter_egos { get; set; }
            public string[] aliases { get; set; }
            [JsonPropertyName("place-of-birth")]
            public string place_of_birth { get; set; }
            [JsonPropertyName("first-appearance")]
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
            [JsonPropertyName("eye-color")]
            public string eye_color { get; set; }
            [JsonPropertyName("hair-color")]
            public string hair_color { get; set; }
        }

        public class Work
        {
            public string occupation { get; set; }
            [JsonPropertyName("base")]
            public string basee { get; set; }
        }

        public class Connections
        {
            public string group_affiliation { get; set; }
            public string relatives { get; set; }
        }

        public class Image
        {
            public string url { get; set; }
        }

        //public class Result
        //{

        //}

        //public class Root
        //{
        //    public string response { get; set; }
        //    public string results_for { get; set; }
        //    public List<Result> results { get; set; }
        //}


        //    [JsonPropertyName("id")]
        //    public int id { get; set; }
        //    [JsonPropertyName("name")]
        //    public string name { get; set; }
        //    [JsonPropertyName("powerstats")]
        //    public Dictionary<string, powerstats> powerstats { get; set; }

        //    [JsonPropertyName("biography")]
        //    public Dictionary<string, biography> biography { get; set; }


        //    [JsonPropertyName("appearance")]
        //    public Dictionary<string, appearance> appearance { get; set; }


        //    [JsonPropertyName("work")]
        //    public Dictionary<string, work> work { get; set; }


        //    [JsonPropertyName("connections")]
        //    public Dictionary<string, connections> connections { get; set; }


        //    [JsonPropertyName("image")]
        //    public Dictionary<string, image> image { get; set; }


        //}

        //public class powerstats
        //{
        //    [JsonPropertyName("intelligence")]
        //    public int intelligence { get; set; }
        //    [JsonPropertyName("strength")]
        //    public int strength { get; set; }
        //    [JsonPropertyName("speed")]
        //    public int speed { get; set; }
        //    [JsonPropertyName("durability")]
        //    public int durability { get; set; }
        //    [JsonPropertyName("power")]
        //    public int power { get; set; }
        //    [JsonPropertyName("combat")]
        //    public int combat { get; set; }
        //}

        //public class biography
        //{
        //    [JsonPropertyName("full_name")]
        //    public string full_name { get; set; }
        //    [JsonPropertyName("alter_egos")]
        //    public string alter_egos { get; set; }
        //    [JsonPropertyName("aliases")]
        //    public string[] aliases { get; set; }
        //    [JsonPropertyName("place_of_birth")]
        //    public string place_of_birth { get; set; }
        //    [JsonPropertyName("first_appearance")]
        //    public string first_appearance { get; set; }
        //    [JsonPropertyName("publisher")]
        //    public string publisher { get; set; }
        //    [JsonPropertyName("alignment")]
        //    public string alignment { get; set; }

        //}

        //public class appearance
        //{
        //    [JsonPropertyName("gender")]
        //    public string gender { get; set; }
        //    [JsonPropertyName("race")]
        //    public string race { get; set; }
        //    [JsonPropertyName("height")]
        //    public string[] height { get; set; }
        //    [JsonPropertyName("weight")]
        //    public string[] weight { get; set; }
        //    [JsonPropertyName("eye_color")]
        //    public string eye_color { get; set; }
        //    [JsonPropertyName("hair_color")]
        //    public string hair_color { get; set; }
        //}

        //public class work
        //{
        //    [JsonPropertyName("occupation")]
        //    public string occupation { get; set; }
        //    [JsonPropertyName("base")]
        //    public string baseN { get; set; }
        //}

        //public class connections
        //{
        //    [JsonPropertyName("group_affiliation")]
        //    public string group_affiliation { get; set; }
        //    [JsonPropertyName("relatives")]
        //    public string relatives { get; set; }
        //}

        //public class image
        //{
        //    [JsonPropertyName("url")]
        //    public string url { get; set; }

    }

}
