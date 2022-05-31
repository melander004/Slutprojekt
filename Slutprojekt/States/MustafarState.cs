using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using Slutprojekt.Models;
using Slutprojekt.Sprites;

namespace Slutprojekt.States
{
  public class MustafarState : State
  {
    Texture2D defaultBackground;

    Texture2D background;
    
    Texture2D mustafarFloor;
    
    Vector2 backgroundPos;

    Vector2 mustafarFloorPos;

    Song AvO;

    private List<Sprite> _sprites;

    Texture2D Enemy;
    public Rectangle enemyRect = new Rectangle(500, Resolution.Height/5, 45, 70);
    
    public MustafarState(Game1 game, GraphicsDevice graphicsDevice, ContentManager content) 
      : base(game, graphicsDevice, content)
    {
      defaultBackground = _game.Content.Load<Texture2D>("Textures/Mustafar_Bakgrund");
      background = _game.Content.Load<Texture2D>("Textures/Mustafar_Bakgrund(16 9)");
      backgroundPos = new Vector2(0,0);

      mustafarFloor = _game.Content.Load<Texture2D>("Textures/Mustafar_Floor");
      mustafarFloorPos = new Vector2(0, Resolution.Height/3.5f);

      AvO = _game.Content.Load<Song>("Audio/Mustafar");
      MediaPlayer.Play(AvO);

      Enemy = _game.Content.Load<Texture2D>("Enemy/Anakin");

      var animations = new Dictionary<string, Animation>(){
        { "PlayerRight", new Animation(_game.Content.Load<Texture2D>("Player/ObiwanWalk"), 12) },
        { "PlayerLeft", new Animation(_game.Content.Load<Texture2D>("Player/ObiwanRev"), 12) },
        { "PlayerAttack", new Animation(_game.Content.Load<Texture2D>("Player/ObiwanAtt"), 3) },
        { "PlayerIdle", new Animation(_game.Content.Load<Texture2D>("Player/ObiwanAFK"), 1) },
      };

      _sprites = new List<Sprite>(){
        new Sprite(new Dictionary<string, Animation>(){
          { "PlayerRight", new Animation(_game.Content.Load<Texture2D>("Player/ObiwanWalk"), 12) },
          { "PlayerLeft", new Animation(_game.Content.Load<Texture2D>("Player/ObiwanRev"), 12) },
          { "PlayerAttack", new Animation(_game.Content.Load<Texture2D>("Player/ObiwanAtt"), 3) },
          { "PlayerIdle", new Animation(_game.Content.Load<Texture2D>("Player/ObiwanAFK"), 1) },
        })
        {
          Position = new Vector2(100,Resolution.Height/5),
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
          spriteBatch.Draw(mustafarFloor, new Vector2((int)mustafarFloorPos.X + (i*mustafarFloor.Width), (int)mustafarFloorPos.Y), Color.White);
      }  

      foreach (var sprite in _sprites)
        sprite.Draw(spriteBatch);
    
      spriteBatch.Draw(Enemy, enemyRect, Color.White);

      spriteBatch.End();
    }

    public override void PostUpdate(GameTime gameTime)
    {

    }

    public override void Update(GameTime gameTime)
    {
      foreach (var sprite in _sprites)
        sprite.Update(gameTime, _sprites);
    }
  }
}
