using System.Text.Json.Serialization;

namespace ConsoleApp1.src.models;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum ApparelSlot
{
    Head, Top, Arm, Leg, Foot
}