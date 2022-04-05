using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using SpriteClass.Models;

namespace SpriteClass.Sprites
{
    public class Sprite
    {
        protected Texture2D _texture;

        public Vector2 Origin;
        public Vector2 Position;
        public Vector2 Velocity;
        
        protected bool _direction;

        public float RotationVelocity = 3f;
        public float LinearVelocity = 4f;

        public Input Input;
        public bool IsRemoved = false;

        protected KeyboardState _currentKey;
        protected KeyboardState _previousKey;

        public Sprite(Texture2D texture)
        {
            _texture = texture;
        }

        public Rectangle Rectangle
        {
            get
            {
                return new Rectangle((int)Position.X, (int)Position.Y, _texture.Width, _texture.Height);
            }
        }



        public virtual void Update(GameTime gameTime, List<Sprite> sprites)
        {
            if(Keyboard.GetState().IsKeyDown(Keys.D)){
                _direction = true;
            }
            
            if(Keyboard.GetState().IsKeyDown(Keys.A)){
                _direction = false;
            }
        }


        public virtual void Draw(SpriteBatch spriteBatch)
        {
            if (_texture != null )
            {
                if(_direction == true)
                    spriteBatch.Draw(_texture, Position, null, Color.White, 0 , Origin, 1, SpriteEffects.None, 0);
                else{
                    spriteBatch.Draw(_texture, Position, null, Color.White, 0 , Origin, 1, SpriteEffects.FlipHorizontally,0);
                }

            }
        }
    }
}