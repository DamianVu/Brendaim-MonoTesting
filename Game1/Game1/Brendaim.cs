using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Brendaim
{
    // Test
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Brendaim : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Player player;

        KeyboardState currentKeyboardState;
        KeyboardState previousKeyboardState;
           //Nice friendly comment :)
        MouseState currentMouseState;
        MouseState previousMouseState;

        public Brendaim()
        {
            //Hello World!
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }


        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            Vector2 playerPosition = new Vector2(GraphicsDevice.Viewport.TitleSafeArea.X, GraphicsDevice.Viewport.TitleSafeArea.Y + GraphicsDevice.Viewport.TitleSafeArea.Height / 2);
            player = new Player(Content.Load<Texture2D>("Sprites/bob"), playerPosition, 100);
            base.Initialize();
        }




        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);


        }
        
        protected override void UnloadContent()
        {

        }


        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            previousKeyboardState = currentKeyboardState;
            previousMouseState = currentMouseState;

            currentKeyboardState = Keyboard.GetState();
            currentMouseState = Mouse.GetState();


            playerUpdate(gameTime);


            base.Update(gameTime);
        }

        private void playerUpdate(GameTime gameTime)
        {
            if (currentKeyboardState.IsKeyDown(Keys.A) || currentKeyboardState.IsKeyDown(Keys.Left))
            {
                player.Position.X -= player.Speed;
                player.FacingRight = false;
            }
            if (currentKeyboardState.IsKeyDown(Keys.D) || currentKeyboardState.IsKeyDown(Keys.Right))
            {
                player.Position.X += player.Speed;
                player.FacingRight = true;
            }
            if (currentKeyboardState.IsKeyDown(Keys.W) || currentKeyboardState.IsKeyDown(Keys.Up))
                player.Position.Y -= player.Speed;
            if (currentKeyboardState.IsKeyDown(Keys.S) || currentKeyboardState.IsKeyDown(Keys.Down))
                player.Position.Y += player.Speed;


        }
        
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);



            spriteBatch.Begin();

            player.Draw(spriteBatch);

            spriteBatch.End();



            base.Draw(gameTime);
        }
    }
}
