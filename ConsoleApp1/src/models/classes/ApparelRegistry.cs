using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace ConsoleApp1.src.models;
public class ApparelRegistry
{
    // ================================ PROPERTIES ================================
    public Dictionary<Guid, Apparel> PlayerOwnedApparel { get; private set; }
    public Dictionary<Guid, Apparel> AvailableApparel { get; private set; }
    // =============================== END PROPERTIES =============================

    public ApparelRegistry()
    {
        PlayerOwnedApparel = new Dictionary<Guid, Apparel>();
        AvailableApparel = new Dictionary<Guid, Apparel>();
    }

    // ================================ METHODS ===================================
    // Add apparel to player's wardrobe
    public void AddToPlayerWardrobe(Apparel apparel)
    {
        if (!PlayerOwnedApparel.ContainsKey(apparel.ID))
        {
            PlayerOwnedApparel[apparel.ID] = apparel;
        }
    }

    // Add apparel to the in-game store
    public void AddToAvailableApparel(Apparel apparel)
    {
        if (!AvailableApparel.ContainsKey(apparel.ID))
        {
            AvailableApparel[apparel.ID] = apparel;
        }
    }

    public void AddFromAvailableToWardrove(Guid apparelId)
    {
        AddToPlayerWardrobe(GetAvaibleApparel(apparelId));
    }

    // Remove apparel from player's wardrobe
    public bool RemoveFromPlayerWardrobe(Guid apparelId)
    {
        return PlayerOwnedApparel.Remove(apparelId);
    }

    // Find apparel by ID
    public Apparel? FindApparel(Guid apparelId)
    {
        if (PlayerOwnedApparel.TryGetValue(apparelId, out var apparel) ||
            AvailableApparel.TryGetValue(apparelId, out apparel))
        {
            return apparel;
        }
        throw new Exception("Apparel not found");
    }

    public Apparel GetApparelFromPlayerWardrobe(Guid apparelId)
    {
        if (PlayerOwnedApparel.TryGetValue(apparelId, out var apparel))
        {
            return apparel;
        }
        throw new Exception("Apparel not found");
    }

    public Apparel GetAvaibleApparel(Guid apparelId)
    {
        if (PlayerOwnedApparel.TryGetValue(apparelId, out var apparel))
        {
            return apparel;
        }
        throw new Exception("Apparel not found");
    }


    public List<string> ListPlayerOwnedApparel()
    {
        return PlayerOwnedApparel.Values.Select(apparel => apparel.GetLongName()).ToList();
    }

    public List<string> ListAvailableApparel()
    {
        return AvailableApparel.Values.Select(apparel => apparel.GetLongName()).ToList();
    }



    public void LoadJsonString(string json, bool addToPlayerWardrobe = true)
    {
        try
        {
            // Deserialize the JSON string into a list of Apparel objects
            List<Apparel> apparelList = JsonSerializer.Deserialize<List<Apparel>>(json);

            if (apparelList != null)
            {
                foreach (var apparel in apparelList)
                {
                    if (addToPlayerWardrobe)
                    {
                        AddToPlayerWardrobe(apparel);
                    }
                    else
                    {
                        AddToAvailableApparel(apparel);
                    }
                }
            }
        }
        catch (JsonException ex)
        {
            Console.WriteLine($"Error parsing JSON: {ex.Message}");
        }
    }

    // ============================== END METHODS =================================
}


