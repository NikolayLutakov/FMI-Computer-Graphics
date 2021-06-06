using Draw.src.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;

namespace Draw
{
    /// <summary>
    /// Класът, който ще бъде използван при управляване на диалога.
    /// </summary>
    public class DialogProcessor : DisplayProcessor
    {
        #region Constructor

        public DialogProcessor()
        {
        }

        #endregion

        #region Properties

        /// <summary>
        /// Избран елемент.
        /// </summary>
        private List<Shape> selection = new List<Shape>();
        public List<Shape> Selection
        {
            get { return selection; }
            set { selection = value; }
        }

        /// <summary>
        /// Дали в момента диалога е в състояние на "влачене" на избрания елемент.
        /// </summary>
        private bool isDragging;
        public bool IsDragging
        {
            get { return isDragging; }
            set { isDragging = value; }
        }

        /// <summary>
        /// Последна позиция на мишката при "влачене".
        /// Използва се за определяне на вектора на транслация.
        /// </summary>
        private PointF lastLocation;
        public PointF LastLocation
        {
            get { return lastLocation; }
            set { lastLocation = value; }
        }

        #endregion

        /// <summary>
        /// Добавя примитив - правоъгълник на произволно място върху клиентската област.
        /// </summary>
        public void AddRandomRectangle()
        {
            Random rnd = new Random();
            int x = rnd.Next(50, 1000);
            int y = rnd.Next(50, 400);

            RectangleShape rect = new RectangleShape(new Rectangle(x, y, 100, 200));
            rect.FillColor = Color.GhostWhite;
            rect.BorderColor = Color.Black;
            

            ShapeList.Add(rect);
        }

        public GroupShape AddGroupShape(PointF mostUpLeft, int width, int heiht, List<Shape>items)
        {
            GroupShape group = new GroupShape(new Rectangle((int)mostUpLeft.X, (int)mostUpLeft.Y, width, heiht));

            group.SubShape.AddRange(items);
            group.FillColor = Color.GhostWhite;
            group.BorderColor = Color.Black;

            ShapeList.Add(group);

            foreach (var item in items)
            {
                ShapeList.Remove(item);
            }
            return group;
        }

        public void RemoveShape(Shape shape)
        {
            ShapeList.Remove(shape);      
        }

        public void AddRandomEllipse()
        {
            Random rnd = new Random();
            int x = rnd.Next(50, 1000);
            int y = rnd.Next(50, 400);

            EllipseShape ellipse = new EllipseShape(new Rectangle(x, y, 100, 200));
            ellipse.FillColor = Color.GhostWhite;
            ellipse.BorderColor = Color.Black;

            ShapeList.Add(ellipse);
        }

        public void AddRandomTriangle()
        {
            Random rnd = new Random();
            int x = rnd.Next(50, 1000);
            int y = rnd.Next(50, 400);

            TriangleShape triangle = new TriangleShape(new Rectangle(x, y, 100, 200));
            triangle.FillColor = Color.GhostWhite;
            triangle.BorderColor = Color.Black;

            ShapeList.Add(triangle);
        }

        public void AddRandomCircle()
        {
            Random rnd = new Random();
            int x = rnd.Next(50, 1000);
            int y = rnd.Next(50, 400);

            CircleShape circle = new CircleShape(new Rectangle(x, y, 200, 200));
            circle.FillColor = Color.GhostWhite;
            circle.BorderColor = Color.Black;

            ShapeList.Add(circle);
        }
        /// <summary>
        /// Проверява дали дадена точка е в елемента.
        /// Обхожда в ред обратен на визуализацията с цел намиране на
        /// "най-горния" елемент т.е. този който виждаме под мишката.
        /// </summary>
        /// <param name="point">Указана точка</param>
        /// <returns>Елемента на изображението, на който принадлежи дадената точка.</returns>
        public Shape ContainsPoint(PointF point)
        {
            for (int i = ShapeList.Count - 1; i >= 0; i--)
            {
                if (ShapeList[i].Contains(point))
                {

                    if (ShapeList[i].FillColor == Color.GhostWhite)
                    {
                        ShapeList[i].FillColor = Color.DarkGray;
                    }
                    //else
                    //{
                        //var col = ShapeList[i].FillColor.ToArgb() - 1;
                        ////var color = new Color();
                        //var color = Color.FromArgb(col);
                        //ShapeList[i].FillColor = color;
                    //}

                    return ShapeList[i];
                }
            }
            return null;
        }

        /// <summary>
        /// Транслация на избраният елемент на вектор определен от <paramref name="p>p</paramref>
        /// </summary>
        /// <param name="p">Вектор на транслация.</param>
        public void TranslateTo(PointF p)
        {
           
                foreach (var item in Selection)
                {
                    item.Location = new PointF(item.Location.X + p.X - lastLocation.X, item.Location.Y + p.Y - lastLocation.Y);
                    
                }

            lastLocation = p;

        }

        public void Save()
        {
            
            Newtonsoft.Json.JsonSerializer serializer = new Newtonsoft.Json.JsonSerializer();
            serializer.TypeNameHandling = Newtonsoft.Json.TypeNameHandling.Auto;
            serializer.Formatting = Newtonsoft.Json.Formatting.Indented;
            StringBuilder output = new StringBuilder();

            using (StringWriter writer = new StringWriter(output))
            {
                serializer.Serialize(writer, ShapeList);

                File.WriteAllText("../../Export.json", output.ToString());
            }
                

            
                
        }
        public void Load()
        {

            if (File.Exists("../../Export.json"))
            {
                var str = File.ReadAllText("../../Export.json");


                var list = JsonConvert.DeserializeObject<List<Shape>>(str, 
                    new Newtonsoft.Json.JsonSerializerSettings
                    {
                        TypeNameHandling = Newtonsoft.Json.TypeNameHandling.Auto,
                        NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                    });
                ShapeList = list;
            }
            
            

        }

        
    }
}
