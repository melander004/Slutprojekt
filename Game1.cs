using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using sprite_test.Sprites;
using sprite_test.Models; 


namespace sprite_test
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private List<Sprite> _sprites;

        public Vector2 Position;
        public Texture2D _texture;

        public static int ScreenWidth = 1280;
        public static int ScreenHeight = 720;
        
 


        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;

            ScreenWidth = _graphics.PreferredBackBufferWidth;
            ScreenHeight = _graphics.PreferredBackBufferHeight;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
             _sprites = new List<Sprite>();

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

                foreach(var sprite in _sprites){
                    sprite.Update(gameTime, _sprites);
                }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            
            GraphicsDevice.Clear(Color.SlateGray);
            _spriteBatch.Begin();
            foreach(var sprite in _sprites){
                sprite.Draw(_spriteBatch);
            }
            _spriteBatch.End();
            

            base.Draw(gameTime);
        }
    }
}
