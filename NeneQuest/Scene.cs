using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace NeneQuest
{
    public interface Scene
    {
        void Initialize();

        void LoadContent();

        void UnloadContent();

        void Update(GameTime gameTime);

        void Draw(GameTime gameTime, GraphicsDeviceManager graphics, SpriteBatch spriteBatch);
    }
}