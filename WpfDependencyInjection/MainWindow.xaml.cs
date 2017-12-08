using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfDependencyInjection
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TextBlock lbl_clock;

        public MainWindow()
        {
            InitializeComponent();
            

            Grid layout = new Grid();
            lbl_clock = new TextBlock
            {
                FontSize = 60,
                TextAlignment = TextAlignment.Center,
                Text = (new ClockDigital()).GetResult(),
                Width = 400,
                Height=150
            };

            GetClock();

            layout.VerticalAlignment = VerticalAlignment.Center;
            layout.HorizontalAlignment = HorizontalAlignment.Center;
            layout.Children.Add(lbl_clock);
            Janela.Children.Add(layout);

            Timer timer = new Timer(1000);
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        private void GetClock()
        {
            lbl_clock.Text = (new ClockDigital()).GetResult();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {

            Application.Current.Dispatcher.Invoke(() => GetClock());
            
        }
    }
}
