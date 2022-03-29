using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Content;
using SSW.Controls;

namespace SSW.States
{
    public class MenuState : State
    {
        private List<Component> _components;
        private Texture2D menuBackGroundTexture;

        public MenuState(Game1 game, ContentManager content) 
        : base(game, content)
        {
        }
        public override void LoadContent()
        {
            var buttonTexture = _content.Load<Texture2D>("Controls/Button");
            var buttonFont = _content.Load<Texture2D>("ButtonFonts/Font");
            menuBackGroundTexture = _content.Load<Texture2D>("Backgrounds/Menu");

            _components = new List<Component>(){

            new ButtonState(buttonTexture, buttonFont)
            {
                Text = "Player",
                Position = new Vector2(Game1.ScreenWidth/2, 400),
                Click = new EventHandler(Button_Player_Clicked),
                // Layer 0.1f;
            },

            new ButtonState(buttonTexture, buttonFont)
            {
                Text = "Options",
                Position = new Vector2(Game1.ScreenWidth/2, 400),
                Click = new EventHandler(Button_Options_Clicked),
                // Layer 0.1f
            },

            new ButtonState(buttonTexture, buttonFont)
            {
                Text = "Quit",
                Position = new Vector2(Game1.ScreenWidth/2, 400),
                Click = new EventHandler(Button_Quit_Clicked),
                // Layer 0.1f;
            },
        };
        }
        
        private void Button_Player_Clicked(object sender, EventArgs args)
        {
            _game.ChangeState(new GameState(_game, _content)){
                PlayerCount = 1,
            }
        }

        private void Button_Options_Clicked(object sender, EventArgs args)
        {
            _game.ChangeState(new GameState(_game, _content))

        }

        private void Button_Quit_Clicked(object sender, EventArgs args)
        {
            _game.Exit();

        }
        public override void Update(GameTime gameTime)
        {
            throw new System.NotImplementedException();
        }
 
        public override void PostUpdate(GameTime gameTime)
        {
            throw new System.NotImplementedException();
        }

           public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            throw new System.NotImplementedException();
        }
    }
}
