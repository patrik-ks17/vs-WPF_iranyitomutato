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

namespace WPF_nfl_iranyitok
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

        private double MinMax(double x)
        {
            if (x < 0)
                return 0;
            if (x > 2.375)
                return 2.375;
            return x;
        }

        private double Szamol(int kiserlet, int sikeres, int yardok, int tdPassz, int eladott)
        {
            double a, b, c, d;
            a = MinMax(((double)sikeres / kiserlet - 0.3) * 5);
            b = MinMax(((double)yardok / kiserlet - 3) * 0.25);
            c = MinMax(((double)tdPassz / kiserlet) * 20);
            d = MinMax(2.375 - ((double)eladott / kiserlet) * 25);

            return 100 * (a + b + c + d) / 6;
        }
    }
}
