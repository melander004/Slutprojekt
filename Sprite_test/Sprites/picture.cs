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

    public class Picture : Sprite , Colidable 

    {
        
        public float _speed {get;set;}
        public bool Isdead
        {
            get{
                return health <=0;
            }
        }
        public Picture(Texture2D texture) : base(texture)
        {
            speed = 5f;
        }
        public override void Update(GameTime gameTime, List<Sprite> sprite)
        {
            if (Isdead)
            return;
            foreach(var Sprite in sprite)
            {
                if(Sprite is Picture){
                    continue;
                }
            }
        }
        public void Move()
            {
                _position = Vector2.Clamp(_position, new Vector2(0,0),new Vector2(Game1.ScreenWidth-this.Rectangle.Width, Game1.ScreenHeight-this.Rectangle.Height));
            }
        

        
    }

}