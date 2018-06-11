using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Brendaim.Menus
{
    public class Menu
    {
        public enum HorizontalPosition { LEFT, CENTER, RIGHT };
        public enum VerticalPosition { TOP, CENTER, BOTTOM}

        public Boolean Visible { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        // Initialize a blank menu
        public Menu()
        {

        }

        public void Update(GameTime gameTime)
        {

        }

        public void Draw(SpriteBatch spriteBatch)
        {

        }

    }
}


