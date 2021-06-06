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
	public class GroupShape : Shape
	{
		#region Constructor
		[JsonConstructor]
		public GroupShape(RectangleF rect) : base(rect)
		{
			
		}

		public GroupShape(RectangleShape rectangle) : base(rectangle)
		{
		}

		#endregion

		public List<Shape> SubShape = new List<Shape>();

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
            //    Проверка дали е в обекта само, ако точката е в обхващащия правоъгълник.
            //     В случая на правоъгълник -директно връщаме true
            //    return true;
            //else
            //    Ако не е в обхващащия правоъгълник, то неможе да е в обекта и => false
            //    return false;

            if ((point.X >= this.Rectangle.X && point.X <= this.Rectangle.X + Width)  
				&& (point.Y >= this.Rectangle.Y && point.Y <= this.Rectangle.Y + Height))
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
			// base.DrawSelf(grfx);

			foreach (var item in SubShape)
			{
			//item.BorderColor = Color.Yellow;
			item.DrawSelf(grfx);
			//grfx.FillRectangle(new SolidBrush(FillColor), item.Rectangle.X, item.Rectangle.Y, item.Rectangle.Width, item.Rectangle.Height);
			//grfx.DrawRectangle(new Pen(BorderColor, BorderSize), item.Rectangle.X, item.Rectangle.Y, item.Rectangle.Width, item.Rectangle.Height);
			}
			//grfx.FillRectangle(new SolidBrush(FillColor), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
			var pen = new Pen(BorderColor, BorderSize);
			pen.DashPattern = new float[2] {4, 2};
			grfx.DrawRectangle(pen, Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
		}
	}
}
