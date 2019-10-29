using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TurtleApp
{
    /// <summary>
    /// Interaction logic for TurtleCanvas.xaml
    /// </summary>
    /// 

    public partial class TurtleCanvas : UserControl
    {
        public enum TurtlePos { TopLeft, TopCenter, TopRight, MiddleLeft, MiddleCenter, MiddleRight, BottomLeft, BottomCenter, BottomRight };
        Point turtlePos;
        TurtlePos turtleDefaultPos;
        double rotation;

        public TurtleCanvas()
        {
            InitializeComponent();           
            rotation = 0.0d;
            turtleDefaultPos = TurtlePos.BottomCenter;
        }

        public void Right(double angle)
        {
            rotation += angle;
            rotation %= 360;
        }

        public void Left(double angle)
        {
            rotation -= angle;
            if (rotation < 0)
            {
                rotation += 360;
            }
        }

        public void Forward(double length)
        {
            Line line = new Line();
            line.Stroke = Brushes.Black;

            line.X1 = turtlePos.X;
            line.Y1 = turtlePos.Y;

            line.X2 = turtlePos.X + Math.Cos((rotation * 2 * Math.PI) / 360) * length;
            line.Y2 = turtlePos.Y + Math.Sin((rotation * 2 * Math.PI) / 360) * length;

            line.StrokeThickness = 2;
            Canvas.Children.Add(line);
            turtlePos.X += Math.Cos((rotation * 2 * Math.PI) / 360) * length;
            turtlePos.Y += Math.Sin((rotation * 2 * Math.PI) / 360) * length;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            PosTurtle(turtleDefaultPos);
        }

        public void ClearCanvas()
        {
            for (int i = Canvas.Children.Count - 1; i >= 0; i--)
            {
                UIElement child = Canvas.Children[i];
                Canvas.Children.Remove(child);
            }

            PosTurtle(turtleDefaultPos);
            rotation = 0;
        }

        private void Canvas_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            PosTurtle(turtleDefaultPos);
        }

        public void PosTurtle(TurtlePos newPos)
        {
            switch (newPos)
            {
                //BOTTOM PART OF CANVAS
                case TurtlePos.BottomLeft:
                    turtlePos = new Point(0, Canvas.ActualHeight);
                    break;

                case TurtlePos.BottomCenter:
                    turtlePos = new Point(Canvas.ActualWidth / 2, Canvas.ActualHeight);
                    break;

                case TurtlePos.BottomRight:
                    turtlePos = new Point(Canvas.ActualWidth, Canvas.ActualHeight);
                    break;

                //MIDDLE PART OF CANVAS
                case TurtlePos.MiddleLeft:
                    turtlePos = new Point(0, Canvas.ActualHeight/2);
                    break;

                case TurtlePos.MiddleCenter:
                    turtlePos = new Point(Canvas.ActualWidth / 2, Canvas.ActualHeight / 2);
                    break;

                case TurtlePos.MiddleRight:
                    turtlePos = new Point(Canvas.ActualWidth / 2, Canvas.ActualHeight / 2);
                    break;

                //TOP PART OF CANVAS
                case TurtlePos.TopLeft:
                    turtlePos = new Point(0, 0);
                    break;

                case TurtlePos.TopCenter:
                    turtlePos = new Point(Canvas.ActualWidth / 2, 0);
                    break;

                case TurtlePos.TopRight:
                    turtlePos = new Point(Canvas.ActualWidth, 0);
                    break;
            }

            turtleDefaultPos = newPos;
        }
    }
}
