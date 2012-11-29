using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Concept_1.Model
{
    public class Shot
    {
        public Vector2 Position { get; set; }
        public Color Color { get; set; }
        public Texture2D texture { get; set; }
        public Vector2 Velocity { get; set; }
        public float Speed { get; set; }

        public Shot(Texture2D texture, Vector2 shotPosition)
        {
            // TODO: Complete member initialization
            this.texture = texture;
            this.Position = shotPosition;
            Speed = 20;
        }


        internal void Update(GameTime gameTime)
        {
            Position += Velocity * Speed;
        }

        internal void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, Position, Color.White);
        }
    }
}
