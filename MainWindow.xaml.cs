using ControlKeys.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ControlKeys
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            var p1 = new PersonButton() { Title = "João Junior", Subtitle = "TAE" };
            var p2 = new PersonButton() { Title = "João Teixeira", Subtitle = "Docente" };
            p1.Click += Button_Click;
            p2.Click += Button_Click;

            WPanel.Children.Add(p1);
            WPanel.Children.Add(p2);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Teste");
        }
    }
}
