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

namespace _2._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static int f;
        public MainWindow()
        {
            InitializeComponent();

            Rab(false);
        }

        private void Start(object sender, RoutedEventArgs e)
        {
            WhatHow.Text = "Крестики-нолики";

            Rab(true);

            First();

            ButtonStart.IsEnabled = false;
        }

        private void Rab(bool r)
        {
            Button1.IsEnabled = r;
            Button2.IsEnabled = r;
            Button3.IsEnabled = r;
            Button4.IsEnabled = r;
            Button5.IsEnabled = r;
            Button6.IsEnabled = r;
            Button7.IsEnabled = r;
            Button8.IsEnabled = r;
            Button9.IsEnabled = r;
        }

        private void First()
        {
            Random rnd = new Random();
            f = rnd.Next(0, 10);

            if(f <= 5) 
            {
                Pisanie();
            }
        }

        private void Click1(object sender, RoutedEventArgs e)
        {
            string znak = ZNACHOK();

            Button1.Content = znak;
            Button1.IsEnabled = false;

            Pisanie();
        }

        private void Click2(object sender, RoutedEventArgs e)
        {
            string znak = ZNACHOK();

            Button2.Content = znak;
            Button2.IsEnabled = false;

            Pisanie();
        }

        private void Click3(object sender, RoutedEventArgs e)
        {
            string znak = ZNACHOK();

            Button3.Content = znak;
            Button3.IsEnabled = false;

            Pisanie();
        }

        private void Click4(object sender, RoutedEventArgs e)
        {
            string znak = ZNACHOK();

            Button4.Content = znak;
            Button4.IsEnabled = false;

            Pisanie();
        }

        private void Click5(object sender, RoutedEventArgs e)
        {
            string znak = ZNACHOK();

            Button5.Content = znak;
            Button5.IsEnabled = false;

            Pisanie();
        }

        private void Click6(object sender, RoutedEventArgs e)
        {
            string znak = ZNACHOK();

            Button6.Content = znak;
            Button6.IsEnabled = false;

            Pisanie();
        }

        private void Click7(object sender, RoutedEventArgs e)
        {
            string znak = ZNACHOK();

            Button7.Content = znak;
            Button7.IsEnabled = false;

            Pisanie();
        }

        private void Click8(object sender, RoutedEventArgs e)
        {
            string znak = ZNACHOK();

            Button8.Content = znak;
            Button8.IsEnabled = false;

            Pisanie();
        }

        private void Click9(object sender, RoutedEventArgs e)
        {
            string znak = ZNACHOK();

            Button9.Content = znak;
            Button9.IsEnabled = false;

            Pisanie();
        }

        private void Pisanie()
        {
            string znak;
            int but;

            while(true)
            {
                Random rnd = new Random();
                but = rnd.Next(1, 9);

                if (f <= 5)
                {
                    znak = "X";
                }
                else
                {
                    znak = "O";
                }

                if (but == 1 && Button1.Content != "O" && Button1.Content != "X")
                {
                    Button1.Content = znak;
                    Button1.IsEnabled = false;

                    break;
                }
                else if (but == 2 && Button2.Content != "O" && Button2.Content != "X")
                {
                    Button2.Content = znak;
                    Button2.IsEnabled = false;

                    break;
                }
                else if (but == 3 && Button3.Content != "O" && Button3.Content != "X")
                {
                    Button3.Content = znak;
                    Button3.IsEnabled = false;

                    break;
                }
                else if (but == 4 && Button4.Content != "O" && Button4.Content != "X")
                {
                    Button4.Content = znak;
                    Button4.IsEnabled = false;

                    break;
                }
                else if (but == 5 && Button5.Content != "O" && Button5.Content != "X")
                {
                    Button5.Content = znak;
                    Button5.IsEnabled = false;

                    break;
                }
                else if (but == 6 && Button6.Content != "O" && Button6.Content != "X")
                {
                    Button6.Content = znak;
                    Button6.IsEnabled = false;

                    break;
                }
                else if (but == 7 && Button7.Content != "O" && Button7.Content != "X")
                {
                    Button7.Content = znak;
                    Button7.IsEnabled = false;

                    break;
                }
                else if (but == 8 && Button8.Content != "O" && Button8.Content != "X")
                {
                    Button8.Content = znak;
                    Button8.IsEnabled = false;

                    break;
                }
                else if (but == 9 && Button9.Content != "O" && Button9.Content != "X")
                {
                    Button9.Content = znak;
                    Button9.IsEnabled = false;

                    break;
                }
            } 
        }

        private string ZNACHOK()
        {
            string znak;
            if (f <= 5)
            {
                znak = "O";
            }
            else
            {
                znak = "X";
            }

            return znak;
        }

        private void Re(object sender, RoutedEventArgs e)
        {
            Button1.Content = null;
            Button2.Content = null;
            Button3.Content = null;
            Button4.Content = null;
            Button5.Content = null;
            Button6.Content = null;
            Button7.Content = null;
            Button8.Content = null;
            Button9.Content = null;

            Rab(false);

            Pobeda();

            ButtonStart.IsEnabled = true;
        }

        private void Pobeda()
        {
            if(Button1.Content == "X" && Button2.Content == "X" && Button3.Content == "X") 
            {
                WhatHow.Text = "Победили КРЕСТИКИ";
            }
            else if (Button4.Content == "X" && Button5.Content == "X" && Button6.Content == "X")
            {
                WhatHow.Text = "Победили КРЕСТИКИ";
            }
            else if (Button7.Content == "X" && Button8.Content == "X" && Button9.Content == "X")
            {
                WhatHow.Text = "Победили КРЕСТИКИ";
            }
            else if (Button1.Content == "X" && Button4.Content == "X" && Button7.Content == "X")
            {
                WhatHow.Text = "Победили КРЕСТИКИ";
            }
            else if (Button2.Content == "X" && Button5.Content == "X" && Button8.Content == "X")
            {
                WhatHow.Text = "Победили КРЕСТИКИ";
            }
            else if (Button3.Content == "X" && Button6.Content == "X" && Button9.Content == "X")
            {
                WhatHow.Text = "Победили КРЕСТИКИ";
            }
            else if (Button1.Content == "X" && Button5.Content == "X" && Button9.Content == "X")
            {
                WhatHow.Text = "Победили КРЕСТИКИ";
            }
            else if (Button3.Content == "X" && Button5.Content == "X" && Button7.Content == "X")
            {
                WhatHow.Text = "Победили КРЕСТИКИ";
            }
            else if (Button1.Content == "O" && Button2.Content == "O" && Button3.Content == "O")
            {
                WhatHow.Text = "Победили Нолики";
            }
            else if (Button4.Content == "O" && Button5.Content == "O" && Button6.Content == "O")
            {
                WhatHow.Text = "Победили Нолики";
            }
            else if (Button7.Content == "O" && Button8.Content == "O" && Button9.Content == "O")
            {
                WhatHow.Text = "Победили Нолики";
            }
            else if (Button1.Content == "O" && Button4.Content == "O" && Button7.Content == "O")
            {
                WhatHow.Text = "Победили Нолики";
            }
            else if (Button2.Content == "O" && Button5.Content == "O" && Button8.Content == "O")
            {
                WhatHow.Text = "Победили Нолики";
            }
            else if (Button3.Content == "O" && Button6.Content == "O" && Button9.Content == "O")
            {
                WhatHow.Text = "Победили Нолики";
            }
            else if (Button1.Content == "O" && Button5.Content == "O" && Button9.Content == "O")
            {
                WhatHow.Text = "Победили Нолики";
            }
            else if (Button3.Content == "O" && Button5.Content == "O" && Button7.Content == "O")
            {
                WhatHow.Text = "Победили Нолики";
            }
            else
            {
                WhatHow.Text = "Никто не победил";
            }
        }
    }
}
