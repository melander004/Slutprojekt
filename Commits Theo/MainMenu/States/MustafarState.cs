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
  public class MustafarState : State
  {
    Texture2D Bakgrund1;

    Texture2D Bakgrund2;
    
    Texture2D mustafarFloor;
    
    Vector2 BakgrundPos;

    Vector2 mustafarFloorPos;
    
    public MustafarState(Game1 game, GraphicsDevice graphicsDevice, ContentManager content) 
      : base(game, graphicsDevice, content)
    {
      Bakgrund1 = _game.Content.Load<Texture2D>("Textures/Mustafar_Bakgrund");
      Bakgrund2 = _game.Content.Load<Texture2D>("Textures/Mustafar_Bakgrund(16 9)");
      BakgrundPos = new Vector2(0,0);

      mustafarFloor = _game.Content.Load<Texture2D>("Textures/Mustafar_Floor");
      mustafarFloorPos = new Vector2(0, Resolution.Height/3.5f);
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
          spriteBatch.Draw(mustafarFloor, new Vector2((int)mustafarFloorPos.X + (i*mustafarFloor.Width), (int)mustafarFloorPos.Y), Color.White);
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