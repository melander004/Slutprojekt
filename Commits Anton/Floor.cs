using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;
using Slutprojekt.States;
using Slutprojekt;

namespace Slutprojekt
{
    class Floor
    {
        Texture2D texture_Naboo;
        Texture2D texture_Mustafar;

        Vector2 position;


        int Length = 100;

        public void Initialize(ContentManager Content)
        {
            texture_Mustafar = Content.Load<Texture2D>("Mustafar_Floor");
            texture_Naboo = Content.Load<Texture2D>("Naboo_hangar2 (1)");
            position = new Vector2(0, 430);

        }

        /*public void Draw(SpriteBatch spriteBatch){
            for (int i = 0; i<Length; i++){
                if(nabooknapp){
                    spriteBatch.Draw(texture_Naboo, new Vector2((int)position.X + (i*texture_Naboo.Width), (int)position.Y), Color.White);
                }
                
                if(Mustafarknapp){
                    spriteBatch.Draw(texture_Mustafar, new Vector2((int)position.X + (i*texture_Mustafar.Width), (int)position.Y), Color.White);
                }

            }
        }*/
    }
}