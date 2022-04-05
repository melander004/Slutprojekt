using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using SpriteClass.Sprites;
using SpriteClass.Models;

namespace SpriteClass.Sprites
{
    public class Palpatine : Sprite, ICollidable
    {
        public int Health { get; set; }

        public float Speed { get; set; }

        public int Score;

        public bool isDead
        {
            get
            {
                return Health <= 0;
            }
        }
       
        
        
        public Palpatine(Texture2D texture)
            : base(texture)
        {
            Speed = 5f;
        }

        public override void Update(GameTime gameTime, List<Sprite> sprites)
        {
            Move();

            if (isDead)
                return;

            foreach (var sprite in sprites)
            {
                if (sprite is Palpatine)
                    continue;
                
                if (sprite.Rectangle.Intersects(this.Rectangle))
                {
                    Speed++;
                    sprite.IsRemoved = true;
                }
            }
        }

        public virtual void OnCollide(Sprite sprite)
        {
            throw new NotImplementedException();
        }

        private void Move()
        {
           
        }
    }
}