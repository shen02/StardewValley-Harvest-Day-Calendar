using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewModdingAPI.Utilities;
using StardewValley;
using HarvestCalendar.View.Menu;
using HarvestCalendar.Controller.Translator;
using HarvestCalendar.Model.SeasonHarvestInfo;
using HarvestCalendar.External;

namespace HarvestCalendar.Model.Config;

internal class HarvestCalendarConfig
{
    private KeybindList _menuTrigger = KeybindList.Parse("LeftShift + C");
    public KeybindList menuTrigger { get { return _menuTrigger; } set { _menuTrigger = value; } }
}