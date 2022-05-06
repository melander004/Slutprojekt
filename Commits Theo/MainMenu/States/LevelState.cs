using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using MainMenu.Controls;
using MainMenu;

namespace MainMenu.States
{
    public class LevelState : State
    {
        private List<Component> _components;

        public LevelState(Game1 game, GraphicsDevice graphicsDevice, ContentManager content) 
        : base(game, graphicsDevice, content)
        {
            var buttonTexture = _content.Load<Texture2D>("Controls/Button");
            var buttonFont = _content.Load<SpriteFont>("Fonts/Font");

            var nabooButton = new Button(buttonTexture, buttonFont)
            {
              Position = new Vector2(Resolution.Width/4-80, Resolution.Height/2-20),
              Text = "Naboo",
            };

            nabooButton.Click += NabooButton_Click;

            var coruscantButton = new Button(buttonTexture, buttonFont)
            {
              Position = new Vector2(Resolution.Width/2-80, Resolution.Height/2-20),
              Text = "Coruscant",
            };

            coruscantButton.Click += CoruscantButton_Click;

            var mustafarButton = new Button(buttonTexture, buttonFont)
            {
              Position = new Vector2(Resolution.Width/1.333333333333333333f-80, Resolution.Height/2-20),
              Text = "Mustafar",
            };

            mustafarButton.Click += MustafarButton_Click;

            var backButton = new Button(buttonTexture, buttonFont)
            {
                Position = new Vector2(Resolution.Width/20, Resolution.Height/1.1f),
                Text = "Back",
            };

            backButton.Click += BackButton_Click;

            _components = new List<Component>()
            {
                nabooButton,
                mustafarButton,
                coruscantButton,
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

        private void NabooButton_Click(object sender, EventArgs e)
        {
            _game.ChangeState(new NabooState(_game, _graphicsDevice, _content));
        }

        private void MustafarButton_Click(object sender, EventArgs e)
        {
            _game.ChangeState(new MustafarState(_game, _graphicsDevice, _content));
        }

        private void CoruscantButton_Click(object sender, EventArgs e)
        {
            _game.ChangeState(new CoruscantState(_game, _graphicsDevice, _content));
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            _game.ChangeState(new MenuState(_game, _graphicsDevice, _content));
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