using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using MainMenu.Controls;

namespace MainMenu.States
{
  public class MenuState : State 
  {
        private List<Component> _components;
        public MenuState(Game1 game, GraphicsDevice graphicsDevice, ContentManager content) 
        : base(game, graphicsDevice, content)
        {
            var buttonTexture = _content.Load<Texture2D>("Controls/Button");
            var buttonFont = _content.Load<SpriteFont>("Fonts/Font");

            var levelsButton = new Button(buttonTexture, buttonFont)
            {
                Position = new Vector2(((Resolution.Width/2)-80), (((Resolution.Height/2)-20)-50)),
                Text = "Levels",
            };

            levelsButton.Click += LevelsButton_Click;

            var settingsButton = new Button(buttonTexture, buttonFont)
            {
                Position = new Vector2(((Resolution.Width/2)-80), ((Resolution.Height/2)-20)),
                Text = "Settings",
            };

            settingsButton.Click += SettingsButton_Click;

            var quitButton = new Button(buttonTexture, buttonFont)
            {
                Position = new Vector2(((Resolution.Width/2)-80), (((Resolution.Height/2)-20)+50)),
                Text = "Quit",
            };

            quitButton.Click += QuitButton_Click;

            _components = new List<Component>()
            {
                levelsButton,
                settingsButton,
                quitButton,
            };
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();

            foreach (var component in _components)
                component.Draw(gameTime, spriteBatch);

            spriteBatch.End();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            _game.ChangeState(new SettingState(_game, _graphicsDevice, _content));
        }

        private void LevelsButton_Click(object sender, EventArgs e)
        {
            _game.ChangeState(new LevelState(_game, _graphicsDevice, _content));
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

        private void QuitButton_Click(object sender, EventArgs e)
        {
            _game.Exit();
        }
    }
}