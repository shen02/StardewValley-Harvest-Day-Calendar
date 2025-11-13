using HarvestCalendar.DataTypes;

namespace HarvestCalendar.DailyHarvestInfo;

// Daily harvest represents a dictionary that maps a list of harvestable crops with their quantities to the GameLocation to which they are planted.
// The object construtor takes in an enumeration of locationNames, which represents all farmable location in the game's given context.
// Invariant: GameLocation is one of: Farm, IslandWest, Greenhouse.
internal sealed class DailyHarvest
{
    private Dictionary<FarmableLocationNames, List<CropWithQuantity>> dailyHarvest;

    public DailyHarvest(FarmableLocationNames locationNames)
    {
        dailyHarvest = new Dictionary<FarmableLocationNames, List<CropWithQuantity>>();
        dictInit(locationNames);
    }

    // Fills this.dailyHarvest with the current farmable location names each mapped to an empty list of CropWithQuantity. 
    private void dictInit(FarmableLocationNames locationNames)
    {
        // convert this.farmableLocationNames into a fixed length array. 
        FarmableLocationNames[] names = (FarmableLocationNames[])Enum.GetValues(typeof(FarmableLocationNames));

        for (int i = 0; i < names.Length; i++)
        {
            dailyHarvest.Add(names[i], new List<CropWithQuantity>());
        }
    }

    public void AddCrop(FarmableLocationNames locationName, CropWithQuantity crop)
    {
        dailyHarvest[locationName].Add(crop);
    }

    // Most likely won't be used in the context of this mod but created for data stucture design
    public void removeCrop(FarmableLocationNames locationName, CropWithQuantity crop)
    {
        dailyHarvest[locationName].Remove(crop);
    }

    public List<CropWithQuantity> getCropListByLocation(FarmableLocationNames location)
    {
        return dailyHarvest[location];
    }
}