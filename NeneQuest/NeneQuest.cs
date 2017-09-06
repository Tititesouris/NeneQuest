using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace NeneQuest
{
    public class NeneQuest : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        Texture2D texture;
        Vector2 position;
        Rectangle drawRec;
        float alpha = 1.0f;
        float rotation = 0.0f;
        Vector2 origin = new Vector2(0, 0);
        float scale = 1.0f;
        SpriteEffects spriteEffect = SpriteEffects.None;
        float zDepth = 0.1f;

        public NeneQuest()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            texture = Content.Load<Texture2D>(@"monogamelogo46px");
            drawRec = new Rectangle(0, 0, texture.Width, texture.Height);
            position = new Vector2(0, 0);
        }

        protected override void UnloadContent()
        {
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back ==
                ButtonState.Pressed || Keyboard.GetState().IsKeyDown(
                    Keys.Escape))
                Exit();
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();
            spriteBatch.Draw(texture,
                position,
                drawRec,
                Color.White * alpha,
                rotation,
                origin,
                scale,
                spriteEffect,
                zDepth);
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}