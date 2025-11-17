
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewValley;
using HarvestCalendar.View.Menu;

internal sealed class harvestCalendar : Mod
{
    public override void Entry(IModHelper helper)
    {

        helper.Events.Input.ButtonPressed += this.OnButtonPressed;

    }

    private void OnButtonPressed(object? sender, ButtonPressedEventArgs e)
    {
        //this.Monitor.Log("Test", LogLevel.Debug);

        if (Context.IsWorldReady)
        {
            if (e.Button == SButton.MouseMiddle)
                Game1.activeClickableMenu = new HarvestCalendarMenu();

            //HarvestableCrops hc = new HarvestableCrops();
            //List<Crop> islandCrops = hc.getAllCropsInLocation(Game1.getLocationFromNameInLocationsList("IslandWest"));


            // foreach (var item in islandCrops)
            //  {
            //     Monitor.Log(item.indexOfHarvest.ToString(), LogLevel.Debug);
            // }
            //Monitor.Log(islandCrops.Count.ToString(), LogLevel.Debug);

        }
    }
}

