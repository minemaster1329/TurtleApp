using System;
using System.Windows;

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
            if (!Double.TryParse(IterCountTxtb.Text, out double minLenght) || minLenght < 1)
            {
                MessageBox.Show("Invalid Input format. Iterations count must be in integer format and greater than 1.");
                return;
            }

            if (!Double.TryParse(SideLenghtTxtb.Text, out double sideLenght) || sideLenght < 0)
            {
                MessageBox.Show("Invalid input format. Side lenght must be in double format and greater than 0.");
                return;
            }

            if (minLenght > sideLenght)
            {
                MessageBox.Show("Minimum lenght must be less or equal to side lenght");
                return;
            }

            TurtleCanvas.ClearCanvas();

            TurtleCanvas.SetTurtleOrientation(TurtleCanvas.TurtleOrientation.ToRight);
            switch (ChooseFunctionComboBox.SelectedIndex)
            {
                case 1:
                    TurtleCanvas.PosTurtle(TurtleCanvas.TurtlePos.MiddleCenter);
                    TaskA1(minLenght, sideLenght);
                    break;

                case 2:
                    TurtleCanvas.PosTurtle(TurtleCanvas.TurtlePos.MiddleCenter);
                    TaskA2(minLenght, sideLenght);
                    break;

                case 3:
                    TurtleCanvas.PosTurtle(TurtleCanvas.TurtlePos.MiddleCenter);
                    TaskA3(minLenght, sideLenght);
                    break;

                case 4:
                    TurtleCanvas.PosTurtle(TurtleCanvas.TurtlePos.MiddleCenter);
                    TaskA4(minLenght, sideLenght);
                    break;

                case 5:
                    TurtleCanvas.PosTurtle(TurtleCanvas.TurtlePos.MiddleCenter);
                    TaskA5(minLenght, sideLenght);
                    break;

                case 6:
                    TurtleCanvas.PosTurtle(TurtleCanvas.TurtlePos.MiddleCenter);
                    TaskA6(minLenght, sideLenght);
                    break;

                case 7:
                    TurtleCanvas.PosTurtle(TurtleCanvas.TurtlePos.MiddleCenter);
                    TaskA7(minLenght, sideLenght);
                    break;

                case 8:
                    TurtleCanvas.PosTurtle(TurtleCanvas.TurtlePos.MiddleCenter);
                    TaskA8(minLenght, sideLenght);
                    break;

                case 9:
                    TurtleCanvas.PosTurtle(TurtleCanvas.TurtlePos.MiddleCenter);
                    TaskA9(minLenght, sideLenght);
                    break;

                case 10:
                    TurtleCanvas.PosTurtle(TurtleCanvas.TurtlePos.MiddleCenter);
                    TaskA10(minLenght, sideLenght);
                    break;

                case 11:
                    TurtleCanvas.PosTurtle(TurtleCanvas.TurtlePos.MiddleCenter);
                    TaskA11(minLenght, sideLenght);
                    break;

                case 12:
                    TurtleCanvas.PosTurtle(TurtleCanvas.TurtlePos.MiddleCenter);
                    TaskA12(minLenght, sideLenght);
                    break;

                case 13:
                    TurtleCanvas.PosTurtle(TurtleCanvas.TurtlePos.BottomCenter);
                    TurtleCanvas.SetTurtleOrientation(TurtleCanvas.TurtleOrientation.ToBottom);
                    TaskA13(minLenght, sideLenght);
                    break;

                case 14:
                    TurtleCanvas.PosTurtle(TurtleCanvas.TurtlePos.BottomLeft);
                    TaskB1(minLenght, sideLenght);
                    break;

                case 15:
                    TurtleCanvas.PosTurtle(TurtleCanvas.TurtlePos.MiddleCenter);
                    TaskB2(minLenght, sideLenght);
                    break;

                case 16:
                    TurtleCanvas.PosTurtle(TurtleCanvas.TurtlePos.MiddleCenter);
                    TaskB3(minLenght, sideLenght);
                    break;

                case 17:
                    TurtleCanvas.PosTurtle(TurtleCanvas.TurtlePos.MiddleCenter);
                    TurtleCanvas.SetTurtleOrientation(TurtleCanvas.TurtleOrientation.ToBottom);
                    TaskB4(minLenght, sideLenght);
                    break;

                case 18:
                    TurtleCanvas.PosTurtle(TurtleCanvas.TurtlePos.MiddleCenter);
                    TaskB5(minLenght, sideLenght);
                    break;

                case 19:
                    TurtleCanvas.PosTurtle(TurtleCanvas.TurtlePos.MiddleCenter);
                    TaskB6(minLenght, sideLenght);
                    break;

                case 20:
                    TurtleCanvas.PosTurtle(TurtleCanvas.TurtlePos.MiddleCenter);
                    TaskB7(minLenght, sideLenght);
                    break;

                case 21:
                    TurtleCanvas.PosTurtle(TurtleCanvas.TurtlePos.MiddleCenter);
                    TurtleCanvas.SetTurtleOrientation(TurtleCanvas.TurtleOrientation.ToBottom);
                    TaskB8(minLenght, sideLenght);
                    break;

                case 22:
                    TurtleCanvas.PosTurtle(TurtleCanvas.TurtlePos.MiddleCenter);
                    TurtleCanvas.SetTurtleOrientation(TurtleCanvas.TurtleOrientation.ToBottom);
                    TaskC1(minLenght, sideLenght);
                    break;

                case 23:
                    TurtleCanvas.PosTurtle(TurtleCanvas.TurtlePos.MiddleCenter);
                    TaskC2(minLenght, sideLenght);
                    break;

                case 24:
                    TurtleCanvas.PosTurtle(TurtleCanvas.TurtlePos.MiddleCenter);
                    TaskC3(minLenght, sideLenght);
                    break;

                case 25:
                    TurtleCanvas.PosTurtle(TurtleCanvas.TurtlePos.MiddleCenter);
                    TaskC4(minLenght, sideLenght);
                    break;

                case 26:
                    TurtleCanvas.PosTurtle(TurtleCanvas.TurtlePos.MiddleCenter);
                    TaskC5(minLenght, sideLenght);
                    break;

                case 27:
                    TurtleCanvas.PosTurtle(TurtleCanvas.TurtlePos.MiddleCenter);
                    TaskC6(minLenght, sideLenght);
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

        void TaskA1(double min, double sideLen)
        {
            if (sideLen < min) return;
            for (int a = 0; a < 4; a++)
            {
                TurtleCanvas.Forward(sideLen);
                TurtleCanvas.Right(180);
                TaskA1(min, sideLen / 2);
                TurtleCanvas.Right(90);
            }
        }

        void TaskA2(double min, double sideLen)
        {
            if (sideLen < min) return;
            for (int a = 0; a < 3; a++)
            {
                TurtleCanvas.Forward(sideLen);
                TurtleCanvas.Right(120);
                TaskA2(min, sideLen / 2);
                TurtleCanvas.Right(120);
            }
        }

        void TaskA3(double min, double sideLen)
        {
            if (sideLen < min) return;
            for (int a = 0; a< 4; a++)
            {
                TurtleCanvas.Forward(sideLen);
                TurtleCanvas.Right(90);
                TaskA3(min, sideLen / 2);
                TurtleCanvas.Right(180);
            }
        }

        void TaskA4(double min, double sideLen)
        {
            if (sideLen < min) return;
            for (int a = 0; a < 3; a++)
            {
                TurtleCanvas.Forward(sideLen);
                TurtleCanvas.Right(60);
                TaskA4(min, sideLen / 2);
                TurtleCanvas.Right(180);
            }
        }

        void TaskA5(double min, double sideLen)
        {
            if (sideLen < min) return;

            for (int a = 0; a< 3; a++)
            {
                TurtleCanvas.Forward(sideLen);
                TurtleCanvas.Left(180);
                TaskA5(min, sideLen / 2);
                TurtleCanvas.Right(60);
            }
        }

        void TaskA6(double min, double sideLen)
        {
            if (sideLen < min) return;
            for (int a = 0; a< 4; a++)
            {
                TurtleCanvas.Forward(sideLen / 4);
                TurtleCanvas.Right(90);
                TaskA6(min, sideLen / 2);
                TurtleCanvas.Left(90);
                TurtleCanvas.Forward(3 * sideLen / 4);
                TurtleCanvas.Left(90);
            }
        }

        void TaskA7(double min, double sideLen)
        {
            if (sideLen < min) return;
            for (int a = 0; a< 3; a++)
            {
                TurtleCanvas.Forward(sideLen / 4);
                TurtleCanvas.Right(60);
                TaskA7(min, sideLen / 2);
                TurtleCanvas.Left(60);
                TurtleCanvas.Forward(3 * sideLen / 4);
                TurtleCanvas.Left(120);
            }
        }

        void TaskA8(double min, double sideLen)
        {
            if (sideLen < min) return;
            for (int a = 0; a < 6; a++)
            {
                TurtleCanvas.Forward(sideLen / 4);
                TurtleCanvas.Right(120);
                TaskA8(min, sideLen / 2);
                TurtleCanvas.Left(120);
                TurtleCanvas.Forward(3 * sideLen / 4);
                TurtleCanvas.Left(60);
            }
        }

        void TaskA9(double min, double sideLen)
        {
            if (sideLen < min) return;
            TurtleCanvas.Left(180);
            TurtleCanvas.Forward(sideLen);
            TurtleCanvas.Left(90);
            TaskA9(min, sideLen - min);
        }

        void TaskA10(double min, double sideLen)
        {
            if (sideLen < min) return;
            TurtleCanvas.Forward(sideLen);
            TurtleCanvas.Left(120);
            TaskA10(min, sideLen - min);
        }

        void TaskA11(double min, double sideLen)
        {
            if (sideLen < min) return;
            TurtleCanvas.Left(60);
            TurtleCanvas.Forward(sideLen);
            TaskA11(min, sideLen - min);
        }

        void TaskA12(double min, double sideLen)
        {
            if (sideLen < min) return;
            for (int a = 1; a <= 3; a++)
            {
                for (int b = 0; b < 3; b++)
                {
                    for (int c = 0; c < 3; c++)
                    {
                        TurtleCanvas.Forward(sideLen / 3);
                        TurtleCanvas.Left(120);
                    }
                    TaskA12(min, sideLen / 3);
                    TurtleCanvas.Forward(sideLen / 3);
                }
                TurtleCanvas.Left(120);
            }
        }

        void TaskA13(double min, double sideLen)
        {
            if (sideLen < min) return;
            TurtleCanvas.Forward(sideLen);
            TurtleCanvas.Left(45);
            TaskA13(min, sideLen * 0.6);
            TurtleCanvas.Left(90);
            TaskA13(min, sideLen * 0.6);
            TurtleCanvas.Left(45);
            TurtleCanvas.Forward(sideLen);
        }

        void TaskB1(double min, double sideLen)
        {
            if (sideLen < min) return;
            for (int a = 0; a < 2; a++)
            {
                TurtleCanvas.Forward(sideLen / 2);
                TaskB1(min, sideLen / 2);
                TurtleCanvas.Forward(sideLen / 2);
                TurtleCanvas.Left(90);
                TurtleCanvas.Forward(sideLen);
                TurtleCanvas.Left(90);
            }
        }

        void TaskB2(double min, double sideLen)
        {
            if (sideLen < min) return;
            for (int a = 0; a< 3; a++)
            {
                TurtleCanvas.Forward(sideLen / 4);
                TurtleCanvas.Right(120);
                TaskB2(min, sideLen / 2);
                TurtleCanvas.Left(120);
                TurtleCanvas.Forward(3 * sideLen / 4);
                TurtleCanvas.Left(60);
                TurtleCanvas.Forward(sideLen);
                TurtleCanvas.Left(60);
            }
        }

        void TaskB3(double min, double sideLen)
        {
            if (sideLen < min) return;
            for (int a = 0; a< 2; a++)
            {
                TurtleCanvas.Forward(sideLen);
                TurtleCanvas.Left(90);
                TurtleCanvas.Forward(sideLen / 4);
                TurtleCanvas.Right(90);
                TaskB3(min, sideLen / 2);
                TurtleCanvas.Left(90);
                TurtleCanvas.Forward(3 * sideLen / 4);
                TurtleCanvas.Left(90);
            }
        }

        void TaskB4(double min, double sideLen)
        {
            if (sideLen < min) return;

            for (int a = 0; a < 2; a++)
            {
                TurtleCanvas.Forward(sideLen);
                TurtleCanvas.Right(90);
                TaskB4(min, sideLen / 2);
                TurtleCanvas.Left(180);
                TurtleCanvas.Forward(sideLen);
                TurtleCanvas.Left(90);
            }

        }

        void TaskB5(double min, double sideLen)
        {
            if (sideLen < min) return;
            for (int a = 0; a < 4; a++)
            {
                TurtleCanvas.Forward(sideLen);
                TurtleCanvas.Left(90);
                TaskB5(min, sideLen / 3);
            }
        }

        void TaskB6(double min, double sideLen)
        {
            if (sideLen < min) return;
            for (int a = 0; a< 3; a++)
            {
                TurtleCanvas.Forward(sideLen);
                TurtleCanvas.Left(120);
                TaskB6(min, sideLen / 3);
            }
        }

        void TaskB7(double min, double sideLen)
        {
            if (sideLen < min) return;
            for (int a = 0; a< 3; a++)
            {
                TurtleCanvas.Forward(sideLen / 2);
                TaskB7(min, sideLen / 2);
                TurtleCanvas.Forward(sideLen / 2);
                TurtleCanvas.Left(60);
                TurtleCanvas.Forward(sideLen);
                TurtleCanvas.Left(60);
            }
        }

        void TaskB8(double min, double sideLen)
        {
            if (sideLen < min) return;

            TurtleCanvas.Forward(sideLen);
            TaskB8(min, sideLen / 2);
            TurtleCanvas.Left(180);
            TurtleCanvas.Forward(sideLen);
            TurtleCanvas.Left(135);
            TurtleCanvas.Forward(sideLen);
            TaskB8(min, sideLen / 2);
            TurtleCanvas.Left(180);
            TurtleCanvas.Forward(sideLen);
            TurtleCanvas.Right(90);
            TurtleCanvas.Forward(sideLen);
            TaskB8(min, sideLen / 2);
            TurtleCanvas.Left(180);
            TurtleCanvas.Forward(sideLen);
            TurtleCanvas.Left(135);
        }

        void TaskC1(double min, double sideLen)
        {
            if (sideLen < min) return;
            TurtleCanvas.Left(5);
            TurtleCanvas.Forward(sideLen);
            TurtleCanvas.Left(120);
            TaskC1(min, sideLen * 0.98);
        }

        void TaskC2(double min, double sideLen)
        {
            if (sideLen < min) return;

            TurtleCanvas.Left(150);
            TurtleCanvas.Forward(sideLen);

        }

        void TaskC3(double min, double sideLen)
        {
            if (sideLen < min) return;
        }

        void TaskC4(double min, double sideLen)
        {
            if (sideLen < min) return;
        }

        void TaskC5(double min, double sideLen)
        {
            if (sideLen < min) return;
            for (int a = 0; a < 4; a++)
            {
                
            }
        }

        void TaskC6(double min, double sideLen)
        {
            if (sideLen < min) return;
            for (int a = 0; a < 3; a++)
            {
                TurtleCanvas.Left(60);
                TurtleCanvas.Forward(sideLen);
                TurtleCanvas.Left(180);
                TaskC6(min, sideLen / 2);
                TurtleCanvas.Forward(sideLen);
            }
        }
    }
}
