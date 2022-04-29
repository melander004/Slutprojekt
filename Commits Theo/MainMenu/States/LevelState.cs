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
  public class LevelState : State
  {
    public LevelState(Game1 game, GraphicsDevice graphicsDevice, ContentManager content) 
      : base(game, graphicsDevice, content)
    {
      tile = new Floor();
      tile.Initialize(content);
      
      Bakgrund = _game.Content.Load<Texture2D>("Textures/Naboo_bakgrund");
      BakgrundPos = new Vector2(0,0);
      
    }

    Texture2D Bakgrund;
    
    Vector2 BakgrundPos;

    Floor tile; 

    public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
    {
      spriteBatch.Begin();

      spriteBatch.Draw(Bakgrund, BakgrundPos, null, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);
      tile.Draw(spriteBatch);

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
