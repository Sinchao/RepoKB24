using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Concept_1
{
    class Player
    {
        public int steps = 3;
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
        

        public Player()
        {
            
            Draaipunt = new Vector2(22, 17);
        }

        public void Update(GameTime gameTime)
        {

            


            //Position += new Vector2(speed * (float)Math.Cos(Angle), speed * (float)Math.Sin(Angle));
                                 
            if (X > 750)
            {
                X = 750;
            }
            if (X < 0)
            {
                X = 0;
                speed = 0;
            }
            if (Y > 400)
            {
                Y = 400;
                speed = 0;
            }

            

            
                double resX = mX - X;
                double resY = mY - Y;

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

        public void Fire()
        {
            
        }

        public void RotateLeft()
        {
            _angle -=1;
        }

        public void RotateRight()
        {
            _angle += 1;
        }

        public void GoUp()
        {
            Y -= steps;
        }

        public void GoDown()
        {

            Y += steps;
        }

        public void GoLeft()
        {
            X -= steps;
        }

        public void GoRight()
        {
            X += steps;
        }

        
    }
    
}
