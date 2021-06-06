using Draw.src.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace Draw
{

    /// <summary>
    /// Върху главната форма е поставен потребителски контрол,
    /// в който се осъществява визуализацията
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Агрегирания диалогов процесор във формата улеснява манипулацията на модела.
        /// </summary>
        private DialogProcessor dialogProcessor = new DialogProcessor();
        //private int borderSizeSelected = 1;

        public MainForm()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();

            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
        }

        /// <summary>
        /// Изход от програмата. Затваря главната форма, а с това и програмата.
        /// </summary>
        void ExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Събитието, което се прихваща, за да се превизуализира при изменение на модела.
        /// </summary>
        void ViewPortPaint(object sender, PaintEventArgs e)
        {
            dialogProcessor.ReDraw(sender, e);
        }

        /// <summary>
        /// Бутон, който поставя на произволно място правоъгълник със зададените размери.
        /// Променя се лентата със състоянието и се инвалидира контрола, в който визуализираме.
        /// </summary>
        void DrawRectangleSpeedButtonClick(object sender, EventArgs e)
        {
            dialogProcessor.AddRandomRectangle();

            statusBar.Items[0].Text = "Последно действие: Рисуване на правоъгълник";

            viewPort.Invalidate();
        }

        /// <summary>
        /// Прихващане на координатите при натискането на бутон на мишката и проверка (в обратен ред) дали не е
        /// щракнато върху елемент. Ако е така то той се отбелязва като селектиран и започва процес на "влачене".
        /// Промяна на статуса и инвалидиране на контрола, в който визуализираме.
        /// Реализацията се диалогът с потребителя, при който се избира "най-горния" елемент от екрана.
        /// </summary>
        void ViewPortMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (pickUpSpeedButton.Checked)
            {
                Shape sel = dialogProcessor.ContainsPoint(e.Location);

                bool flag = true;
                //dialogProcessor.Selection = dialogProcessor.ContainsPoint(e.Location);

                if (sel != null)
                {

                    Color selCol = sel.FillColor;
                    if (dialogProcessor.Selection.Contains(sel))
                    {
                        dialogProcessor.Selection.Remove(sel);
                        flag = false;


                        //if (selCol == Color.DarkGray)
                        //{
                        //    sel.FillColor = Color.FromArgb(248, 248, 255);
                        //}
                        //else 
                        //{
                        //    sel.FillColor = Color.DarkGray;
                        //}


                        if (sel.GetType() == typeof(GroupShape))
                        {
                            GroupShape sh = (GroupShape)sel;
                            foreach (var item in sh.SubShape)
                            {
                                //if (item.FillColor == Color.DarkGray)
                                //{
                                //    item.FillColor = Color.FromArgb(248, 248, 255);
                                //}
                                dialogProcessor.Selection.Remove(item);
                            }
                        }

                    }
                    else
                    {

                        dialogProcessor.Selection.Add(sel);
                        if (sel.GetType() == typeof(GroupShape))
                        {
                            GroupShape sh = (GroupShape)sel;
                            foreach (var item in sh.SubShape)
                            {

                                //if (selCol == Color.FromArgb(248, 248, 255))
                                //{
                                //    item.FillColor = Color.DarkGray;
                                //}
                                //else
                                //{
                                //    item.FillColor = selCol;
                                //}

                                dialogProcessor.Selection.Add(item);
                            }
                        }
                    }
                }
                if (flag)
                {
                    statusBar.Items[0].Text = "Последно действие: Селекция на примитив";
                }
                else
                {
                    statusBar.Items[0].Text = "Последно действие: Деселекция на примитив";
                }



                dialogProcessor.IsDragging = true;
                dialogProcessor.LastLocation = e.Location;
                viewPort.Invalidate();
            }
        }

        /// <summary>
        /// Прихващане на преместването на мишката.
        /// Ако сме в режм на "влачене", то избрания елемент се транслира.
        /// </summary>
        void ViewPortMouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (dialogProcessor.IsDragging)
            {
                if (dialogProcessor.Selection != null) statusBar.Items[0].Text = "Последно действие: Влачене";
                dialogProcessor.TranslateTo(e.Location);
                viewPort.Invalidate();
            }
        }

        /// <summary>
        /// Прихващане на отпускането на бутона на мишката.
        /// Излизаме от режим "влачене".
        /// </summary>
        void ViewPortMouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            dialogProcessor.IsDragging = false;
        }

        private void DrawEllipseButton_Click(object sender, EventArgs e)
        {
            dialogProcessor.AddRandomEllipse();

            statusBar.Items[0].Text = "Последно действие: Рисуване на елипса";

            viewPort.Invalidate();
        }

        private void DrawTriangleButton_Click(object sender, EventArgs e)
        {
            dialogProcessor.AddRandomTriangle();

            statusBar.Items[0].Text = "Последно действие: Рисуване на триъгълник";

            viewPort.Invalidate();
        }

        private void borderColorStripButton_Click(object sender, EventArgs e)
        {
            if (borderColorDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (var item in dialogProcessor.Selection)
                {

                    if (dialogProcessor.Selection != null)
                    {
                        item.BorderColor = borderColorDialog.Color;
                        viewPort.Invalidate();
                    }

                }
            }
        }

        private void fillColor_Click(object sender, EventArgs e)
        {
            if (borderColorDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (var item in dialogProcessor.Selection)
                {
                    if (dialogProcessor.Selection != null)
                    {
                        item.FillColor = borderColorDialog.Color;
                        viewPort.Invalidate();

                    }
                }
            }
        }



        private void pickUpSpeedButton_Click(object sender, EventArgs e)
        {

        }

        private void rotateItem_Click(object sender, EventArgs e)
        {
            foreach (var item in dialogProcessor.Selection)
            {

                if (item.GetType() == typeof(GroupShape))
                {
                    continue;
                }
                else
                {
                    if (dialogProcessor.Selection != null)
                    {
                        var tmp = item.Height;
                        item.Height = item.Width;
                        item.Width = tmp;

                        viewPort.Invalidate();

                    }
                }
                
            }
        }


        private void incfreaseBorderSize(object sender, EventArgs e)
        {
            foreach (var item in dialogProcessor.Selection)
            {
                if (dialogProcessor.Selection != null)
                {
                    item.BorderSize += 1;


                    viewPort.Invalidate();

                }
            }
        }

        private void decreaseBorderSize_Click(object sender, EventArgs e)
        {

            

            foreach (var item in dialogProcessor.Selection)
            {
                if (dialogProcessor.Selection != null)
                {
                    if (item.BorderSize != 1)
                    {
                        item.BorderSize -= 1;
                    }

                    viewPort.Invalidate();

                }
            }
        }

        private void increaseShapeSizeButton_Click(object sender, EventArgs e)
        {
            foreach (var item in dialogProcessor.Selection)
            {
                if (dialogProcessor.Selection != null)
                {
                    item.Width += 10;
                    item.Height += 10;

                    viewPort.Invalidate();

                }
            }
        }

        private void decreaseShapeSize_Click(object sender, EventArgs e)
        {
            foreach (var item in dialogProcessor.Selection)
            {
                if (dialogProcessor.Selection != null)
                {
                    if (item.Width > 10 && item.Height > 10)
                    {
                        item.Width -= 10;
                        item.Height -= 10;

                        viewPort.Invalidate();
                    }


                }
            }
        }

        private void deleteSelectedButton_Click(object sender, EventArgs e)
        {
            foreach (var item in dialogProcessor.Selection)
            {
                if (dialogProcessor.Selection != null)
                {

                    dialogProcessor.RemoveShape(item);


                    viewPort.Invalidate();
                }
            }
            dialogProcessor.Selection.Clear();
        }

        private void groupShapesButton_Click(object sender, EventArgs e)
        {
            //calculate boundry box
            int mostLeftX = int.MaxValue;
            int mostRightX = int.MinValue;
            int mostDownY = int.MinValue;
            int mostUpY = int.MaxValue;

            if (dialogProcessor.Selection.Count > 0)
            {
                foreach (var item in dialogProcessor.Selection)
                {
                    if (item.Location.X < mostLeftX)
                    {
                        mostLeftX = (int)item.Location.X;
                    }

                    if (item.Location.X + item.Width > mostRightX)
                    {
                        mostRightX = (int)item.Location.X + (int)item.Width;

                    }

                    if (item.Location.Y + item.Height > mostDownY)
                    {

                        mostDownY = (int)item.Location.Y + (int)item.Height;

                    }

                    if (item.Location.Y < mostUpY)
                    {

                        mostUpY = (int)item.Location.Y;

                    }
                }



                var mostUpLeft = new PointF(mostLeftX, mostUpY);
                var width = mostRightX - mostLeftX;
                var mostDownRight = new PointF(mostRightX, mostDownY);
                var height = mostDownY - mostUpY;
                var items = dialogProcessor.Selection;
                //create new groupshape

                var group = dialogProcessor.AddGroupShape(mostUpLeft, width, height, items);
                //subshape add selection
                //foreach (var item in dialogProcessor.Selection)
                //{
                //    group.SubShape.Add(item);
                //}

                dialogProcessor.Selection.Add(group);

                
            }


            //foreach (var item in dialogProcessor.Selection)
            //{
            //    dialogProcessor.RemoveShape(item);
            //}



            viewPort.Invalidate();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            dialogProcessor.Save();
        }

        private void Load_Click(object sender, EventArgs e)
        {
            dialogProcessor.Load();
            viewPort.Invalidate();
        }

        private void addCircle_Click(object sender, EventArgs e)
        {
            dialogProcessor.AddRandomCircle();

            statusBar.Items[0].Text = "Последно действие: Рисуване на окръжност";

            viewPort.Invalidate();
        }
    }
}
