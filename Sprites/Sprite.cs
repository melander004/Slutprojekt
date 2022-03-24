using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using sprite_test.Models;


namespace sprite_test.Sprites
{
    class Sprite 
    {
        //säter upp sprite och kollar values associerade med sprite


        public Vector2 _position;

        public Color colour = Color.White;

        public float speed = 0f;

        public float health = 20f;
        
        public bool isRemoved = false; 

        
        protected Texture2D _texture;
        public Sprite(Texture2D texture){_texture = texture;}
        
        public Rectangle Rectangle
        {
            get
            {
                if(_texture != null){
                    return new Rectangle((int) _position.X , (int) _position.Y, _texture.Width , _texture.Height);
                }
                throw new Exception("unown sprite");
            }
        }
        public virtual void Update(GameTime gameTime , List<Sprite> sprite)
        {

        }

        public virtual void Draw(SpriteBatch spriteBatch){
            spriteBatch.Draw( _texture, _position, Color.White);
        }
    }
}