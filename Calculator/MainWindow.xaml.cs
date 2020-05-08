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

namespace Calculator
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<double> Numbers { get; set; } = new List<double>();
        private List<char> SpecialSigns { get; set; } = new List<char>();
        private string MathematicalExpression { get; set; } = "";
        private double Result { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddValue(int n)
        {
            MathematicalExpression += n;
            MathResult.Text += n;
        }

        private void One_Click(object sender, RoutedEventArgs e)
        {
            AddValue(1);
        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {
            AddValue(2);
        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {
            AddValue(3);
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            AddValue(4);
        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {
            AddValue(5);
        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            AddValue(6);
        }

        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            AddValue(7);
        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            AddValue(8);
        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            AddValue(9); 
        }

        private void Addition_Click(object sender, RoutedEventArgs e)
        {
            Numbers.Add(Convert.ToDouble(MathematicalExpression));
            SpecialSigns.Add('+');
            MathResult.Text += "+";
            MathematicalExpression = "";
        }

        private void Subtraction_Click(object sender, RoutedEventArgs e)
        {
            Numbers.Add(Convert.ToDouble(MathematicalExpression));
            SpecialSigns.Add('-');
            MathResult.Text += "-";
            MathematicalExpression = "";
        }

        private void Multiplication_Click(object sender, RoutedEventArgs e)
        {
            Numbers.Add(Convert.ToDouble(MathematicalExpression));
            SpecialSigns.Add('*');
            MathResult.Text += "*";
            MathematicalExpression = "";
        }

        private void Division_Click(object sender, RoutedEventArgs e)
        {
            Numbers.Add(Convert.ToDouble(MathematicalExpression));
            SpecialSigns.Add('/');
            MathResult.Text += "/";
            MathematicalExpression = "";
        }

        private void Equal_Click(object sender, RoutedEventArgs e)
        {
            Numbers.Add(Convert.ToDouble(MathematicalExpression));

            Result = Numbers[0];

            for (int i = 1, j = 0; i < Numbers.Count && j < SpecialSigns.Count; i++, j++)
            {
                if (SpecialSigns[j] == '+')
                {
                    Result += Numbers[i];
                }
                else if (SpecialSigns[j] == '-')
                {
                    Result -= Numbers[i];
                }
                else if (SpecialSigns[j] == '*')
                {
                    Result *= Numbers[i];
                }
                else if (SpecialSigns[j] == '/')
                {
                    Result /= Numbers[i];
                }
            }
            MessageBox.Show(Result.ToString());
            Result = 0;
            Numbers.Clear();
            SpecialSigns.Clear();
            MathResult.Text = "";
            MathematicalExpression = "";
        }
    }
}
