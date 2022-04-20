using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

namespace ännu_ett_nytt_slutprojekt
{
    class Floor
    {
        Texture2D texture;
        Vector2 position;
        Rectangle hitbox;

        int Length = 100;

        public void Initialize(ContentManager Content)
        {
            texture = Content.Load<Texture2D>("Naboo_hangar2 (1)");
            position = new Vector2(0, 430);
            hitbox = new Rectangle(0, 430, 50, 50);

        }
        public void Draw(SpriteBatch spriteBatch){
            for (int i = 0; i<Length; i++){
                spriteBatch.Draw(texture, new Vector2((int)position.X + (i*texture.Width), (int)position.Y), Color.White);
               // spriteBatch.Draw(hitbox, new Rectangle((int)hitbox.X + (i*hitbox.Width), (int)hitbox.Y + (i*hitbox.Height), 1));
                spriteBatch.Draw(texture, hitbox, Color.White);
            }
        }
    }
}