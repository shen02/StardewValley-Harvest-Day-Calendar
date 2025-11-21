using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewModdingAPI.Utilities;
using StardewValley;
using HarvestCalendar.View.Menu;
using HarvestCalendar.Controller.Translator;
using HarvestCalendar.Model.SeasonHarvestInfo;

internal sealed class harvestCalendar : Mod
{
    private KeybindList _menuTrigger { get; set; } = KeybindList.Parse("LeftShift + C");
    public override void Entry(IModHelper helper)
    {
        helper.Events.Input.ButtonsChanged += this.OnButtonPressed;
    }

    private void OnButtonPressed(object? sender, ButtonsChangedEventArgs e)
    {
        if (Context.IsWorldReady)
            if (_menuTrigger.JustPressed())
            {
                HarvestableCrops allHravestableCrops = new HarvestableCrops(Game1.Date.TotalDays);
                HarvestCalendarMenu menu = new HarvestCalendarMenu(HarvestablesTranslator.translate(Game1.dayOfMonth, allHravestableCrops));
                Game1.activeClickableMenu = Game1.activeClickableMenu == null || Game1.activeClickableMenu.GetType() != typeof(HarvestCalendarMenu) ? menu : null;
            }


    }
}

