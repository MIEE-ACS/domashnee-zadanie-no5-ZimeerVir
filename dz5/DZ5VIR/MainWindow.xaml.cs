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

namespace DZ5VIR
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public class Complex
    {
        public double R;
        public double Im;
        public Complex()
        {
            R = 0;
            Im = 0;

        }
        public void Add(double r,double im)
        {
            R = r;
            Im = im;
        }
    }
    public partial class MainWindow : Window
    {
        int N = 0;
        Complex[] allinfo = new Complex[10];
        public MainWindow()
        {
            InitializeComponent();
            b1.IsEnabled = false;
            b2.IsEnabled = false;
            b3.IsEnabled = false;
            allinfo[0] = new Complex();
            allinfo[1] = new Complex();
            allinfo[2] = new Complex();
            allinfo[3] = new Complex();
            allinfo[4] = new Complex();
            allinfo[5] = new Complex();
            allinfo[6] = new Complex();
            allinfo[7] = new Complex();
            allinfo[8] = new Complex();
            allinfo[9] = new Complex();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                end.Content = "";
                double a = Convert.ToDouble(tb1.Text);
                double b = Convert.ToDouble(tb2.Text);
                allinfo[N].R = a;
                allinfo[N].Im = b;
                info.Text += N + 1 + String.Format(" число: {0} ", allinfo[N].R);
                if (allinfo[N].Im > 0)
                {
                    info.Text += String.Format("+{0} i \n", allinfo[N].Im);
                }
                else
                {
                    info.Text += String.Format(" {0} i \n", allinfo[N].Im);
                }
                N++;
            }
            catch
            {
                end.Content = " Вводите корректные данные";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                end.Content = "";
                int a = Convert.ToInt32(tn1.Text) - 1;
                int b = Convert.ToInt32(tn2.Text) - 1;
                double PR = allinfo[a].R * allinfo[b].R - allinfo[a].Im * allinfo[b].Im;
                double PIm = allinfo[a].R * allinfo[b].R + allinfo[a].Im * allinfo[b].Im;
                end.Content += "Умножение комплексного числа " + String.Format("{0}", allinfo[a].R);
                if (allinfo[a].Im > 0)
                {
                    end.Content += String.Format("+{0} i \n", allinfo[a].Im);
                }
                else
                {
                    end.Content += String.Format(" {0} i \n", allinfo[a].Im);
                }
                end.Content += "на число " + String.Format("{0}", allinfo[b].R);
                if (allinfo[b].Im > 0)
                {
                    end.Content += String.Format("+{0} i ", allinfo[b].Im);
                }
                else
                {
                    end.Content += String.Format(" {0} i ", allinfo[b].Im);
                }
                end.Content += String.Format(" равно {0}", PR);
                if (PIm > 0)
                {
                    end.Content += String.Format("+{0} i \n", PIm);
                }
                else
                {
                    end.Content += String.Format(" {0} i \n", PIm);
                }
            }
            catch
            {

            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                end.Content = "";
                int a = Convert.ToInt32(tn1.Text) - 1;
                int b = Convert.ToInt32(tn2.Text) - 1;
                double SR = allinfo[a].R + allinfo[b].R;
                double SIm = allinfo[a].Im + allinfo[b].Im;
                end.Content += "Сложение комплексного числа " + String.Format("{0}", allinfo[a].R);
                if (allinfo[a].Im > 0)
                {
                    end.Content += String.Format("+{0} i \n", allinfo[a].Im);
                }
                else
                {
                    end.Content += String.Format(" {0} i \n", allinfo[a].Im);
                }
                end.Content += "с числом " + String.Format("{0}", allinfo[b].R);
                if (allinfo[b].Im > 0)
                {
                    end.Content += String.Format("+{0} i ", allinfo[b].Im);
                }
                else
                {
                    end.Content += String.Format(" {0} i ", allinfo[b].Im);
                }
                end.Content += String.Format(" равно {0}", SR);
                if (SIm > 0)
                {
                    end.Content += String.Format("+{0} i \n", SIm);
                }
                else
                {
                    end.Content += String.Format(" {0} i \n", SIm);
                }
            }
            catch
            {

            }

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            try
            {
                end.Content = "";
                int a = Convert.ToInt32(tn1.Text) - 1;
                int b = Convert.ToInt32(tn2.Text) - 1;
                double SR = allinfo[a].R - allinfo[b].R;
                double SIm = allinfo[a].Im - allinfo[b].Im;
                end.Content += "Вычетание комплексного числа " + String.Format("{0}", allinfo[a].R);
                if (allinfo[a].Im > 0)
                {
                    end.Content += String.Format("+{0} i \n", allinfo[a].Im);
                }
                else
                {
                    end.Content += String.Format(" {0} i \n", allinfo[a].Im);
                }
                end.Content += "с числом " + String.Format("{0}", allinfo[b].R);
                if (allinfo[b].Im > 0)
                {
                    end.Content += String.Format("+{0} i ", allinfo[b].Im);
                }
                else
                {
                    end.Content += String.Format(" {0} i ", allinfo[b].Im);
                }
                end.Content += String.Format(" равно {0}", SR);
                if (SIm > 0)
                {
                    end.Content += String.Format("+{0} i \n", SIm);
                }
                else
                {
                    end.Content += String.Format(" {0} i \n", SIm);
                }
            }
            catch
            {
                end.Content = "Вводите корректные данные";
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            info.Text = "";
            for (int i = 0; i < N; i++)
            {

                allinfo[i].R = 0;
                allinfo[i].Im = 0;
            }
            end.Content = "";
            N = 0;
            b1.IsEnabled = false;
            b2.IsEnabled = false;
            b3.IsEnabled = false;
        }

        private void tn1_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(tn1.Text) <= N && Convert.ToInt32(tn1.Text) > 0)
                {
                    b1.IsEnabled = true;
                    b2.IsEnabled = true;
                    b3.IsEnabled = true;
                }
                else
                {
                    b1.IsEnabled = false;
                    b2.IsEnabled = false;
                    b3.IsEnabled = false;
                }
            }
            catch
            {
                b1.IsEnabled = false;
                b2.IsEnabled = false;
                b3.IsEnabled = false;
            }
        }

        private void tn2_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(tn2.Text) <= N && Convert.ToInt32(tn2.Text) > 0)
                {
                    b1.IsEnabled = true;
                    b2.IsEnabled = true;
                    b3.IsEnabled = true;
                }
                else
                {
                    b1.IsEnabled = false;
                    b2.IsEnabled = false;
                    b3.IsEnabled = false;
                }
            }
            catch
            {
                b1.IsEnabled = false;
                b2.IsEnabled = false;
                b3.IsEnabled = false;
            }
        }
    }
}
