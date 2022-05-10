using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace MainMenu.States
{
  public class NabooState : State
  {
    Texture2D defaultBackground;

    Texture2D background;

    Texture2D nabooFloor;
    
    Vector2 backgroundPos;

    Vector2 nabooFloorPos;
  
    public NabooState(Game1 game, GraphicsDevice graphicsDevice, ContentManager content) 
      : base(game, graphicsDevice, content)
    {
      defaultBackground = _game.Content.Load<Texture2D>("Textures/Naboo_Bakgrund");
      background = _game.Content.Load<Texture2D>("Textures/Naboo_Bakgrund(16 9)");
      backgroundPos = new Vector2(0,0);

      nabooFloor = _game.Content.Load<Texture2D>("Textures/Naboo_Hangar");
      nabooFloorPos = new Vector2(0, Resolution.Height-50);
    }

    public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
    {
      spriteBatch.Begin();

      if(Resolution.Width == 800){
        spriteBatch.Draw(defaultBackground, backgroundPos, Color.White);
      }      

      if(Resolution.Width == 1280){
        spriteBatch.Draw(background, backgroundPos, null, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);
      }

      if(Resolution.Width == 1600){
        spriteBatch.Draw(background, backgroundPos, null, Color.White, 0f, Vector2.Zero, 1.25f, SpriteEffects.None, 0f);
      }

      if(Resolution.Width == 1920){
        spriteBatch.Draw(background, backgroundPos, null, Color.White, 0f, Vector2.Zero, 1.5f, SpriteEffects.None, 0f);
      }

      for (int i = 0; i<100; i++){
          spriteBatch.Draw(nabooFloor, new Vector2((int)nabooFloorPos.X + (i*nabooFloor.Width), (int)nabooFloorPos.Y), Color.White);
      } 

      spriteBatch.End();
    }

    public override void PostUpdate(GameTime gameTime)
    {

    }

    public override void Update(GameTime gameTime)
    {

    }
  }
}