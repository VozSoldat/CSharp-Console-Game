using System.Text.Json.Serialization;

namespace ConsoleApp1.src.models.Character;
[JsonConverter(typeof(JsonStringEnumConverter))]

public enum SexType{
    Feminime,
    Masculine,
    Hermaphrodite
}