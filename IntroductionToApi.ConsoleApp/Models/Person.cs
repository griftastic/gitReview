using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace IntroductionToApi.ConsoleApp.Models
{
    public class Person
    {
        
        [JsonProperty("name-USen")]
        public string NameUSen { get; set; }

        [JsonProperty("name-EUen")]
        public string NameEUen { get; set; }

        [JsonProperty("name-EUde")]
        public string NameEUde { get; set; }

        [JsonProperty("name-EUes")]
        public string NameEUes { get; set; }

        [JsonProperty("name-USes")]
        public string NameUSes { get; set; }

        [JsonProperty("name-EUfr")]
        public string NameEUfr { get; set; }

        [JsonProperty("name-USfr")]
        public string NameUSfr { get; set; }

        [JsonProperty("name-EUit")]
        public string NameEUit { get; set; }

        [JsonProperty("name-EUnl")]
        public string NameEUnl { get; set; }

        [JsonProperty("name-CNzh")]
        public string NameCNzh { get; set; }

        [JsonProperty("name-TWzh")]
        public string NameTWzh { get; set; }

        [JsonProperty("name-JPja")]
        public string NameJPja { get; set; }

        [JsonProperty("name-KRko")]
        public string NameKRko { get; set; }

        [JsonProperty("name-EUru")]
        public string NameEUru { get; set; }
    }

    public class CatchTranslations
    {
        [JsonProperty("catch-USen")]
        public string CatchUSen { get; set; }

        [JsonProperty("catch-EUen")]
        public string CatchEUen { get; set; }

        [JsonProperty("catch-EUde")]
        public string CatchEUde { get; set; }

        [JsonProperty("catch-EUes")]
        public string CatchEUes { get; set; }

        [JsonProperty("catch-USes")]
        public string CatchUSes { get; set; }

        [JsonProperty("catch-EUfr")]
        public string CatchEUfr { get; set; }

        [JsonProperty("catch-USfr")]
        public string CatchUSfr { get; set; }

        [JsonProperty("catch-EUit")]
        public string CatchEUit { get; set; }

        [JsonProperty("catch-EUnl")]
        public string CatchEUnl { get; set; }

        [JsonProperty("catch-CNzh")]
        public string CatchCNzh { get; set; }

        [JsonProperty("catch-TWzh")]
        public string CatchTWzh { get; set; }

        [JsonProperty("catch-JPja")]
        public string CatchJPja { get; set; }

        [JsonProperty("catch-KRko")]
        public string CatchKRko { get; set; }

        [JsonProperty("catch-EUru")]
        public string CatchEUru { get; set; }
    }

    public class Root
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("file-name")]
        public string FileName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("personality")]
        public string Personality { get; set; }

        [JsonProperty("birthday-string")]
        public string BirthdayString { get; set; }

        [JsonProperty("birthday")]
        public string Birthday { get; set; }

        [JsonProperty("species")]
        public string Species { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("subtype")]
        public string Subtype { get; set; }

        [JsonProperty("hobby")]
        public string Hobby { get; set; }

        [JsonProperty("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonProperty("icon_uri")]
        public string IconUri { get; set; }

        [JsonProperty("image_uri")]
        public string ImageUri { get; set; }

        [JsonProperty("bubble-color")]
        public string BubbleColor { get; set; }

        [JsonProperty("text-color")]
        public string TextColor { get; set; }

        [JsonProperty("saying")]
        public string Saying { get; set; }

        [JsonProperty("catch-translations")]
        public CatchTranslations CatchTranslations { get; set; }
    }


    }
