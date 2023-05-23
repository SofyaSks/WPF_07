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

namespace shapes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            /*Random random = new Random();
            for (int x = 0; x < 100; x += 10)
                polyline.Points.Add(new Point(x, random.Next(0, 200)));*/

            List<Point> points = new List<Point>();
            for (int i = 0; i < 5; i++)
            {
                double a = (i * 72 - 90) * (Math.PI/180);
                double r = 100;

                // переводим в декартовы
                double x = r * Math.Cos(a) + 100;
                double y = r * Math.Sin(a) + 100;
                points.Add(new Point(x, y)); // запоминаем точку
            } 

            PathGeometry g = new PathGeometry();
            PathFigure f = new PathFigure() { StartPoint = points[0], IsClosed = true };
            for (int i = 1; i < 5; i++)
            {
                f.Segments.Add(new LineSegment() { Point = points[i] });
            }

            g.Figures.Add(f);
            Path.Data = g; 
        }
    }
}
