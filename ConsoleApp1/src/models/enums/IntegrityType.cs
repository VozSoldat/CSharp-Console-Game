using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConsoleApp1.src.models;

[JsonConverter(typeof(JsonStringEnumConverter))]

public enum IntegrityType
{
    Strong = 100,
    Medium = 50,
    Weak = 25
}
