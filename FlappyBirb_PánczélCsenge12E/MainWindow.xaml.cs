using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FlappyBirb_PánczélCsenge12E
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

       

        private void szintekButton_Click(object sender, RoutedEventArgs e)
        {
            szintekButton.Visibility = Visibility.Hidden;
            eredmenyekButton.Visibility = Visibility.Hidden;
            simaButton.Visibility = Visibility.Visible;
            esosButton.Visibility = Visibility.Visible;
            kodosButton.Visibility = Visibility.Visible;
            VisszaMainButton.Visibility = Visibility.Visible;
            ScoreTextblock.Visibility = Visibility.Hidden;
            VisszaAFőmenübe.Visibility = Visibility.Hidden;
            flappyBird.Visibility = Visibility.Visible;
        }

        private void VisszaMainButton_Click(object sender, RoutedEventArgs e)
        {
            szintekButton.Visibility = Visibility.Visible;
            eredmenyekButton.Visibility = Visibility.Visible;
            simaButton.Visibility = Visibility.Hidden;
            esosButton.Visibility = Visibility.Hidden;
            kodosButton.Visibility = Visibility.Hidden;
            VisszaMainButton.Visibility = Visibility.Hidden;
            ScoreTextblock.Visibility = Visibility. Hidden;
            VisszaAFőmenübe.Visibility = Visibility.Hidden;
            flappyBird.Visibility = Visibility.Visible;
            scoreText.Visibility = Visibility.Visible;
        }

        private void VisszaAFőmenübe_Click(object sender, RoutedEventArgs e)
        {
            szintekButton.Visibility = Visibility.Visible;
            eredmenyekButton.Visibility = Visibility.Visible;
            simaButton.Visibility = Visibility.Hidden;
            esosButton.Visibility = Visibility.Hidden;
            kodosButton.Visibility = Visibility.Hidden;
            VisszaMainButton.Visibility = Visibility.Hidden;
            ScoreTextblock.Visibility = Visibility.Hidden;
            VisszaAFőmenübe.Visibility = Visibility.Hidden;
            flappyBird.Visibility = Visibility.Visible;
            scoreText.Visibility = Visibility.Visible;

        }

        private void eredmenyekButton_Click(object sender, RoutedEventArgs e)
        {
            szintekButton.Visibility = Visibility.Hidden;
            eredmenyekButton.Visibility = Visibility.Hidden;
            VisszaAFőmenübe.Visibility = Visibility.Visible;
            ScoreTextblock.Visibility = Visibility.Visible;
            flappyBird.Visibility = Visibility.Hidden;
            scoreText.Visibility = Visibility.Hidden;
        }
    }
}