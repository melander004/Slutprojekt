using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Slutprojekt.Controls;

namespace Slutprojekt.States
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

        private void VideoButton_Click(object sender, EventArgs e)
        {
            _game.ChangeState(new VideoSettingState(_game, _graphicsDevice, _content));
        }

        private void AudioButton_Click(object sender, EventArgs e)
        {
            _game.ChangeState(new AudioSettingState(_game, _graphicsDevice, _content));
        }

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