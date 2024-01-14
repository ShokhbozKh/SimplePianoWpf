using System.Media;
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

namespace WpfApp9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //hello codes
        }

        private void Window_KeyDown(object sender, KeyEventArgs e) /// KEYBOARD ////////////
        {
            if (e.Key == Key.A)
            {
                SoundPlayer soundPlayer = new SoundPlayer(@"D:\PDP .Net\C# codes\WpfApp9\WpfApp9\Resources\A.wav");
                soundPlayer.Play();
            }
            if (e.Key == Key.B)
            {
                SoundPlayer soundPlayer = new SoundPlayer(@"D:\PDP .Net\C# codes\WpfApp9\WpfApp9\Resources\B.wav");
                soundPlayer.Play();
            }
            if (e.Key == Key.C)
            {
                SoundPlayer soundPlayer = new SoundPlayer(@"D:\PDP .Net\C# codes\WpfApp9\WpfApp9\Resources\C.wav");
                soundPlayer.Play();
            }
            if (e.Key == Key.Q)
            {
                SoundPlayer soundPlayer = new SoundPlayer(@"D:\PDP .Net\C# codes\WpfApp9\WpfApp9\Resources\BB.wav");
                soundPlayer.Play();
            }
            if (e.Key == Key.C)
            {
                SoundPlayer soundPlayer = new SoundPlayer(@"D:\PDP .Net\C# codes\WpfApp9\WpfApp9\Resources\C.wav");
                soundPlayer.Play();
            }
            if (e.Key == Key.W)
            {
                SoundPlayer soundPlayer = new SoundPlayer(@"D:\PDP .Net\C# codes\WpfApp9\WpfApp9\Resources\C_s.wav");
                soundPlayer.Play();
            }
            if (e.Key == Key.R)
            {
                SoundPlayer soundPlayer = new SoundPlayer(@"D:\PDP .Net\C# codes\WpfApp9\WpfApp9\Resources\C_s1.wav");
                soundPlayer.Play();
            }
            if (e.Key == Key.T)
            {
                SoundPlayer soundPlayer = new SoundPlayer(@"D:\PDP .Net\C# codes\WpfApp9\WpfApp9\Resources\C1.wav");
                soundPlayer.Play();
            }
            if (e.Key == Key.D)
            {
                SoundPlayer soundPlayer = new SoundPlayer(@"D:\PDP .Net\C# codes\WpfApp9\WpfApp9\Resources\D.wav");
                soundPlayer.Play();
            }
            if (e.Key == Key.Y)
            {
                SoundPlayer soundPlayer = new SoundPlayer(@"D:\PDP .Net\C# codes\WpfApp9\WpfApp9\Resources\D_s.wav");
                soundPlayer.Play();
            }
            if (e.Key == Key.U)
            {
                SoundPlayer soundPlayer = new SoundPlayer(@"D:\PDP .Net\C# codes\WpfApp9\WpfApp9\Resources\D_s1.wav");
                soundPlayer.Play();
            }
            if (e.Key == Key.I)
            {
                SoundPlayer soundPlayer = new SoundPlayer(@"D:\PDP .Net\C# codes\WpfApp9\WpfApp9\Resources\D1.wav");
                soundPlayer.Play();
            }
            if (e.Key == Key.E)
            {
                SoundPlayer soundPlayer = new SoundPlayer(@"D:\PDP .Net\C# codes\WpfApp9\WpfApp9\Resources\E.wav");
                soundPlayer.Play();
            }
            if (e.Key == Key.O)
            {
                SoundPlayer soundPlayer = new SoundPlayer(@"D:\PDP .Net\C# codes\WpfApp9\WpfApp9\Resources\E1.wav");
                soundPlayer.Play();
            }
            if (e.Key == Key.F)
            {
                SoundPlayer soundPlayer = new SoundPlayer(@"D:\PDP .Net\C# codes\WpfApp9\WpfApp9\Resources\F.wav");
                soundPlayer.Play();
            }
            if (e.Key == Key.P)
            {
                SoundPlayer soundPlayer = new SoundPlayer(@"D:\PDP .Net\C# codes\WpfApp9\WpfApp9\Resources\F_s.wav");
                soundPlayer.Play();
            }
            if (e.Key == Key.M)
            {
                SoundPlayer soundPlayer = new SoundPlayer(@"D:\PDP .Net\C# codes\WpfApp9\WpfApp9\Resources\F1.wav");
                soundPlayer.Play();
            }
            if (e.Key == Key.G)
            {
                SoundPlayer soundPlayer = new SoundPlayer(@"D:\PDP .Net\C# codes\WpfApp9\WpfApp9\Resources\G.wav");
                soundPlayer.Play();
            }
            if (e.Key == Key.N)
            {
                SoundPlayer soundPlayer = new SoundPlayer(@"D:\PDP .Net\C# codes\WpfApp9\WpfApp9\Resources\G_s.wav");
                soundPlayer.Play();
            }


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer(@"D:\PDP .Net\C# codes\WpfApp9\WpfApp9\Resources\C.wav");
            soundPlayer.Play();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer(@"D:\PDP .Net\C# codes\WpfApp9\WpfApp9\Resources\F.wav");
            soundPlayer.Play();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer(@"D:\PDP .Net\C# codes\WpfApp9\WpfApp9\Resources\C_s.wav");
            soundPlayer.Play();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer(@"D:\PDP .Net\C# codes\WpfApp9\WpfApp9\Resources\D.wav");
            soundPlayer.Play();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer(@"D:\PDP .Net\C# codes\WpfApp9\WpfApp9\Resources\D_s.wav");
            soundPlayer.Play();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer(@"D:\PDP .Net\C# codes\WpfApp9\WpfApp9\Resources\E.wav");
            soundPlayer.Play();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer(@"D:\PDP .Net\C# codes\WpfApp9\WpfApp9\Resources\F_s.wav");
            soundPlayer.Play();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer(@"D:\PDP .Net\C# codes\WpfApp9\WpfApp9\Resources\G.wav");
            soundPlayer.Play();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer(@"D:\PDP .Net\C# codes\WpfApp9\WpfApp9\Resources\G_s.wav");
            soundPlayer.Play();
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer(@"D:\PDP .Net\C# codes\WpfApp9\WpfApp9\Resources\A.wav");
            soundPlayer.Play();
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer(@"D:\PDP .Net\C# codes\WpfApp9\WpfApp9\Resources\Bb.wav");
            soundPlayer.Play();
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer(@"D:\PDP .Net\C# codes\WpfApp9\WpfApp9\Resources\B.wav");
            soundPlayer.Play();
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer(@"D:\PDP .Net\C# codes\WpfApp9\WpfApp9\Resources\C_s.wav");
            soundPlayer.Play();
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer(@"D:\PDP .Net\C# codes\WpfApp9\WpfApp9\Resources\C_s1.wav");
            soundPlayer.Play();
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer(@"D:\PDP .Net\C# codes\WpfApp9\WpfApp9\Resources\D1.wav");
            soundPlayer.Play();
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer(@"D:\PDP .Net\C# codes\WpfApp9\WpfApp9\Resources\D_s1.wav");
            soundPlayer.Play();
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer(@"D:\PDP .Net\C# codes\WpfApp9\WpfApp9\Resources\E.wav");
            soundPlayer.Play();
        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer(@"D:\PDP .Net\C# codes\WpfApp9\WpfApp9\Resources\F1.wav");
            soundPlayer.Play();
        }


    }
}