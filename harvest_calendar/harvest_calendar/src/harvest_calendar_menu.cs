using Microsoft.Xna.Framework.Graphics;
using StardewValley.Menus;
using StardewValley;
using Microsoft.Xna.Framework;


public class harvestCalendarMenu : Billboard
{
    public harvestCalendarMenu() { }
    public override void performHoverAction(int x, int y) { }

    public override void draw(SpriteBatch b)
    {
        Texture2D billboardTexture = Game1.temporaryContent.Load<Texture2D>("LooseSprites\\Billboard");

        b.Draw(Game1.fadeToBlackRect, Game1.graphics.GraphicsDevice.Viewport.Bounds, Color.Black * 0.75f);
        b.Draw(billboardTexture, new Vector2((float) this.xPositionOnScreen, (float) this.yPositionOnScreen), new Rectangle(0, 198, 301, 198), Color.White, 0.0f, Vector2.Zero, 4f, SpriteEffects.None, 1f);


        b.DrawString(Game1.dialogueFont, Utility.getSeasonNameFromNumber(Utility.getSeasonNumber(Game1.currentSeason)), new Vector2((float) (this.xPositionOnScreen + 160), (float) (this.yPositionOnScreen + 80)), Game1.textColor);
        b.DrawString(Game1.dialogueFont, Game1.content.LoadString("Strings\\UI:Billboard_Year", (object) Game1.year), new Vector2((float) (this.xPositionOnScreen + 448), (float) (this.yPositionOnScreen + 80)), Game1.textColor);

        for (int index = 0; index < this.calendarDays.Count; ++index)
        {
          if (Game1.dayOfMonth > index + 1)
            b.Draw(Game1.staminaRect, this.calendarDays[index].bounds, Color.Gray * 0.25f);
          else if (Game1.dayOfMonth == index + 1)
          {
            int num = (int) (4.0 * (double) Game1.dialogueButtonScale / 8.0);
            IClickableMenu.drawTextureBox(b, Game1.mouseCursors, new Rectangle(379, 357, 3, 3), this.calendarDays[index].bounds.X - num, this.calendarDays[index].bounds.Y - num, this.calendarDays[index].bounds.Width + num * 2, this.calendarDays[index].bounds.Height + num * 2, Color.Blue, 4f, false);
          }
        }
    }
}

