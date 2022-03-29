using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

namespace bduabdhabda
{
    class Floor
    {
        Texture2D texture;
        Vector2 position;

public void Initialize(ContentManager Content)
{
    texture = Content.Load<Texture2D>("Naboo_hangar2");
    position = new Vector2(0, 430);
}
        public void Draw(SpriteBatch spriteBatch){
            for (int i = 0; i<16; i++){
                spriteBatch.Draw(texture, new Vector2((int)position.X + (i*texture.Width), (int)position.Y), Color.White);
         }
     }   
    }
}