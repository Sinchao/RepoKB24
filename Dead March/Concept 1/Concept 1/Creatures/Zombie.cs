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
            Target = player;
            Draaipunt = new Vector2(20, 20);
        }

        internal void Update(GameTime gameTime)
        {
            

            double resX = Target.X - X;
            double resY = Target.Y - Y;

            if (resY == 0)
                resY = 0.00001;

            if (resX == 0)
                resX = 0.00001;

            double res = resY / resX;
            double ang = Math.Atan(res);


            if (resX < 0)
                ang = (45 - ang) * -1;



            _angle = (float)ang;

            Position = new Vector2(X + speed, Y + speed);


            return;
        }

        public void GoFaster()
        {

            if (speed < 1)
            {
                speed += .1f;
            }
        }

        public void GoUp()
        {
            Y -= Speed;
        }

        public void GoDown()
        {

            Y += Speed;
        }

        public void GoLeft()
        {
            X -= Speed;
        }

        public void GoRight()
        {
            X += Speed;
        }
    }
}
