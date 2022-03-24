using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using sprite_test.Sprites;
using sprite_test.Models; 


namespace sprite_test.Sprites
{
    class Player : Sprite
    {
        public bool HasDied = false;

        public Player(Texture2D texture) : base(texture)
        {
            _position= new Vector2(30,40);
            speed =5f;
        }
        public override void Update(GameTime gameTime , List<Sprite> sprite)
        {
            Move();
        }

        public void Move()
        {
            if(Keyboard.GetState().IsKeyDown(Keys.W)){
                _position.Y -=3;
            }
            if(Keyboard.GetState().IsKeyDown(Keys.D)){
                _position.X +=3;
            }  
            if(Keyboard.GetState().IsKeyDown(Keys.A)){
                _position.X -=3;
            }      
        }
    }

}