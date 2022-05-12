using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Media;
using Slutprojekt;

namespace Slutprojekt.States
{
  public class CoruscantState : State
  {
    Texture2D Bakgrund_Coruscant;

    Texture2D Bakgrund_Coruscant2;
    
    Vector2 BakgrundPos;

    Texture2D texture_Coruscant;

    Vector2 position;

    Song AOvD;

    int Length = 100;
    
    public CoruscantState(Game1 game, GraphicsDevice graphicsDevice, ContentManager content) 
      : base(game, graphicsDevice, content)
    {
      Bakgrund_Coruscant = _game.Content.Load<Texture2D>("Textures/Coruscant_Bakgrund");
      Bakgrund_Coruscant2 = _game.Content.Load<Texture2D>("Textures/Coruscant_Bakgrund(16 9)");
      BakgrundPos = new Vector2(0,0);
      texture_Coruscant = _game.Content.Load<Texture2D>("Textures/Coruscant_Floor");
      position = new Vector2(0, Resolution.Height-50);
      AOvD = _game.Content.Load<Song>("Audio/Coruscant(Dooku)");
      MediaPlayer.Play(AOvD);
    }

    

    public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
    {
      spriteBatch.Begin();

      if(Resolution.Width == 800){
        spriteBatch.Draw(Bakgrund_Coruscant, BakgrundPos, Color.White);
        for(int i = 0; i<Length;i++){
          spriteBatch.Draw(texture_Coruscant, new Vector2((int)position.X + (i*texture_Coruscant.Width), (int)position.Y), Color.White);
        }
      }      

      if(Resolution.Width == 1280){
        spriteBatch.Draw(Bakgrund_Coruscant2, BakgrundPos, null, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);
        for(int i = 0; i<Length;i++){
          spriteBatch.Draw(texture_Coruscant, new Vector2((int)position.X + (i*texture_Coruscant.Width), (int)position.Y), Color.White);
        }
      }

      if(Resolution.Width == 1600){
        spriteBatch.Draw(Bakgrund_Coruscant2, BakgrundPos, null, Color.White, 0f, Vector2.Zero, 1.25f, SpriteEffects.None, 0f);
        for(int i = 0; i<Length;i++){
          spriteBatch.Draw(texture_Coruscant, new Vector2((int)position.X + (i*texture_Coruscant.Width), (int)position.Y), Color.White);
        }
      }

      if(Resolution.Width == 1920){
        spriteBatch.Draw(Bakgrund_Coruscant2, BakgrundPos, null, Color.White, 0f, Vector2.Zero, 1.5f, SpriteEffects.None, 0f);
        for(int i = 0; i<Length;i++){
          spriteBatch.Draw(texture_Coruscant, new Vector2((int)position.X + (i*texture_Coruscant.Width), (int)position.Y), Color.White);
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