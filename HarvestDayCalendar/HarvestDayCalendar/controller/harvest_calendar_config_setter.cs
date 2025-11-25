using StardewModdingAPI.Utilities;

namespace HarvestCalendar.Model.Config;

internal class HarvestCalendarConfig
{
    private KeybindList _menuTrigger = KeybindList.Parse("LeftShift + C");
    public KeybindList menuTrigger { get { return _menuTrigger; } set { _menuTrigger = value; } }
}
