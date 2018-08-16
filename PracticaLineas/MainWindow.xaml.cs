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

namespace PracticaLineas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            plnlinea.Points.Add(new Point(200.0, 200.0));
            plnlinea.Points.Add(new Point(300.0, 100.0));
            plnlinea.Points.Add(new Point(400.0, 200.0));
            plnlinea.Points.Add(new Point(200.0, 200.0));

            plnlinea2.Points.Add(new Point(200.0, 200.0));
            plnlinea2.Points.Add(new Point(200.0, 350.0));
            plnlinea2.Points.Add(new Point(400.0, 350.0));
            plnlinea2.Points.Add(new Point(400.0, 200.0));


            plnlinea3.Points.Add(new Point(250.0, 350.0));
            plnlinea3.Points.Add(new Point(250.0, 280.0));
            plnlinea3.Points.Add(new Point(300.0, 280.0));
            plnlinea3.Points.Add(new Point(300.0, 350.0));


            plnlinea4.Points.Add(new Point(320.0, 280.0));
            plnlinea4.Points.Add(new Point(360.0, 280.0));
            plnlinea4.Points.Add(new Point(360.0, 240.0));
            plnlinea4.Points.Add(new Point(320.0, 240.0));
            plnlinea4.Points.Add(new Point(320.0, 280.0));

            for (float i=0; i<=360; i++)
            {
                plnlineaSol.Points.Add(new Point(Math.Cos(i) * 50 + 100, Math.Sin(i) * 50 + 100));
            }

            plnlineaCa.Points.Add(new Point(550.0, 250.0));
            plnlineaCa.Points.Add(new Point(550.0, 350.0));
            plnlineaCa.Points.Add(new Point(600.0, 350.0));
            plnlineaCa.Points.Add(new Point(600.0, 250.0));
            plnlineaCa.Points.Add(new Point(640.0, 250.0));
            plnlineaCa.Points.Add(new Point(640.0, 210.0));
            plnlineaCa.Points.Add(new Point(610.0, 210.0));
            plnlineaCa.Points.Add(new Point(610.0, 225.0));
            plnlineaCa.Points.Add(new Point(600.0, 225.0));
            plnlineaCa.Points.Add(new Point(600.0, 170.0));
            plnlineaCa.Points.Add(new Point(560.0, 170.0));
            plnlineaCa.Points.Add(new Point(560.0, 220.0));
            plnlineaCa.Points.Add(new Point(540.0, 220.0));
            plnlineaCa.Points.Add(new Point(540.0, 180.0));
            plnlineaCa.Points.Add(new Point(515.0, 180.0));
            plnlineaCa.Points.Add(new Point(515.0, 250.0));
            plnlineaCa.Points.Add(new Point(550.0, 250.0));


            plnlineaCe.Points.Add(new Point(140.0, 330.0));
            plnlineaCe.Points.Add(new Point(150.0, 350.0));
            plnlineaCe.Points.Add(new Point(160.0, 330.0));

            plnlineaCe2.Points.Add(new Point(110.0, 330.0));
            plnlineaCe2.Points.Add(new Point(120.0, 350.0));
            plnlineaCe2.Points.Add(new Point(130.0, 330.0));

            plnlineaCe3.Points.Add(new Point(80.0, 330.0));
            plnlineaCe3.Points.Add(new Point(90.0, 350.0));
            plnlineaCe3.Points.Add(new Point(100.0, 330.0));
        }
    }
}
