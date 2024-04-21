using KrytoiKalculator.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace KrytoiKalculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private StringBuilder stringBuilder = new StringBuilder();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = new ModelView();
        }

        private void LeftSkobka(object sender, RoutedEventArgs e)
        {
            stringBuilder.Append("(");
            DlyaVvodaTextBox.Text = stringBuilder.ToString();
        }

        private void RightSkobka(object sender, RoutedEventArgs e)
        {
            stringBuilder.Append(")");
            DlyaVvodaTextBox.Text = stringBuilder.ToString();
        }

        private void Percent(object sender, RoutedEventArgs e)
        {
            stringBuilder.Append("%");
            DlyaVvodaTextBox.Text = stringBuilder.ToString();
        }

        private void Clear(object sender, RoutedEventArgs e)
        {
            stringBuilder.Clear(); 
            DlyaVvodaTextBox.Text = ""; 
        }

        private void Delenie(object sender, RoutedEventArgs e)
        {
            stringBuilder.Append("/");
            DlyaVvodaTextBox.Text = stringBuilder.ToString();
        }

        private void Ymnoshenie(object sender, RoutedEventArgs e)
        {
            stringBuilder.Append("*");
            DlyaVvodaTextBox.Text = stringBuilder.ToString();
        }

        private void Vichetanie(object sender, RoutedEventArgs e)
        {
            stringBuilder.Append("-");
            DlyaVvodaTextBox.Text = stringBuilder.ToString();
        }

        private void Sloshenie(object sender, RoutedEventArgs e)
        {
            stringBuilder.Append("+");
            DlyaVvodaTextBox.Text = stringBuilder.ToString();
        }

        private void Seven(object sender, RoutedEventArgs e)
        {
            stringBuilder.Append("7");
            DlyaVvodaTextBox.Text = stringBuilder.ToString();
        }

        private void Eight(object sender, RoutedEventArgs e)
        {
            stringBuilder.Append("8");
            DlyaVvodaTextBox.Text = stringBuilder.ToString();
        }

        private void Nine(object sender, RoutedEventArgs e)
        {
            stringBuilder.Append("9");
            DlyaVvodaTextBox.Text = stringBuilder.ToString();
        }

        private void Four(object sender, RoutedEventArgs e)
        {
            stringBuilder.Append("4");
            DlyaVvodaTextBox.Text = stringBuilder.ToString();
        }

        private void five(object sender, RoutedEventArgs e)
        {
            stringBuilder.Append("5");
            DlyaVvodaTextBox.Text = stringBuilder.ToString();
        }

        private void Six(object sender, RoutedEventArgs e)
        {
            stringBuilder.Append("6");
            DlyaVvodaTextBox.Text = stringBuilder.ToString();
        }

        private void One(object sender, RoutedEventArgs e)
        {
            stringBuilder.Append("1");
            DlyaVvodaTextBox.Text = stringBuilder.ToString();
        }

        private void two(object sender, RoutedEventArgs e)
        {
            stringBuilder.Append("2");
            DlyaVvodaTextBox.Text = stringBuilder.ToString();
        }

        private void Three(object sender, RoutedEventArgs e)
        {
            stringBuilder.Append("3");
            DlyaVvodaTextBox.Text = stringBuilder.ToString();
        }

        private void Zero(object sender, RoutedEventArgs e)
        {
            stringBuilder.Append("0");
            DlyaVvodaTextBox.Text = stringBuilder.ToString();
        }

        private void Dot(object sender, RoutedEventArgs e)
        {
            stringBuilder.Append(".");
            DlyaVvodaTextBox.Text = stringBuilder.ToString();
        }

        public static class CustomMessageBox
        {
            public static void Show(string message, string title)
            {
                Window window = new Window
                {
                    Title = title,
                    Width = 300,
                    Height = 150,
                    WindowStartupLocation = WindowStartupLocation.CenterScreen,
                    Content = new TextBlock { Text = message, TextWrapping = TextWrapping.Wrap, HorizontalAlignment = HorizontalAlignment.Center, VerticalAlignment = VerticalAlignment.Center}
                };

                window.Background = System.Windows.Media.Brushes.LightPink;

                window.ShowDialog();
            }
        }

        private void Result(object sender, RoutedEventArgs e)
        {
            string expression = stringBuilder.ToString();
            try
            {
                DataTable dataTable = new DataTable();
                object result = dataTable.Compute(expression, "");
                stringBuilder.Clear();
                stringBuilder.Append(result.ToString());
                DlyaVvodaTextBox.Text = result.ToString();
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show("Введи правильное уравнение", "Ошибка");
            }
        }
    }
}
