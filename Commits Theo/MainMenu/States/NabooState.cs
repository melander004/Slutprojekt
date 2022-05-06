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
    Texture2D Bakgrund1;

    Texture2D Bakgrund2;

    Texture2D nabooFloor;
    
    Vector2 BakgrundPos;

    Vector2 nabooFloorPos;
  
    public NabooState(Game1 game, GraphicsDevice graphicsDevice, ContentManager content) 
      : base(game, graphicsDevice, content)
    {
      Bakgrund1 = _game.Content.Load<Texture2D>("Textures/Naboo_Bakgrund");
      Bakgrund2 = _game.Content.Load<Texture2D>("Textures/Naboo_Bakgrund(16 9)");
      BakgrundPos = new Vector2(0,0);

      nabooFloor = _game.Content.Load<Texture2D>("Textures/Naboo_Hangar");
      nabooFloorPos = new Vector2(0, Resolution.Height-50);
    }

    public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
    {
      spriteBatch.Begin();

      if(Resolution.Width == 800){
        spriteBatch.Draw(Bakgrund1, BakgrundPos, Color.White);
      }      

      if(Resolution.Width == 1280){
        spriteBatch.Draw(Bakgrund2, BakgrundPos, null, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);
      }

      if(Resolution.Width == 1600){
        spriteBatch.Draw(Bakgrund2, BakgrundPos, null, Color.White, 0f, Vector2.Zero, 1.25f, SpriteEffects.None, 0f);
      }

      if(Resolution.Width == 1920){
        spriteBatch.Draw(Bakgrund2, BakgrundPos, null, Color.White, 0f, Vector2.Zero, 1.5f, SpriteEffects.None, 0f);
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