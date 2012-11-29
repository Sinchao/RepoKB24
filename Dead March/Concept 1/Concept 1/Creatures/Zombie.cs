using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Concept_1.Creatures
{
    class Zombie
    {
        public Player Target { get; set; }

        public string Type { get; set; }
        public int Health { get; set; }
        public int Speed = 1;
        public double AttSp { get; set; }
        public int AttDmg { get; set; }

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
                //return ((float)Math.PI) * _angle;
            }
        } // in radians

        public Vector2 Draaipunt { get; set; }

        public Zombie(Player player)
        {
            X = 400;
            Y = 400;
            Target = player;
            Draaipunt = new Vector2(20, 20);
        }

        internal void Update(GameTime gameTime)
        {
            double resX = Target.X - Position.X;
            double resY = Target.Y - Position.Y;

            if (resY == 0)
                resY = 0.00001;

            if (resX == 0)
                resX = 0.00001;

            double res = resY / resX;
            double ang = Math.Atan(res);


            if (resX < 0)
                ang = (135 - ang) * -1;



            _angle = (float)ang;

            Position = new Vector2(X, Y);

            

            return;
        }

        public void GoFaster()
        {

            if (speed < 1)
            {
                speed += .1f;
            }
        }

        
    }
}
