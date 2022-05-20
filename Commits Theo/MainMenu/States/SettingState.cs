using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using MainMenu.Controls;

namespace MainMenu.States
{
  public class SettingState : State 
  {
        private List<Component> _components;

        public SettingState(Game1 game, GraphicsDevice graphicsDevice, ContentManager content) 
        : base(game, graphicsDevice, content)
        {
            var buttonTexture = _content.Load<Texture2D>("Controls/Button");
            var buttonFont = _content.Load<SpriteFont>("Fonts/Font");

            var videoButton = new Button(buttonTexture, buttonFont)
            {
                Position = new Vector2(((Resolution.Width/2)-80-160), ((Resolution.Height/2)-20)),
                Text = "Video Settings",
            };

            videoButton.Click += VideoButton_Click;

            var audioButton = new Button(buttonTexture, buttonFont)
            {
                Position = new Vector2(((Resolution.Width/2)-80+160), ((Resolution.Height/2)-20)),
                Text = "Audio Settings",
            };

            audioButton.Click += AudioButton_Click;

            var backButton = new Button(buttonTexture, buttonFont)
            {
                Position = new Vector2(Resolution.Width/20, Resolution.Height/1.1f),
                Text = "Back",
            };

            backButton.Click += BackButton_Click;
            
            _components = new List<Component>()
            {
                videoButton,
                audioButton,
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

        ///<summary>
        /// If videoButton is pressed the state changes to the videoSettingState.
        ///</summary>
        private void VideoButton_Click(object sender, EventArgs e)
        {
            _game.ChangeState(new VideoSettingState(_game, _graphicsDevice, _content));
        }

        ///<summary>
        /// If audioButton is pressed the state changes to the AudioSettingState.
        ///</summary>
        private void AudioButton_Click(object sender, EventArgs e)
        {
            _game.ChangeState(new AudioSettingState(_game, _graphicsDevice, _content));
        }

        ///<summary>
        /// When backButton is pressed the state changes to the previous state (in this case the MenuState).
        ///</summary>
        private void BackButton_Click(object sender, EventArgs e)
        {
            _game.ChangeState(new MenuState(_game, _graphicsDevice, _content));
        }

        public override void PostUpdate(GameTime gameTime)
        {
            // remove sprites if they're not needed
        }

        public override void Update(GameTime gameTime)
        {
            foreach (var component in _components)
                component.Update(gameTime);
        }
    }
}