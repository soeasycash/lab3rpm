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

namespace lab3rpm
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
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double sideA, sideB;
            if (double.TryParse(SideATextBox.Text, out sideA) &&
                double.TryParse(SideBTextBox.Text, out sideB))
            {
                Triangle triangle = null;
                if (sideA!=0&&sideB!=0)
                {
                    triangle = new RightTriangle(sideA, sideB);
                }
                if (triangle != null)
                {
                    double area = triangle.CalculateArea();
                    double perimeter = triangle.CalculatePerimeter();

                    // Выводите результаты на экран, например, в Label или TextBox
                    AreaResultLabel.Content = "Площадь: " + Math.Round(area, 4);
                    PerimeterResultLabel.Content = "Периметр: " + Math.Round(perimeter, 4);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректные числовые значения.");
            }
        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            double sideA, angleAB;
            if (double.TryParse(SideATextBox.Text, out sideA) &&
                double.TryParse(AngleTextBox.Text, out angleAB))
            {
                Triangle triangle = null;
                if (sideA != 0 && angleAB != 0)
                {
                    triangle = new IsoscelesTriangle(sideA, angleAB);
                }
                if (triangle != null)
                {
                    double area = triangle.CalculateArea();
                    double perimeter = triangle.CalculatePerimeter();

                    // Выводите результаты на экран, например, в Label или TextBox
                    AreaResultLabel.Content = "Площадь: " + Math.Round(area, 4);
                    PerimeterResultLabel.Content = "Периметр: " + Math.Round(perimeter, 4);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректные числовые значения.");
            }
        }
        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            double sideA, angleAB;
            if (double.TryParse(SideATextBox.Text, out sideA))
            {
                Triangle triangle = null;
                if (sideA != 0)
                {
                    triangle = new EquilateralTriangle(sideA);
                }
                if (triangle != null)
                {
                    double area = triangle.CalculateArea();
                    double perimeter = triangle.CalculatePerimeter();

                    // Выводите результаты на экран, например, в Label или TextBox
                    AreaResultLabel.Content = "Площадь: " + Math.Round(area, 4);
                    PerimeterResultLabel.Content = "Периметр: " + Math.Round(perimeter, 4);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректные числовые значения.");
            }
        }
    }
}
