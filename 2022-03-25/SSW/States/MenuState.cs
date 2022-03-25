using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

namespace SSW.States
{
    public class MenuState : State
    {
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