using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using SSW.Controls;
using SSW.Sprite;


namespace SSW.States
{
    class GameState : State
    {
        private SpriteFont font;

        private List<Sprite> sprites;

        public static int screenWidth = 800;

        public static int screenHeight = 800;

        public static Random random;

        private Texture2D gameBackGroundTexture;

        public GameState(Game1 game, ContentManager content) 
            : base(game, content)
        {
            random = new Random();
        }

        public override void LoadContent()
        {
            // Ladda in alla texturer

            sprites = new List<Sprite>
            gameBackGroundTexture = Content.Load<Texture2D>("Background");
        }


    }
}