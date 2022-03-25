using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;
using System;

namespace SSW.Controls
{
    public class Button
    {
        #region Fields

        private MouseState _currentMouse;

        private SpriteFont _font;

        private bool _isHovering;

        private MouseState _previousState;

        private Texture2D _texture;

        #endregion

        #region Properties

        public bool Clicked { get; private set;}

        public float Layer { get; set;}

        public Vector2 Origin
        {
            get{
                return new Vector2(_texture.Width/2, _texture.Height/2);
            }
        }

        public Rectangle Rectangle
        {
            get{
                return new Rectangle((int)Position.X - ((int)Origin.X), (int)Position.Y - (int)Origin.Y, _texture.Width, _texture.Height);
            }
        }

        public String Text;

        #endregion

        #region Methods

        public Button(Texture2D texture, SpriteFont font)
        {
            _texture = texture;

            _font = font;
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            var color = Color.White;

            if(_isHovering)
                color = Color.Gray;

            spriteBatch.Draw(_texture, position, null, color, 0f, Origin, 1f, SpriteEffects.None, Layer);

            if(!string.IsNullOrEmpty(Text))
            {
                var x = (Rectangle.X + (Rectangle.Width/2)) - (_font.MeasureString(Text).X/2);
                var y = (Rectangle.Y + (Rectangle.Height/2)) - (_font.MeasureString(Text).Y/2);

                spriteBatch.DrawString(_font, Text, new Vector2(x,y), PenColor, 0f, new Vector2(0,0), 1f, SpriteEffects.None, Layer + +0.01f);
            }
        }
    }
}