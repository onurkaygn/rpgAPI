using System.Text.Json.Serialization;
using rpgAPI.Models;

namespace rpgAPI.Models
{

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        Knight = 1,
        Mage = 2,
        Cleric = 3
    }
}
