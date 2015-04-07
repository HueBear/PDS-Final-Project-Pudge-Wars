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
        SpriteBatch spriteBatch;
        Model pudgeModel;

        //this matrix creates the model at the origin and allows for movement, this allows the image to move later
        Matrix world = Matrix.CreateTranslation(new Vector3(-500, 300, 0));

        //sets the camera on creation
        Matrix view = Matrix.CreateLookAt(new Vector3 (-500, 1368, 923), new Vector3(0, 0, 0), Vector3.Up);
        Matrix projection = Matrix.CreateOrthographic(2000, 2000, 0.1f, 5000);



        MouseState oldState;
        Pudge pudge;

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
            // TODO: Add your initialization logic here
            IsMouseVisible = true;
            for(int i = 0; i < 11; i++)
            {
                pudge = new Pudge(i);
                Pudges[i] = pudge;
            }
           

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

            //pudge movement
            if(oldState.RightButton == ButtonState.Released && Mouse.GetState().RightButton == ButtonState.Pressed)
            {
                pudge.makeMove(gameTime, Mouse.GetState().X, Mouse.GetState().Y, pudge.getSpeed());
            }
            oldState = Mouse.GetState();

            // TODO: Add your update logic here

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
            pudge.Draw(spriteBatch);
            spriteBatch.End();

            DrawModel(pudgeModel, world, view, projection);

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
