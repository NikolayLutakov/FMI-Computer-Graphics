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
	public class TriangleShape : Shape
    {
		#region Constructor
		[JsonConstructor]
		public TriangleShape(RectangleF rect) : base(rect)
		{
		}

		public TriangleShape(RectangleShape rectangle) : base(rectangle)
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

			float x1 = Rectangle.X;
			float y1 = Rectangle.Y;

			float x2 = Rectangle.X;
			float y2 = Rectangle.Y + Width;

			float x3 = Rectangle.X + Height;
			float y3 = Rectangle.Y;

			float p1 = point.X;
			float p2 = point.Y;

			double A = area(x1, y1, x2, y2, x3, y3);

			/* Calculate area of triangle PBC */
			double A1 = area(p1, p2, x2, y2, x3, y3);

			/* Calculate area of triangle PAC */
			double A2 = area(x1, y1, p1, p2, x3, y3);

			/* Calculate area of triangle PAB */
			double A3 = area(x1, y1, x2, y2, p1, p2);

			/* Check if sum of A1, A2 and A3 is same as A */
			if (A == A1 + A2 + A3)
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
		/// 
		public override void DrawSelf(Graphics grfx)
		{
			base.DrawSelf(grfx);

			

			PointF point1 = new PointF(Rectangle.X, Rectangle.Y);
			PointF point2 = new PointF(Rectangle.X + Width, Rectangle.Y);
			PointF point3 = new PointF(Rectangle.X , Rectangle.Y + Height);

			PointF[] points = { point1, point2, point3 };

			grfx.FillPolygon(new SolidBrush(FillColor), points);
			grfx.DrawPolygon(new Pen(BorderColor, BorderSize), points);

		}

		
		static double area(float x1, float y1, float x2,
					   float y2, float x3, float y3)
		{
			return Math.Abs((x1 * (y2 - y3) +
							 x2 * (y3 - y1) +
							 x3 * (y1 - y2)) / 2.0);
		}
	}
}
