using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;

namespace _106_MonoGame_Basics
{
	class Button
	{
		public Texture2D ButtonImage { get; set; }
		public Texture2D HoverImage { get; set; }
		public Rectangle ButtonRectangle { get; set; }

		public Button(ContentManager manager, Rectangle r)
		{
			ButtonImage = manager.Load<Texture2D>("GeneralKenobi");
			HoverImage = manager.Load<Texture2D>("BoldOne");
			ButtonRectangle = r;
		}

		public void Draw(SpriteBatch spriteBatch)
		{
			MouseState mouse = Mouse.GetState();

			if(mouse.Position.X >= ButtonRectangle.X && mouse.Position.X <= ButtonRectangle.X + ButtonRectangle.Width &&
				mouse.Position.Y >= ButtonRectangle.Y && mouse.Position.Y <= ButtonRectangle.Y + ButtonRectangle.Height)
			{
				spriteBatch.Draw(HoverImage, ButtonRectangle, Color.White);
			}
			else
				spriteBatch.Draw(ButtonImage, ButtonRectangle, Color.White);

		}
	}
}
