using System;
using System.Collections.Generic;
using System.Data;
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

namespace Итоговое_задание
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            foreach (UIElement a in Package.Children)
            {
                if (a is Button)
                {
                    ((Button)a).Click += Button_Click;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string click = (string)((Button)e.OriginalSource).Content;
            if (click == "Очистить")
                field.Text = "";
            else if (click == "=")
            {
                string result = new DataTable().Compute(field.Text, null).ToString();
                field.Text = result;
            }
            else
                field.Text += click;
        }
    }
}
