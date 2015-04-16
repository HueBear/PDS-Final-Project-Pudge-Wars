using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace PudgeWarsXNA
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        GraphicsDevice device;
        SpriteBatch spriteBatch;
        Model pudgeModel;

        //this matrix creates the model at the origin and allows for movement, this allows the image to move later
        Matrix world; 
        //sets the camera on creation
        Matrix view;
        //projection onto the screen
        Matrix projection; 

        MouseState oldState;
        Pudge pudge, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12;
        Pudge[] Pudges = new Pudge[12];

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base. Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            graphics.IsFullScreen = false;

            world = Matrix.Identity;
            view = Matrix.CreateLookAt(new Vector3(0, 0, 100), new Vector3(0, 0, 0), Vector3.Up);
            projection = Matrix.CreateOrthographic(GraphicsDevice.Viewport.Width, GraphicsDevice.Viewport.Height, 0, 100f);
            graphics.ApplyChanges();
            
            // TODO: Add your initialization logic here
            IsMouseVisible = true;
            Window.Title = "Darude Astley - SandRoll";
            for(int i = 0; i < 11; i++)
            {
                pudge = new Pudge(i);
                Pudges[i] = pudge;
                System.Diagnostics.Debug.WriteLine(pudge);
            }
            p2 = new Pudge(2);
            System.Diagnostics.Debug.WriteLine("initialization complete");
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
            device = graphics.GraphicsDevice;

            // TODO: use this.Content to load your game content here
            pudgeModel = Content.Load<Model>("Models\\BeachBall");

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
            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
                this.Exit();

            pudge.Update(gameTime);
            p2.Update(gameTime);

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            device.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here   
            //DrawModel(pudgeModel, world, view, projection);
            foreach(Pudge p in Pudges)
            {
                pudge.Draw(pudgeModel, world, view, projection);
                p2.Draw(pudgeModel, world * Matrix.CreateTranslation(100, 100, 0), view, projection);
            }

            base.Draw(gameTime);
        }

        public void DrawModel(Model model, Matrix world, Matrix view, Matrix projection)
        {
            foreach(ModelMesh mesh in model.Meshes)
            {
                foreach(BasicEffect effect in mesh.Effects)
                {
                    effect.World = world;
                    effect.View = view;
                    effect.Projection = projection;
                }
                mesh.Draw();
            }
        }
    }
}
