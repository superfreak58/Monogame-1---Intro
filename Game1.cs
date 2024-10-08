using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Monogame_1___Intro
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Texture2D dinoTexture, diddyTexture, oilTexture, bathroomTexture, rawrTexture;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _graphics.PreferredBackBufferWidth = 800;
            _graphics.PreferredBackBufferHeight = 600;
            _graphics.ApplyChanges();
            this.Window.Title = "skibiti";

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            bathroomTexture = Content.Load<Texture2D>("DIDDY HOUSE");
            dinoTexture = Content.Load<Texture2D>("dino");
            diddyTexture = Content.Load<Texture2D>("Diddy (2)");
            oilTexture = Content.Load<Texture2D>("oil up");
            rawrTexture = Content.Load<Texture2D>("rawrxd");
            
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.PeachPuff);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            _spriteBatch.Draw(bathroomTexture, new Vector2(0,0), Color.White);

            _spriteBatch.Draw(dinoTexture, new Vector2(10,10), Color.White);
            _spriteBatch.Draw(diddyTexture, new Vector2(150,175), Color.White);
            _spriteBatch.Draw(oilTexture, new Vector2(575, 250), Color.White);
            _spriteBatch.Draw(rawrTexture, new Vector2(250,-70), Color.White);



            _spriteBatch.End();


            base.Draw(gameTime);
        }
    }
}
