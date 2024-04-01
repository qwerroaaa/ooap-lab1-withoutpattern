using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ooap_lab1_withoutpattern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Rectangle GetRectangle(Point p1, Point p2)
        {
            return new Rectangle(
                Math.Min(p1.X, p2.X),
                Math.Min(p1.Y, p2.Y),
                Math.Abs(p1.X - p2.X),
                Math.Abs(p1.Y - p2.Y)
            );
        }

        private Point[] GetTriangle(Point p1, Point p2)
        {
            // Рассчитываем координаты треугольника по двум точкам
            Point[] points = new Point[3];
            points[0] = p1;
            points[1] = new Point(p2.X, p1.Y);
            points[2] = new Point((p1.X + p2.X) / 2, p2.Y);
            return points;
        }

        // Перечисление для определения текущей выбранной фигуры
        private enum ShapeType { Rectangle, Triangle, Circle }

        private ShapeType currentShape = ShapeType.Rectangle; // По умолчанию выбран прямоугольник

        private Point startPoint; // Начальная точка для рисования фигуры
        private Point endPoint; // Конечная точка для рисования фигуры

        private void rectangleButton_Click(object sender, EventArgs e)
        {
            currentShape = ShapeType.Rectangle;
        }

        private void circleButton_Click(object sender, EventArgs e)
        {
            currentShape = ShapeType.Circle;
        }

        private void triangleButton_Click(object sender, EventArgs e)
        {
            currentShape = ShapeType.Triangle;
        }

        private void drawBoard_MouseUp(object sender, MouseEventArgs e)
        {
            endPoint = e.Location;

            // Создаем графику для рисования на PictureBox
            Graphics g = drawBoard.CreateGraphics();
            Pen pen = new Pen(Color.Black);

            switch (currentShape)
            {
                case ShapeType.Rectangle:
                    g.DrawRectangle(pen, GetRectangle(startPoint, endPoint));
                    break;
                case ShapeType.Triangle:
                    g.DrawPolygon(pen, GetTriangle(startPoint, endPoint));
                    break;
                case ShapeType.Circle:
                    g.DrawEllipse(pen, GetRectangle(startPoint, endPoint));
                    break;
            }

            // Освобождаем ресурсы
            pen.Dispose();
            g.Dispose();
        }

        private void drawBoard_MouseDown(object sender, MouseEventArgs e)
        {
            startPoint = e.Location;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            drawBoard.Image = new Bitmap(drawBoard.Width, drawBoard.Height);
        }
    }
}
