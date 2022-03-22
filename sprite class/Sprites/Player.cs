using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace sprite_class
{
    class Player : Sprite
    {
        public bool HasDied = false;

        public Player(Texture2D texture) : base(texture)
        {
            _position = new Vector2(30,40);
            speed =5f;
        }
        public override void Update(GameTime gameTime , List<Sprite> sprite)
        {

        }
    }

}