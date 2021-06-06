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
	public class EllipseShape : Shape
    {
		#region Constructor

		[JsonConstructor]
		public EllipseShape(RectangleF rect) : base(rect)
		{
		}

		public EllipseShape(RectangleShape rectangle) : base(rectangle)
		{
		}

		#endregion

		/// <summary>
		/// Проверка за принадлежност на точка point към правоъгълника.
		/// В случая на правоъгълник този метод може да не бъде пренаписван, защото
		/// Реализацията съвпада с тази на абстрактния клас Shape, който проверява
		/// дали точката е в обхващащия правоъгълник на елемента (а той съвпада с
		/// елемента в този случай).
		/// </summary>
		public override bool Contains(PointF point)
		{
			//if (base.Contains(point))
			//	// Проверка дали е в обекта само, ако точката е в обхващащия правоъгълник.
			//	// В случая на правоъгълник - директно връщаме true
			//	return true;
			//else
			//	// Ако не е в обхващащия правоъгълник, то неможе да е в обекта и => false
			//	return false;

			float h = Rectangle.X + Width/2;
			float k = Rectangle.Y + Height/2;

			float a = Width/2;
			float b = Height/2;

			float x = point.X;
			float y = point.Y;

            if ((Math.Pow((x - h), 2) / Math.Pow(a, 2)) + (Math.Pow((y - k), 2) / Math.Pow(b, 2)) <= 1 )
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


			grfx.FillEllipse(new SolidBrush(FillColor), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
			grfx.DrawEllipse(new Pen(BorderColor, BorderSize), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
			
		}
	}
}
