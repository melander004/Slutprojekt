using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

namespace Slutprojekt
{
    class Floor
    {
        Texture2D texture;
        Vector2 position;
        Rectangle hitbox;

        int Length = 100;



        public void Initialize(ContentManager Content)
        {
            texture = Content.Load<Texture2D>("Naboo_hangar2");
            position = new Vector2(0, 430);
            hitbox = new Rectangle(0, 430, 50, 50);
        }
        public void Draw(SpriteBatch spriteBatch){
            for (int i = 0; i<Length; i++){
                spriteBatch.Draw(texture, new Vector2((int)position.X + (i*texture.Width), (int)position.Y), Color.White);
                spriteBatch.Draw(texture, hitbox((int)position.X, (int)position.Y, 50, 50));
            }
        }
    }
}