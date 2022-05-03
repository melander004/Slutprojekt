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
    Texture2D Bakgrund1;

    Texture2D Bakgrund2;
    
    Vector2 BakgrundPos;

    Texture2D texture_Naboo;
    Texture2D texture_Mustafar;

    Vector2 position;

    int Length = 16;
    
    public NabooState(Game1 game, GraphicsDevice graphicsDevice, ContentManager content) 
      : base(game, graphicsDevice, content)
    {
      Bakgrund1 = _game.Content.Load<Texture2D>("Naboo_Bakgrund");
      Bakgrund2 = _game.Content.Load<Texture2D>("Naboo_Bakgrund(16 9)");
      BakgrundPos = new Vector2(0,0);
      texture_Mustafar = _game.Content.Load<Texture2D>("Mustafar_Floor");
      texture_Naboo = _game.Content.Load<Texture2D>("Naboo_hangar2 (1)");
      position = new Vector2(0, 430);
    }

    

    public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
    {
      spriteBatch.Begin();

      if(Resolution.Width == 800){
        spriteBatch.Draw(Bakgrund1, BakgrundPos, Color.White);
        for(int i = 0; i<Length;i++){
          spriteBatch.Draw(texture_Naboo, new Vector2((int)position.X + (i*texture_Naboo.Width), (int)position.Y), Color.White);
        }
      }      

      if(Resolution.Width == 1280){
        spriteBatch.Draw(Bakgrund2, BakgrundPos, null, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);
        for(int i = 0; i<Length;i++){
          spriteBatch.Draw(texture_Naboo, new Vector2((int)position.X + (i*texture_Naboo.Width), (int)position.Y), Color.White);
        }
      }

      if(Resolution.Width == 1600){
        spriteBatch.Draw(Bakgrund2, BakgrundPos, null, Color.White, 0f, Vector2.Zero, 1.25f, SpriteEffects.None, 0f);
        for(int i = 0; i<Length;i++){
          spriteBatch.Draw(texture_Naboo, new Vector2((int)position.X + (i*texture_Naboo.Width), (int)position.Y), Color.White);
        }
      }

      if(Resolution.Width == 1920){
        spriteBatch.Draw(Bakgrund2, BakgrundPos, null, Color.White, 0f, Vector2.Zero, 1.5f, SpriteEffects.None, 0f);
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