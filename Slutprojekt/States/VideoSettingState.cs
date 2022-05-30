using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Slutprojekt.Controls;

namespace Slutprojekt.States

{
    public class VideoSettingState : State
    {
        private List<Component> _components;

        public VideoSettingState(Game1 game, GraphicsDevice graphicsDevice, ContentManager content) 
        : base(game, graphicsDevice, content)
        {
            var buttonTexture = _content.Load<Texture2D>("Controls/Button");
            var buttonFont = _content.Load<SpriteFont>("Fonts/Font");

            var resolutionButton1 = new Button(buttonTexture, buttonFont)
            {
                Position = new Vector2(((Resolution.Width/2)-80), (((Resolution.Height/2-50)-20)-50)),
                Text = "1920x1080",
            };
            
            resolutionButton1.Click += ResolutionButton1_Click;

            var resolutionButton2 = new Button(buttonTexture, buttonFont)
            {
                Position = new Vector2(((Resolution.Width/2)-80), (((Resolution.Height/2)-20)-50)),
                Text = "1600x900",
            };

            resolutionButton2.Click += ResolutionButton2_Click;

            var resolutionButton3 = new Button(buttonTexture, buttonFont)
            {
                Position = new Vector2(((Resolution.Width/2)-80), (((Resolution.Height/2+50)-20)-50)),
                Text = "1280x720",
            };

            resolutionButton3.Click += ResolutionButton3_Click;

            var resolutionButton4 = new Button(buttonTexture, buttonFont)
            {
                Position = new Vector2(((Resolution.Width/2)-80), (((Resolution.Height/2+100)-20)-50)),
                Text = "800x800",
            };

            resolutionButton4.Click += ResolutionButton4_Click;

            var backButton = new Button(buttonTexture, buttonFont)
            {
                Position = new Vector2(Resolution.Width/20, Resolution.Height/1.1f),
                Text = "Back",
            };

            backButton.Click += BackButton_Click;

            _components = new List<Component>()
            {
                resolutionButton1,
                resolutionButton2,
                resolutionButton3,
                resolutionButton4,
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

        private void ResolutionButton1_Click(object sender, EventArgs e)
        {
            Resolution.Width = 1920;
            Resolution.Height = 1080;
            _game.ChangeState(new VideoSettingState(_game, _graphicsDevice, _content));
        }

        private void ResolutionButton2_Click(object sender, EventArgs e)
        {
            Resolution.Width = 1600;
            Resolution.Height = 900;
            _game.ChangeState(new VideoSettingState(_game, _graphicsDevice, _content));
        }

        private void ResolutionButton3_Click(object sender, EventArgs e)
        {
            Resolution.Width = 1280;
            Resolution.Height = 720;
            _game.ChangeState(new VideoSettingState(_game, _graphicsDevice, _content));
        }

        private void ResolutionButton4_Click(object sender, EventArgs e)
        {
            Resolution.Width = 800;
            Resolution.Height = 800;
            _game.ChangeState(new VideoSettingState(_game, _graphicsDevice, _content));
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