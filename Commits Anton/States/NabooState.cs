using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Slutprojekt;

namespace Slutprojekt.States
{
  public class NabooState : State
  {
    Texture2D Bakgrund_Naboo;

    Texture2D Bakgrund_Naboo2;
    
    Vector2 BakgrundPos;

    Texture2D texture_Naboo;

    Vector2 position;

    int Length = 100;
    
    public NabooState(Game1 game, GraphicsDevice graphicsDevice, ContentManager content) 
      : base(game, graphicsDevice, content)
    {
      Bakgrund_Naboo = _game.Content.Load<Texture2D>("Naboo_Bakgrund2");
      Bakgrund_Naboo2 = _game.Content.Load<Texture2D>("Naboo_Bakgrund(16 9)");
      BakgrundPos = new Vector2(0,0);
      texture_Naboo = _game.Content.Load<Texture2D>("Naboo_hangar2 (1)");
      position = new Vector2(0, Resolution.Height-50);
    }

    

    public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
    {
      spriteBatch.Begin();

      if(Resolution.Width == 800){
        spriteBatch.Draw(Bakgrund_Naboo, BakgrundPos, Color.White);
        for(int i = 0; i<Length;i++){
          spriteBatch.Draw(texture_Naboo, new Vector2((int)position.X + (i*texture_Naboo.Width), (int)position.Y), Color.White);
        }
      }      

      if(Resolution.Width == 1280){
        spriteBatch.Draw(Bakgrund_Naboo2, BakgrundPos, null, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);
        for(int i = 0; i<Length;i++){
          spriteBatch.Draw(texture_Naboo, new Vector2((int)position.X + (i*texture_Naboo.Width), (int)position.Y), Color.White);
        }
      }

      if(Resolution.Width == 1600){
        spriteBatch.Draw(Bakgrund_Naboo2, BakgrundPos, null, Color.White, 0f, Vector2.Zero, 1.25f, SpriteEffects.None, 0f);
        for(int i = 0; i<Length;i++){
          spriteBatch.Draw(texture_Naboo, new Vector2((int)position.X + (i*texture_Naboo.Width), (int)position.Y), Color.White);
        }
      }

      if(Resolution.Width == 1920){
        spriteBatch.Draw(Bakgrund_Naboo2, BakgrundPos, null, Color.White, 0f, Vector2.Zero, 1.5f, SpriteEffects.None, 0f);
        for(int i = 0; i<Length;i++){
          spriteBatch.Draw(texture_Naboo, new Vector2((int)position.X + (i*texture_Naboo.Width), (int)position.Y), Color.White);
        }      
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