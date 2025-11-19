using StardewValley;

namespace HarvestCalendar.Model.HarvestableWithQuantity;

// Interface representing a Tuple<HarvestableObjectType harvest, int quantity>.
public interface IHarvestableWithQuantity<T> where T : Crop
{
    public T getHarvestable();
    public int getQuantity();
}
