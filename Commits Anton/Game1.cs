using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Slutprojekt.States;

namespace Slutprojekt
{

    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private State _currentState;

        private State _nextState;

        public void ChangeState(State state)
        {
            _nextState = state;
        }
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

            _currentState = new MenuState(this, _graphics.GraphicsDevice, Content);

            Bakgrund = this.Content.Load<Texture2D>("Naboo_bakgrund2");
            Bakgrundpos = new Vector2(0,0);
            Naboo_music = this.Content.Load<Song>("Naboo");
            MediaPlayer.Play(Naboo_music);
            MediaPlayer.Volume = MusicVolume.Volume;

            // TODO: use this.Content to load your game content here

        }
        
        protected override void Update(GameTime gameTime)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
                ChangeState(new MenuState(this, _graphics.GraphicsDevice, Content));

            if(_nextState != null)
            {
                _currentState = _nextState;

                _nextState = null;
            }

            _currentState.Update(gameTime);

            _currentState.PostUpdate(gameTime);

            _graphics.PreferredBackBufferWidth = Resolution.Width;
            _graphics.PreferredBackBufferHeight = Resolution.Height;
            _graphics.ApplyChanges();


            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.SlateGray);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();

            _currentState.Draw(gameTime, _spriteBatch);
            


            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}