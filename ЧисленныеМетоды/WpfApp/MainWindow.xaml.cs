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

namespace WpfApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Matrix> matrix = new List<Matrix>();
            matrix.Add(new Matrix() { Ai1 = 7, Ai2 = 0.09, Ai3 = -0.03 });
            matrix.Add(new Matrix() { Ai1 = 0.09, Ai2 = 4, Ai3 = -0.15 });
            matrix.Add(new Matrix() { Ai1 = 0.04, Ai2 = -0.08, Ai3 = 6 });
            List<MatrixBi> matrixBi = new List<MatrixBi>();
            matrixBi.Add(new MatrixBi() { Bi = 6.7 });
            matrixBi.Add(new MatrixBi() { Bi = 8.7 });
            matrixBi.Add(new MatrixBi() { Bi = 15.3 });
            dataGridViewAij.ItemsSource = matrix;
            dataGridViewBi.ItemsSource = matrixBi;
        }
        public class MatrixBi
        {
            public double Bi { get; set; }
        }
        public class Matrix
        {
            public double Ai1 { get; set; }
            public double Ai2 { get; set; }
            public double Ai3 { get; set; }
        }
    }
}
