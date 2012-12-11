using System;
using System.Threading;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Concept_1.Model;

namespace Concept_1
{
    class Player
    {
        public Boolean visible { get; set; }
        public Boolean sprinting { get; set; }
        public int sprint { get; set; }
        public int steps { get; set; }
        public int mX { get; set; }
        public int mY { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public Vector2 Position { get; set; }
        public Color Color { get; set; }
        public Texture2D texture { get; set; }
        private float _angle;
        private ShotManager shotManager;
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
            
            sprint = 100;
            steps = 3;
            Draaipunt = new Vector2(18, 27);
        }

        public Player(ShotManager shotManager)
        {
            // TODO: Complete member initialization
            this.shotManager = shotManager;

            sprint = 100;
            steps = 3;
            Draaipunt = new Vector2(18, 27);
        }

        public void Update(GameTime gameTime)
        {

            

            if (sprint > 0 && sprinting == true)
            {
                steps = 5;
            }

            if (sprint == 0 || sprinting == false)
            {
                sprinting = false;
                steps = 3;

            }

            if (sprinting)
                sprint -= 10;

            if (!sprinting)
                sprint += 5;
            


            //Position += new Vector2(speed * (float)Math.Cos(Angle), speed * (float)Math.Sin(Angle));
                                 
            

            

            
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
            shotManager.FirePlayerShot(CalculateShotPosition());
        }

        private Vector2 CalculateShotPosition()
        {
            return Position; //Later fixen zodat de shot precies uit de gun komt.
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



        internal void Sprint()
        {
            sprinting = true;
        }

        internal void Walk()
        {
            sprinting = false;
        }
    }
    
}
