using System.Windows;

namespace TutorialWPF
{
    
    public partial class MainWindow : Window
    {
        bool running = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnToggleRun_Click(object sender, RoutedEventArgs e)
        {
            if (running)
            {
                tbStatus.Text = "Stopped";
                btnToggleRun.Content = "Run";
            }else
            {
                tbStatus.Text = "Running";
                btnToggleRun.Content = "Stop";
            }
            running = !running;
        }
    }
}