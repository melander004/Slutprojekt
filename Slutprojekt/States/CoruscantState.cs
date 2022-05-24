using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Media;

namespace Slutprojekt.States
{
  public class CoruscantState : State
  {
    Texture2D defaultBackground;

    Texture2D background;
    
    Texture2D coruscantFloor;
    
    Vector2 backgroundPos;

    Vector2 coruscantFloorPos;
    
    Song AOvD;
    
    public CoruscantState(Game1 game, GraphicsDevice graphicsDevice, ContentManager content) 
      : base(game, graphicsDevice, content)
    {
      defaultBackground = _game.Content.Load<Texture2D>("Textures/Coruscant_Bakgrund");
      background = _game.Content.Load<Texture2D>("Textures/Coruscant_Bakgrund(16 9)");
      backgroundPos = new Vector2(0,0);

      coruscantFloor = _game.Content.Load<Texture2D>("Textures/Coruscant_Floor");
      coruscantFloorPos = new Vector2(0, Resolution.Height-50);

      AOvD = _game.Content.Load<Song>("Audio/Coruscant(Dooku)");
      MediaPlayer.Play(AOvD);
    }

    public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
    {
      spriteBatch.Begin();

      if(Resolution.Width == 800){
        spriteBatch.Draw(defaultBackground, backgroundPos, Color.White);
        for(int i = 0; i<100;i++){
          spriteBatch.Draw(coruscantFloor, new Vector2((int)coruscantFloorPos.X + (i*coruscantFloor.Width), (int)coruscantFloorPos.Y), Color.White);
        }
      }      

      if(Resolution.Width == 1280){
        spriteBatch.Draw(background, backgroundPos, null, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);
        for(int i = 0; i<100;i++){
          spriteBatch.Draw(coruscantFloor, new Vector2((int)coruscantFloorPos.X + (i*coruscantFloor.Width), (int)coruscantFloorPos.Y), Color.White);
        }
      }

      if(Resolution.Width == 1600){
        spriteBatch.Draw(background, backgroundPos, null, Color.White, 0f, Vector2.Zero, 1.25f, SpriteEffects.None, 0f);
        for(int i = 0; i<100;i++){
          spriteBatch.Draw(coruscantFloor, new Vector2((int)coruscantFloorPos.X + (i*coruscantFloor.Width), (int)coruscantFloorPos.Y), Color.White);
        }
      }

      if(Resolution.Width == 1920){
        spriteBatch.Draw(background, backgroundPos, null, Color.White, 0f, Vector2.Zero, 1.5f, SpriteEffects.None, 0f);
        for(int i = 0; i<100;i++){
          spriteBatch.Draw(coruscantFloor, new Vector2((int)coruscantFloorPos.X + (i*coruscantFloor.Width), (int)coruscantFloorPos.Y), Color.White);
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