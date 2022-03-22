using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace sprite_class
{
    class Sprite 
    {
        //säter upp sprite och kollar values associerade med sprite
        protected KeyboardState _currentKey;

        protected KeyboardState _previousKey;

        public Vector2 _position;

        public Color colour = Color.White;

        public float speed = 0f;

        public float health = 20f;
        
        public bool isRemoved = false; 

        public Input Input;
        
        protected Texture2D _texture;
        public Sprite(Texture2D texture){_texture = texture;}
        
        public new Rectangle
        {
            get
            {
                return new Rectangle((int) Position.X , (int)Position.Y, _texture.Width , _texture.Hight);
            }
        }
        public virtual void Update(GameTime gameTime , List<Sprite> sprite)
        {

        }
    }
}
