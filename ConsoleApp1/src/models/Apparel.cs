namespace ConsoleApp1.src.models;
using System;
using System.Collections.Generic;
using System.Linq;
public class Apparel
{
    // ================================ PROPERTIES ================================
    public Guid ID { get; set; }
    public string BasicName { get; set; }
    public ApparelSlot ApparelSlot { get; set; }
    public string Color { get; set; }
    public string Pattern { get; set; }
    public string Material { get; set; }
    public float Integrity{ get; set; }
    public HashSet<BodyCoverage>? BodyCoverages { get; set; }
    // =============================== END PROPERTIES =============================

    public Apparel(string basicName, ApparelSlot apparelSlot, string color, string pattern, string material, HashSet<BodyCoverage> bodyCoverages, IntegrityType integrityType)
    {
        ID = Guid.NewGuid();
        BasicName = basicName;
        ApparelSlot = apparelSlot;
        Color = color;
        Pattern = pattern;
        Material = material;
        BodyCoverages = bodyCoverages;
        IntegrityType _integrityType = integrityType;
        Integrity = (float)_integrityType;
    }
    public string GetLongName()
    {
        string covered = string.Join(", ", BodyCoverages);
        string longName = $"{Color} {Pattern} {Material} {BasicName}, covering {covered}";
        return longName;
    }


}
