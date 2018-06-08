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
        public Vector2 Velocity;
        public Vector2 Acceleration;
        public float Speed { get; set; }
        public enum PlayerState { MOVING, JUMPING, FALLING };

        public int State;

        public bool FacingRight;

        public Player(Texture2D texture, Vector2 position, int hp)
        {
            PlayerTexture = texture;
            Position = position;
            Velocity = new Vector2(0, 0);
            Acceleration = new Vector2(0, 0);
            Health = hp;
            Speed = 8f;
            FacingRight = true;
            State = (int)PlayerState.MOVING;
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
