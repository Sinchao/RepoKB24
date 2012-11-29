using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Concept_1.Model
{
    public class ShotManager
    {
        private Texture2D texture;
        private List<Shot> playerShots = new List<Shot>();//Track shots. shots di buiten de viewport vallen moeten we van de lijst halen en dus niet meer tekenen. Dit is nog NIET geimplementeerd

        public ShotManager(Texture2D texture)
        {
            // TODO: Complete member initialization
            this.texture = texture;
        }

        public void FirePlayerShot(Vector2 shotPosition)
        {
            var shot = new Shot(texture, shotPosition);
            shot.Velocity = new Vector2(0, 1); //Richting.  Later aanpassen om in de juist richting te schieten. Misschien als paramter ontvangen van de player?
            playerShots.Add(shot);
        }

        internal void Update(GameTime gameTime)
        {
            foreach (var shot in playerShots)
            {
                shot.Update(gameTime);
            }
        }


        internal void Draw(SpriteBatch spriteBatch)
        {
            foreach (var shot in playerShots)
            {
                shot.Draw(spriteBatch);
            }
        }
    }
}
