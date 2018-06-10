using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace Brendaim
{
    public class Player
    {
        //Friendly! :)
        public Texture2D PlayerTexture { get; set; }
        public int Health { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Vector2 Position;
        public float Speed { get; set; }

        public int State;

        public bool FacingRight;

        public Player(Texture2D texture, Vector2 position, int hp)
        {
            PlayerTexture = texture;
            Position = position;
            Health = hp;
            Speed = 8f;
            FacingRight = true;
        }

        public void Update()
        {

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (FacingRight)
            {
                spriteBatch.Draw(PlayerTexture, Position, null, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);
            }
            else
            {
                spriteBatch.Draw(PlayerTexture, Position, null, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.FlipHorizontally, 0f);
            }
        }
    }
}
