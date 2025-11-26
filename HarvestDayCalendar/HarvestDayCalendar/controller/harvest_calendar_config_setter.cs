using StardewModdingAPI.Utilities;

namespace HarvestCalendar.Model.Config;

internal class HarvestCalendarConfig
{
    private string defaultKeyBind = "LeftShift + C";
    private KeybindList _menuTrigger = KeybindList.Parse(defaultKeyBind);
    public KeybindList menuTrigger { get { return _menuTrigger; } set { _menuTrigger = value; } }
}
