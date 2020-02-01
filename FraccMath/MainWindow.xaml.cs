using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using FraccEntities;
using FraccMethod;


namespace FraccMath
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }
        int num1, num2, den1, den2, numres, denres;
        bool homogenea;
        String mensaje = "No se puede hacer operación con campos vacios";
        Method m = new Method();
        Fraccion f1;
        Fraccion f2;
        Fraccion res;

        private Boolean valido(TextBox t1 = null, TextBox t2 = null, TextBox t3 = null, TextBox t4 = null)
        {
            if ((t1.Text.Length == 0) || (t2.Text.Length == 0) || (t3.Text.Length == 0) || (t4.Text.Length == 0))
                return false;
            else
                return true;

        }

        private void validarEntradaNumero(object sender, KeyEventArgs e)
        {
            if (e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            if (valido(txtNumFracUno, txtDenFracUno, txtNumFracDos, txtDenFracDos))
            {
                num1 = int.Parse(txtNumFracUno.Text.ToString());
                den1 = int.Parse(txtDenFracUno.Text.ToString());
                num2 = int.Parse(txtNumFracDos.Text.ToString());
                den2 = int.Parse(txtDenFracDos.Text.ToString());
                f1 = new Fraccion { Numerador = num1, Denominador = den1 };
                f2 = new Fraccion { Numerador = num2, Denominador = den2 };
                res = m.Resta(f1, f2);
                numres = res.Numerador;
                denres = res.Denominador;
                txtNumFracRes.Text = numres.ToString();
                txtDenFracRes.Text = denres.ToString();
            }
            else
            {
                MessageBox.Show(mensaje);
            }


        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            if (valido(txtNumFracUno, txtDenFracUno, txtNumFracDos, txtDenFracDos))
            {
                num1 = int.Parse(txtNumFracUno.Text.ToString());
                den1 = int.Parse(txtDenFracUno.Text.ToString());
                num2 = int.Parse(txtNumFracDos.Text.ToString());
                den2 = int.Parse(txtDenFracDos.Text.ToString());
                f1 = new Fraccion { Numerador = num1, Denominador = den1 };
                f2 = new Fraccion { Numerador = num2, Denominador = den2 };
                homogenea = m.EsHomogenea(f1, f2);
                MessageBox.Show(homogenea ? "Homogenea" : "Heterogenea");
            }
            else
            {
                MessageBox.Show(mensaje);
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (valido(txtNumFracUno, txtDenFracUno, txtNumFracDos, txtDenFracDos))
            {
                num1 = int.Parse(txtNumFracUno.Text.ToString());
                den1 = int.Parse(txtDenFracUno.Text.ToString());
                num2 = int.Parse(txtNumFracDos.Text.ToString());
                den2 = int.Parse(txtDenFracDos.Text.ToString());
                f1 = new Fraccion { Numerador = num1, Denominador = den1 };
                f2 = new Fraccion { Numerador = num2, Denominador = den2 };
                res = m.Division(f1, f2);
                numres = res.Numerador;
                denres = res.Denominador;
                txtNumFracRes.Text = numres.ToString();
                txtDenFracRes.Text = denres.ToString();
            }
            else
            {
                MessageBox.Show(mensaje);
            }

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (valido(txtNumFracUno, txtDenFracUno, txtNumFracDos, txtDenFracDos))
            {
                num1 = int.Parse(txtNumFracUno.Text.ToString());
                den1 = int.Parse(txtDenFracUno.Text.ToString());
                num2 = int.Parse(txtNumFracDos.Text.ToString());
                den2 = int.Parse(txtDenFracDos.Text.ToString());
                f1 = new Fraccion { Numerador = num1, Denominador = den1 };
                f2 = new Fraccion { Numerador = num2, Denominador = den2 };
                res = m.Multiplicacion(f1, f2);
                numres = res.Numerador;
                denres = res.Denominador;
                txtNumFracRes.Text = numres.ToString();
                txtDenFracRes.Text = denres.ToString();
            }
            else
            {
                MessageBox.Show(mensaje);
            }

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (txtNumFracUno.Text.Length != 0 && txtDenFracUno.Text.Length != 0)
            {
                if (txtNumFracDos.Text.Length == 0 && txtDenFracDos.Text.Length == 0)
                {
                    MessageBox.Show("Entro en Fraccion 1");
                    num1 = int.Parse(txtNumFracUno.Text.ToString());
                    den1 = int.Parse(txtDenFracUno.Text.ToString());
                    f1 = new Fraccion { Numerador = num1, Denominador = den1 };
                    MessageBox.Show(m.Valor(f1).ToString());
                }
                else
                {
                    MessageBox.Show("Solo se puede calcular una a la vez");
                }
            }
            else if (txtNumFracDos.Text.Length != 0 && txtDenFracDos.Text.Length != 0)
            {
                if (txtNumFracUno.Text.Length == 0 && txtDenFracUno.Text.Length == 0)
                {
                    MessageBox.Show("Entro en Fraccion 2");
                    num2 = int.Parse(txtNumFracDos.Text.ToString());
                    den2 = int.Parse(txtDenFracDos.Text.ToString());
                    f2 = new Fraccion { Numerador = num2, Denominador = den2 };
                    MessageBox.Show(m.Valor(f2).ToString());
                }
                else
                {
                    MessageBox.Show("Solo  se puede calcular una a la vez");
                }

            }
            else
            {
                MessageBox.Show("Se necesita al menos una fraccion para hallar el valor");
            }
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            this.Close();

        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            SolidColorBrush bckg = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#585858"));
            this.cerrar.Background = bckg;
        }

        private void resize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Maximized;
        }

        private void minimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (valido(txtNumFracUno, txtDenFracUno, txtNumFracDos, txtDenFracDos))
            {
                num1 = int.Parse(txtNumFracUno.Text.ToString());
                den1 = int.Parse(txtDenFracUno.Text.ToString());
                num2 = int.Parse(txtNumFracDos.Text.ToString());
                den2 = int.Parse(txtDenFracDos.Text.ToString());
                f1 = new Fraccion { Numerador = num1, Denominador = den1 };
                f2 = new Fraccion { Numerador = num2, Denominador = den2 };
                res = m.Suma(f1, f2);
                numres = res.Numerador;
                denres = res.Denominador;
                txtNumFracRes.Text = numres.ToString();
                txtDenFracRes.Text = denres.ToString();
            }
            else
            {
                MessageBox.Show(mensaje);
            }

        }
    }
}
