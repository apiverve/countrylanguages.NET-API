using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class data
{
    [JsonProperty("country")]
    public string country { get; set; }

    [JsonProperty("name")]
    public string name { get; set; }

    [JsonProperty("officialName")]
    public string officialName { get; set; }

    [JsonProperty("officialLanguages")]
    public string[] officialLanguages { get; set; }

    [JsonProperty("officialLanguageCount")]
    public int officialLanguageCount { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
