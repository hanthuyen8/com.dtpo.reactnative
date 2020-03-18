using UnityEngine;
using Newtonsoft.Json;

[SerializeField]
public class CommonData
{
    [JsonProperty("action")]
    public string Action;

    [JsonProperty("data")]
    public string Data;
}