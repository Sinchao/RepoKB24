using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Concept_1
{
    class Bullet
    {
        public double damage { get; set;}
        public int mX { get; set; }
        public int mY { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public Vector2 Position { get; set; }
        public Color Color { get; set; }
        public Texture2D texture { get; set; }
        private float speed;
        private float _angle;
        public float Angle
        {
            get
            {
                return _angle;
                //return ((float)Math.PI) * _angle / 180;
            }
        } // in radians

        public Vector2 Draaipunt { get; set; }

        public Bullet()
        {
            damage = 0;
            Draaipunt = new Vector2(2, 4);
        }

        public void Update(GameTime gameTime)
        {

            
                                    

            return;
        }

        public void Fire()
        {
            speed = 3f;
        }

        
    }
}
