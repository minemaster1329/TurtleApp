using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DrawButon_Click(object sender, RoutedEventArgs e)
        {
            int iterCount = 0;
            double sideLenght = 0.0;

            if (!Int32.TryParse(IterCountTxtb.Text, out iterCount) || iterCount < 1)
            {
                MessageBox.Show("Invalid Input format. Iterations count must be in integer format and greater than 1.");
                return;
            }

            if (!Double.TryParse(SideLenghtTxtb.Text, out sideLenght) || sideLenght < 0)
            {
                MessageBox.Show("Invalid input format. Side lenght must be in double format and greater than 0.");
            }

            TurtleCanvas.ClearCanvas();

            switch (ChooseFunctionComboBox.SelectedIndex)
            {
                case 1:
                    TurtleCanvas.PosTurtle(TurtleCanvas.TurtlePos.MiddleCenter);
                    TaskA1(iterCount, sideLenght);
                    break;

                case 2:
                    TurtleCanvas.PosTurtle(TurtleCanvas.TurtlePos.MiddleCenter);
                    TaskA2(iterCount, sideLenght);
                    break;

                case 3:
                    TurtleCanvas.PosTurtle(TurtleCanvas.TurtlePos.MiddleCenter);
                    TaskA3(iterCount, sideLenght);
                    break;

                case 4:
                    TurtleCanvas.PosTurtle(TurtleCanvas.TurtlePos.MiddleCenter);
                    TaskA4(iterCount, sideLenght);
                    break;

                case 5:
                    TurtleCanvas.PosTurtle(TurtleCanvas.TurtlePos.MiddleCenter);
                    TaskA5(iterCount, sideLenght);
                    break;

                case 6:
                    TurtleCanvas.PosTurtle(TurtleCanvas.TurtlePos.MiddleCenter);
                    TaskA6(iterCount, sideLenght);
                    break;

                case 7:
                    TurtleCanvas.PosTurtle(TurtleCanvas.TurtlePos.MiddleCenter);
                    TaskA7(iterCount, sideLenght);
                    break;

                case 8:
                    TurtleCanvas.PosTurtle(TurtleCanvas.TurtlePos.MiddleCenter);
                    TaskA8(iterCount, sideLenght);
                    break;

                case 9:
                    TurtleCanvas.PosTurtle(TurtleCanvas.TurtlePos.MiddleCenter);
                    TaskA9(iterCount, sideLenght);
                    break;

                default:
                    MessageBox.Show("Please select function from list.");
                    break;
            }
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            TurtleCanvas.ClearCanvas();
        }

        private void SierpinskiTriangle(int iter, double sideLen)
        {
            if (iter == 0) return;
            for (int a = 0; a < 3; a++)
            {
                TurtleCanvas.Forward(sideLen);
                TurtleCanvas.Left(120);
                SierpinskiTriangle(iter - 1, sideLen / 2);
            }
        }

        private void TaskA1(int iter, double sideLen)
        {
            if (iter == 0) return;
            for (int a = 0; a < 4; a++)
            {
                TurtleCanvas.Forward(sideLen);
                TaskA1(iter - 1, sideLen / 2);
                TurtleCanvas.Right(90);
            }
        }

        private void TaskA2(int iter, double sideLen)
        {
            if (iter == 0) return;
            for (int a = 0; a < 3; a++)
            {
                TurtleCanvas.Forward(sideLen);
                TurtleCanvas.Right(120);
                TaskA2(iter - 1, sideLen / 2);
                TurtleCanvas.Right(120);
            }
        }

        private void TaskA3(int iter, double sideLen)
        {
            if (iter == 0) return;
            for (int a = 0; a < 4; a++)
            {
                TurtleCanvas.Forward(sideLen);
                TurtleCanvas.Right(90);
                TaskA3(iter - 1, sideLen / 2);
                TurtleCanvas.Left(180);
            }
        }

        private void TaskA4(int iter, double sideLen)
        {
            if (iter == 0) return;
            for (int a = 0; a < 3; a++)
            {
                TurtleCanvas.Forward(sideLen);
                TurtleCanvas.Right(60);
                TaskA4(iter - 1, sideLen / 2);
                TurtleCanvas.Left(180);
            }
        }

        private void TaskA5(int iter, double sideLen)
        {
            if (iter == 0) return;
            for (int a = 0; a < 3; a++)
            {
                TurtleCanvas.Forward(sideLen);
                TurtleCanvas.Left(180);
                TaskA5(iter - 1, sideLen / 2);
                TurtleCanvas.Right(60);
            }
        }

        private void TaskA6(int iter, double sideLen)
        {
            if (iter == 0) return;
            for (int a = 0; a < 4; a++)
            {
                TurtleCanvas.Forward(sideLen / 4);
                TurtleCanvas.Left(90);
                TaskA6(iter - 1, sideLen / 2);
                TurtleCanvas.Right(90);
                TurtleCanvas.Forward(3 * sideLen / 4);
                TurtleCanvas.Right(90);
            }
        }

        private void TaskA7(int iter, double sideLen)
        {
            if (iter == 0) return;
            for (int a = 0; a < 3; a++)
            {
                TurtleCanvas.Forward(sideLen / 4);
                TurtleCanvas.Left(60);
                TaskA7(iter - 1, sideLen / 2);
                TurtleCanvas.Right(60);
                TurtleCanvas.Forward(3 * sideLen / 4);
                TurtleCanvas.Right(120);
            }
        }

        private void TaskA8(int iter, double sideLen)
        {
            if (iter == 0) return;
            for (int a = 0; a < 6; a++)
            {
                TurtleCanvas.Forward(sideLen / 4);
                TurtleCanvas.Left(120);
                TaskA8(iter - 1, sideLen / 2);
                TurtleCanvas.Right(120);
                TurtleCanvas.Forward(3 * sideLen / 4);
                TurtleCanvas.Right(60);
            }
        }

        private void TaskA9(int iter, double sideLen)
        {
            if (iter == 0) return;
            TurtleCanvas.Right(90);
            TurtleCanvas.Forward(sideLen);
            TurtleCanvas.Left(180);
            TaskA9(iter - 1, sideLen + 10);
        }
    }
}
