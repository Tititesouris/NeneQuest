using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace NeneQuest
{
    public class Menu : Scene
    {
        Texture2D texture;
        Vector2 position;
        Rectangle drawRec;
        float alpha = 1.0f;
        float rotation = 0.0f;
        Vector2 origin = new Vector2(0, 0);
        float scale = 1.0f;
        SpriteEffects spriteEffect = SpriteEffects.None;
        float zDepth = 0.1f;

        public Menu()
        {
        }

        public void Initialize()
        {
        }

        public void LoadContent()
        {
            texture = Content.Load<Texture2D>(@"monogamelogo46px");
            drawRec = new Rectangle(0, 0, texture.Width, texture.Height);
            position = new Vector2(0, 0);
        }

        public void UnloadContent()
        {
        }

        public void Update(GameTime gameTime)
        {
        }

        public void Draw(GameTime gameTime, GraphicsDeviceManager graphics, SpriteBatch spriteBatch)
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
        }
    }
}