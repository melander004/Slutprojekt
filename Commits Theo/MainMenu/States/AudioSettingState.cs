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

            var resolutionButton1 = new Button(buttonTexture, buttonFont)
            {
                Position = new Vector2(((Resolution.Width/2)-80), (((Resolution.Height/2-50)-20)-50)),
                Text = "1920x1080",
            };
            
            resolutionButton1.Click += ResolutionButton1_Click;

            var backButton = new Button(buttonTexture, buttonFont)
            {
                Position = new Vector2(Resolution.Width/20, Resolution.Height/1.1f),
                Text = "Back",
            };

            backButton.Click += BackButton_Click;

            _components = new List<Component>()
            {
                resolutionButton1,
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