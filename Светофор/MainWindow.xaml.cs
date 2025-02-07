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

namespace Светофор
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Выключаем все сигналы при запуске программы 
            TurnOffAllSignals();
        }

        private void TurnOffAllSignals()
        {
            // Выключаем все сигналы на обоих светофорах
            Red1.Fill = Brushes.LightGray;
            Yellow1.Fill = Brushes.LightGray;
            Green1.Fill = Brushes.LightGray;

            Red2.Fill = Brushes.LightGray;
            Yellow2.Fill = Brushes.LightGray;
            Green2.Fill = Brushes.LightGray;
        }

        private void Ellipse_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // Получаем элемент, на который нажали
            Ellipse ellipse = sender as Ellipse;

            // Сначала выключаем все сигналы на обоих светофорах
            TurnOffAllSignals();

            // Затем включаем нужный сигнал на соответствующем светофоре
            if (ellipse != null)
            {
                // В зависимости от названия элемента, включаем нужный сигнал на первом светофоре
                switch (ellipse.Name)
                {
                    case "Red":
                        Red1.Fill = Brushes.Red;
                        Green2.Fill = Brushes.Green;
                        break;
                    case "Yellow":
                        Yellow1.Fill = Brushes.Yellow;
                        Yellow2.Fill = Brushes.Yellow;
                        break;
                    case "Green":
                        Green1.Fill = Brushes.Green;
                        Red2.Fill = Brushes.Red;
                        break;
                    case "Red2":
                        Red2.Fill = Brushes.Red;
                        Green1.Fill = Brushes.Green;
                        break;
                    case "Yellow2":
                        Yellow2.Fill = Brushes.Yellow;
                        Yellow1.Fill = Brushes.Yellow;
                        break;
                    case "Green2":
                        Green2.Fill = Brushes.Green;
                        Red1.Fill = Brushes.Red;
                        break;
                }
            }
        }
    }


}
