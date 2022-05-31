using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using Slutprojekt;
using Slutprojekt.Models;
using Slutprojekt.Sprites;

namespace Slutprojekt.States
{
  public class NabooState : State
  {
    Texture2D defaultBackground;

    Texture2D background;

    Texture2D nabooFloor;
    
    Vector2 backgroundPos;

    Vector2 nabooFloorPos;

    Song DOF;

    private List<Sprite> _sprites;

    Texture2D enemy;

    public Rectangle enemyRect = new Rectangle(500, Resolution.Height-105, 84, 58);
  
    // Loads textures, music, animations and positions for the state.
    public NabooState(Game1 game, GraphicsDevice graphicsDevice, ContentManager content) 
      : base(game, graphicsDevice, content)
    {
      defaultBackground = _game.Content.Load<Texture2D>("Textures/Naboo_Bakgrund");
      background = _game.Content.Load<Texture2D>("Textures/Naboo_Bakgrund(16 9)");
      backgroundPos = new Vector2(0,0);

      nabooFloor = _game.Content.Load<Texture2D>("Textures/Naboo_Hangar");
      nabooFloorPos = new Vector2(0, Resolution.Height-50);

      DOF = _game.Content.Load<Song>("Audio/Naboo");
      MediaPlayer.Play(DOF);

      enemy = _game.Content.Load<Texture2D>("Enemy/darthmaulAFK");

      var animations = new Dictionary<string, Animation>()
      {
        { "PlayerRight", new Animation(_game.Content.Load<Texture2D>("Player/ObiwanWalk"), 12) },
        { "PlayerLeft", new Animation(_game.Content.Load<Texture2D>("Player/ObiwanRev"), 12) },
        { "PlayerAttack", new Animation(_game.Content.Load<Texture2D>("Player/ObiwanAtt"), 3) },
        { "PlayerIdle", new Animation(_game.Content.Load<Texture2D>("Player/ObiwanAFK"), 1) },
      };

      _sprites = new List<Sprite>()
      {
        new Sprite(new Dictionary<string, Animation>(){
          { "PlayerRight", new Animation(_game.Content.Load<Texture2D>("Player/ObiwanWalk"), 12) },
          { "PlayerLeft", new Animation(_game.Content.Load<Texture2D>("Player/ObiwanRev"), 12) },
          { "PlayerAttack", new Animation(_game.Content.Load<Texture2D>("Player/ObiwanAtt"), 3) },
          { "PlayerIdle", new Animation(_game.Content.Load<Texture2D>("Player/ObiwanAFK"), 1) },
        })
        {
          Position = new Vector2(100,Resolution.Height-110),
          Input = new Input()
          {
            Up = Keys.W,
            Down = Keys.S,
            Left = Keys.A,
            Right = Keys.D,
            Attack = Keys.Enter,
          },
        },
      };
    }

    public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
    {
      spriteBatch.Begin();

      // Draws the default Naboo background (800x800 px).
      if(Resolution.Width == 800)
        spriteBatch.Draw(defaultBackground, backgroundPos, Color.White);

      // Draws the 16:9 version of the Naboo background and scales it to the correct resolution. (1f, 1.25f and 1.5f)
      if(Resolution.Width == 1280)
        spriteBatch.Draw(background, backgroundPos, null, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);

      if(Resolution.Width == 1600)
        spriteBatch.Draw(background, backgroundPos, null, Color.White, 0f, Vector2.Zero, 1.25f, SpriteEffects.None, 0f);

      if(Resolution.Width == 1920)
        spriteBatch.Draw(background, backgroundPos, null, Color.White, 0f, Vector2.Zero, 1.5f, SpriteEffects.None, 0f);

      // Draws the Naboo floor texture, "i<100" means that the texture is loaded 99 times because of the different resolutions.
      for (int i = 0; i<100; i++)
        spriteBatch.Draw(nabooFloor, new Vector2((int)nabooFloorPos.X + (i*nabooFloor.Width), (int)nabooFloorPos.Y), Color.White);

      // Draws the sprites that should be shown on the screen.
      foreach (var sprite in _sprites)
        sprite.Draw(spriteBatch);
    
      spriteBatch.Draw(enemy, enemyRect, Color.White);

      spriteBatch.End();
    }

    public override void PostUpdate(GameTime gameTime)
    {

    }

    public override void Update(GameTime gameTime)
    {
      // Updates the sprites position and animation.
      foreach (var sprite in _sprites)
        sprite.Update(gameTime, _sprites);
    }
  }
}