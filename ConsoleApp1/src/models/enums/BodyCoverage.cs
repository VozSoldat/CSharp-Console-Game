using System.Text.Json.Serialization;

namespace ConsoleApp1.src.models;

[JsonConverter(typeof(JsonStringEnumConverter))]

public enum BodyCoverage
{
    Crown,
    Face,
    HeadBack,
    HeadSide,
    Neck,
    Shoulders,
    UpperChest,
    Breasts,
    LowerChest,
    UpperAbdomen,
    LowerAbdomen,
    UpperBack,
    LowerBack,
    UpperTorsoSide,
    LowerTorsoSide,
    UpperArms,
    LowerArms,
    Hands,
    Hip,
    Crotch,
    Buttocks,
    Anus,
    UpperThighs,
    LowerThighs,
    Knees,
    UpperCalves,
    LowerCalves,
    Instep,
    Sole
}