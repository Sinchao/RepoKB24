using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Concept_1
{
    class Crosshair
    {
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
                return ((float)Math.PI) * _angle / 180.0f;
            }
        } // in radians

        public Vector2 Draaipunt { get; set; }

        public Crosshair()
        {
            Draaipunt = new Vector2(7, 7);
        }

        public void Update(GameTime gameTime)
        {

            //Position += new Vector2(X, Y);
            //Position += new Vector2(speed * (float)Math.Cos(Angle), speed * (float)Math.Sin(Angle));

           

            if (speed > 0)
            {
                speed -= .05f;
            }
            if (speed < 0)
            {
                speed += .05f;
            }

            int resX = mX - X;
            Console.WriteLine(resX);
            int resY = mY - Y;

            Position = new Vector2(X, Y);


            return;
        }

        public void RotateLeft()
        {
            _angle -= 1;
        }

        public void RotateRight()
        {
            _angle += 1;
        }

        public void GoUp()
        {
            Y -= 2;
        }

        public void GoDown()
        {

            Y += 2;
        }

        public void GoLeft()
        {
            X -= 2;
        }

        public void GoRight()
        {
            X += 2;
        }

    }

}
