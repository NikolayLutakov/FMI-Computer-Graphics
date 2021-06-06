using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw.src.Model
{
	[JsonObject]
    class CircleShape : Shape
	{

		[JsonConstructor]
		public CircleShape(RectangleF rect) : base(rect)
		{
		}

		public CircleShape(RectangleShape rectangle) : base(rectangle)
		{
		}
		public override bool Contains(PointF point)
		{

	
			//if (base.Contains(point))
			//	// Проверка дали е в обекта само, ако точката е в обхващащия правоъгълник.
			//	// В случая на правоъгълник - директно връщаме true
			//	return true;
			//else
			//	// Ако не е в обхващащия правоъгълник, то неможе да е в обекта и => false
			//	return false;

			float h = Rectangle.X + Width / 2;
			float k = Rectangle.Y + Height / 2;

			float a = Width / 2;
			float b = Height / 2;

			float x = point.X;
			float y = point.Y;

			if ((Math.Pow((x - h), 2) / Math.Pow(a, 2)) + (Math.Pow((y - k), 2) / Math.Pow(b, 2)) <= 1)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// Частта, визуализираща конкретния примитив.
		/// </summary>
		public override void DrawSelf(Graphics grfx)
		{
			base.DrawSelf(grfx);

			var point1 = new PointF(this.Location.X, this.Location.Y + this.Height/2);
			var point2 = new PointF(this.Location.X + Width, this.Location.Y + this.Height / 4);

			var point3 = new PointF(this.Location.X, this.Location.Y + this.Height - (this.Height / 4));
			var point4 = new PointF(this.Location.X + Width, this.Location.Y + 2 * (this.Height / 4));

			grfx.FillEllipse(new SolidBrush(FillColor), Rectangle.X, Rectangle.Y, Rectangle.Height, Rectangle.Height);
			grfx.DrawEllipse(new Pen(BorderColor, BorderSize), Rectangle.X, Rectangle.Y, Rectangle.Height, Rectangle.Height);
			grfx.DrawLine(new Pen(BorderColor, BorderSize),point1, point2);

			grfx.DrawLine(new Pen(BorderColor, BorderSize), point3, point4);
		}
	}
	
}

