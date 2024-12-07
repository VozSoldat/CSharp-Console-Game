using System.Text.Json;

namespace ConsoleApp1.src.models.Character;
public class Character
{
    // =========================== Property ==================================
    public Guid ID { get; set; }
    public string Forename { get; set; }
    // forename may be null
    public string Surname { get; set; }
    // surname must not be null. if character's name is mononym, fill it here
    public SexType SexType { get; set; }

    public int IntAge { get; set; }

    private short fat;
    public short Fat
    {
        get
        {
            return fat;
        }
        set
        {
            fat = short.Clamp(value, 0, 6);
        }
    }
    private short muscle;
    public short Muscle
    {
        get
        {
            return muscle;
        }
        set
        {
            muscle = short.Clamp(value, 0, 6);
        }
    }

    public string Physique
    {
        get
        {
            string[,] bodyTypes = new string[7, 7]
                {
                    { "Emaciated", "Thin", "Lean", "Toned", "Defined", "Sculpted", "Ripped" },
                    { "Gaunt", "Slender", "Slim", "Fit", "Taut", "Cut", "Shredded" },
                    { "Underweight", "Svelte", "Lithe", "Athletic", "Muscular", "Built", "Solid" },
                    { "Average", "Wiry", "Balanced", "Stocky", "Husky", "Buff", "Hefty" },
                    { "Soft", "Slightly Firm", "Firm", "Bulky", "Strong", "Burly", "Massive" },
                    { "Pudgy", "Chubby", "Stout", "Robust", "Thick", "Powerhouse", "Brawny" },
                    { "Overweight", "Portly", "Heavyset", "Large", "Hulking", "Gargantuan", "Herculean" }
                };
            if (Fat < 0 || Muscle < 0)
            {
                return bodyTypes[0, 0];
            }
            else if (Fat > 6 || Muscle > 6)
            {
                return bodyTypes[6, 6];
            }
            else
            {
                return bodyTypes[Fat, Muscle];

            }

        }
    }

    string AgeDescriptor
    {
        get
        {
            if (IntAge < 17)
            {
                return "teenage";
            }
            else if (IntAge < 21)
            {
                return "grown-up";
            }
            else if (IntAge < 24)
            {
                return "early-twenties";
            }
            else if (IntAge < 27)
            {
                return "mid-twenties";
            }
            else if (IntAge < 30)
            {
                return "late-twenties";
            }
            else if (IntAge < 34)
            {
                return "early-thirties";
            }
            else if (IntAge < 37)
            {
                return "mid-thirties";
            }
            else if (IntAge < 40)
            {
                return "late-thirties";
            }
            else
            {
                return "fuzzy-aged";
            }
        }
    }



    string SexToAgeDescriptor
    {
        get
        {
            if (SexType == SexType.Masculine)
            {
                if (IntAge <= 21)
                {
                    return "Boy";

                }
                else
                {
                    return "Man";
                }

            }
            else if (SexType == SexType.Feminime)
            {
                if (IntAge <= 21)
                {
                    return "Girl";

                }
                else
                {
                    return "Woman";
                }
            }
            else
            {
                return "Hermaphrodite";
            }
        }
    }
    public Dictionary<ApparelSlot, List<Apparel>> EquippedApparels { get; set; }
    // ======================== end of Property ===============================

    public Character(Guid id, string forename, string surname, SexType sexType, int intAge, short fat, short muscle)
    {
        ID = id;
        Forename = forename;
        Surname = surname;
        SexType = sexType;
        IntAge = intAge;
        Fat = fat;
        Muscle = muscle;

        EquippedApparels = new Dictionary<ApparelSlot, List<Apparel>>();
    }

    public void EquipApparel(Apparel apparel)
    {
        if (!EquippedApparels.ContainsKey(apparel.ApparelSlot))
        {
            EquippedApparels[apparel.ApparelSlot] = new List<Apparel>();
        }
        EquippedApparels[apparel.ApparelSlot].Add(apparel);
    }

    public string PrintCoveredBodyPart()
    {
        var coveredParts = new HashSet<BodyCoverage>();

        foreach (var slot in EquippedApparels.Values)
        {
            foreach (var apparel in slot)
            {
                coveredParts.UnionWith(apparel.BodyCoverages);
            }
        }

        return string.Join(", ", coveredParts);
    }

    public string DescribeCharacterInOneString()
    {
        string oneStringDescription = "A " + Physique + " " + AgeDescriptor + " " + SexToAgeDescriptor;
        return oneStringDescription;
    }

    public void WriteIntoJSONFile()
    {
        string jsonString = JsonSerializer.Serialize(this);
        Console.WriteLine("Anda mencetak \n" + jsonString);
        File.WriteAllText($"{ID}.json", jsonString);
    }
}