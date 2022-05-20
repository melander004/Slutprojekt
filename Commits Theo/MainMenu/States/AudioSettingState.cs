using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MainMenu.Controls;
using MainMenu;

namespace MainMenu.States

{
    public class AudioSettingState : State
    {
        private List<Component> _components;

        public AudioSettingState(Game1 game, GraphicsDevice graphicsDevice, ContentManager content) 
        : base(game, graphicsDevice, content)
        {
            var buttonTexture = _content.Load<Texture2D>("Controls/Button");
            var buttonFont = _content.Load<SpriteFont>("Fonts/Font");

            var volumeButton100 = new Button(buttonTexture, buttonFont)
            {
                Position = new Vector2(((Resolution.Width/2)-80), ((Resolution.Height/2)-120)),
                Text = "100%",
            };
            
            volumeButton100.Click += VolumeButton100_Click;

            var volumeButton75 = new Button(buttonTexture, buttonFont)
            {
                Position = new Vector2(((Resolution.Width/2)-80), ((Resolution.Height/2)-70)),
                Text = "75%",
            };
            
            volumeButton75.Click += VolumeButton75_Click;


             var volumeButton50 = new Button(buttonTexture, buttonFont)
            {
                Position = new Vector2(((Resolution.Width/2)-80), (((Resolution.Height/2)-20))),
                Text = "50%",
            };
            
            volumeButton50.Click += VolumeButton50_Click;


             var volumeButton25 = new Button(buttonTexture, buttonFont)
            {
                Position = new Vector2(((Resolution.Width/2)-80), ((Resolution.Height/2)+30)),
                Text = "25%",
            };
            
            volumeButton25.Click += VolumeButton25_Click;


             var volumeButton0 = new Button(buttonTexture, buttonFont)
            {
                Position = new Vector2(((Resolution.Width/2)-80), ((Resolution.Height/2)+80)),
                Text = "off",
            };
            
            volumeButton0.Click += VolumeButton0_Click;



            var backButton = new Button(buttonTexture, buttonFont)
            {
                Position = new Vector2(Resolution.Width/20, Resolution.Height/1.1f),
                Text = "Back",
            };

            backButton.Click += BackButton_Click;

            
            _components = new List<Component>()
            {
                volumeButton100,
                volumeButton75,
                volumeButton50,
                volumeButton25,
                volumeButton0,
                backButton,
            };
        }
        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();

            foreach (var component in _components)
                component.Draw(gameTime, spriteBatch);

            spriteBatch.End();
        }

        /// <summary>
        /// When you press the button named "volumeButton100" (with the text "100%" ingame) the volume changes to 100%.
        ///</summary>
        private void VolumeButton100_Click(object sender, EventArgs e)
        {
            Music.Volume = 1f;
        }

        private void VolumeButton75_Click(object sender, EventArgs e)
        {
            Music.Volume = 0.75f;
        }

        private void VolumeButton50_Click(object sender, EventArgs e)
        {
            Music.Volume = 0.5f;
        }

        private void VolumeButton25_Click(object sender, EventArgs e)
        {
            Music.Volume = 0.25f;
        }

        private void VolumeButton0_Click(object sender, EventArgs e)
        {
            Music.Volume = 0f;
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            _game.ChangeState(new SettingState(_game, _graphicsDevice, _content));
        }

        public override void PostUpdate(GameTime gameTime)
        {
           
        }
        public override void Update(GameTime gameTime)
        {
            foreach (var component in _components)
                component.Update(gameTime);
        }
    }
}