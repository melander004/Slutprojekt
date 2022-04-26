using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace Slutprojekt
{

    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Song Naboo_music;

        Texture2D Bakgrund;
        Vector2 Bakgrundpos;

        

        Floor tile;        

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {

            tile = new Floor();
            // TODO: Add your initialization logic here
            tile.Initialize(Content);
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            Bakgrund = this.Content.Load<Texture2D>("Naboo_bakgrund2");
            Bakgrundpos = new Vector2(0,0);
            Naboo_music = this.Content.Load<Song>("Naboo");
            MediaPlayer.Play(Naboo_music);
            MediaPlayer.Volume = MusicVolume.Volume;

            // TODO: use this.Content to load your game content here

        }
        
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.SlateGray);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            _spriteBatch.Draw(Bakgrund, Bakgrundpos, Color.White);
            tile.Draw(_spriteBatch);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}