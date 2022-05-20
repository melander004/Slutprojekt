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
  public class NabooState : State
  {
    Texture2D Bakgrund_Naboo;

    Texture2D Bakgrund_Naboo2;
    
    Vector2 BakgrundPos;

    Texture2D texture_Naboo;

    Vector2 position;

    Song DOF;

    int Length = 100;
    
    public NabooState(Game1 game, GraphicsDevice graphicsDevice, ContentManager content) 
      : base(game, graphicsDevice, content)
    {
      Bakgrund_Naboo = _game.Content.Load<Texture2D>("Textures/Naboo_Bakgrund");
      Bakgrund_Naboo2 = _game.Content.Load<Texture2D>("Textures/Naboo_Bakgrund(16 9)");
      BakgrundPos = new Vector2(0,0);
      texture_Naboo = _game.Content.Load<Texture2D>("Textures/Naboo_hangar");
      position = new Vector2(0, Resolution.Height-50);
      DOF = _game.Content.Load<Song>("Audio/Naboo");
      MediaPlayer.Play(DOF);
    }

    

    public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
    {
      spriteBatch.Begin();

      //Draws the 800x800 px version of the Naboo background.
      if(Resolution.Width == 800){
        spriteBatch.Draw(Bakgrund_Naboo, BakgrundPos, Color.White);
        
      }      
      //Draws the 16:9 version of the Naboo background. 
      if(Resolution.Width == 1280){
        spriteBatch.Draw(Bakgrund_Naboo2, BakgrundPos, null, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);
        
      }
      
      //Draws the 16:9 version of the Naboo background and scales it to the right resolution. 
      if(Resolution.Width == 1600){
        spriteBatch.Draw(Bakgrund_Naboo2, BakgrundPos, null, Color.White, 0f, Vector2.Zero, 1.25f, SpriteEffects.None, 0f);
      }

      if(Resolution.Width == 1920){
        spriteBatch.Draw(Bakgrund_Naboo2, BakgrundPos, null, Color.White, 0f, Vector2.Zero, 1.5f, SpriteEffects.None, 0f);
           
      } 
      //Draws the Naboo floor
      for(int i = 0; i<Length;i++){
        spriteBatch.Draw(texture_Naboo, new Vector2((int)position.X + (i*texture_Naboo.Width), (int)position.Y), Color.White);
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