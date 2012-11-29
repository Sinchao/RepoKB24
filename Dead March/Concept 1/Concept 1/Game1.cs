using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Concept_1.Creatures;

namespace Concept_1
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        Zombie Joe1;
        Crosshair Crosshair1;
        Player Player1;

        Rectangle overlap;
        

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            Player1 = new Player();

            Player1.Position = new Vector2(200, 200);
            Player1.Color = Color.White;

            Joe1 = new Zombie(Player1);

            Joe1.Position = new Vector2(200, 200);
            Joe1.Color = Color.White;
            Joe1.Type = "Joe";

            Crosshair1 = new Crosshair();

            Crosshair1.Position = new Vector2(400,400);
            Crosshair1.Color = Color.White;

            

            


            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            Player1.texture = Content.Load<Texture2D>("infantry");
            Crosshair1.texture = Content.Load<Texture2D>("Cursor_Crosshair");
            Joe1.texture = Content.Load<Texture2D>(Joe1.Type);
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            checkKeys();
            getCursor();
            checkCollisions();

            // TODO: Add your update logic here

            Player1.Update(gameTime);
            Crosshair1.Update(gameTime);
            Joe1.Update(gameTime);

            base.Update(gameTime);
        }

        
        

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            

            // TODO: Add your drawing code here
            spriteBatch.Begin();
            spriteBatch.Draw(Player1.texture, Player1.Position, new Rectangle(0, 0, 45, 34), Player1.Color,
                Player1.Angle,
                Player1.Draaipunt,
                1, SpriteEffects.None, 1);

            spriteBatch.Draw(Crosshair1.texture, Crosshair1.Position, new Rectangle(0, 0, 16, 16), Crosshair1.Color,
                Crosshair1.Angle,
                Crosshair1.Draaipunt,
                1, SpriteEffects.None, 1);

            spriteBatch.Draw(Joe1.texture, Joe1.Position, new Rectangle(0, 0, 39, 40), Joe1.Color,
                Joe1.Angle,
                Joe1.Draaipunt,
                1, SpriteEffects.None, 1);



            spriteBatch.End();

            base.Draw(gameTime);
        }

        private Boolean checkKeys()
        {
            KeyboardState state = Keyboard.GetState();

            if (!state.IsKeyDown(Keys.B))
                Joe1.GoFaster();


            if (!state.IsKeyDown(Keys.LeftShift))
            {
                Player1.Walk();
            }
            if (state.IsKeyDown(Keys.LeftShift))
            {
                Player1.Sprint();
            }
            if (state.IsKeyDown(Keys.S))
            {
                Player1.GoDown();
            }
            if (state.IsKeyDown(Keys.W))
            {
                Player1.GoUp();
            }

            if (state.IsKeyDown(Keys.A))
            {
                Player1.GoLeft();
            }
            if (state.IsKeyDown(Keys.D))
            {
                Player1.GoRight();
            }

            return false;
        }

        private void getCursor()
        {
            
            MouseState mS = Mouse.GetState();
            Player1.mX = mS.X;
            Player1.mY = mS.Y;
            
            Crosshair1.X = mS.X;
            Crosshair1.Y = mS.Y;

            if (mS.LeftButton == ButtonState.Pressed)
            {
                Player1.Fire();
            }
        }

        private void checkCollisions()
        {
            overlap = new Rectangle();
        }

    }
}
