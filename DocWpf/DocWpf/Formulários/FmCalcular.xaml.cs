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
using System.Windows.Shapes;
using DocWpf.Formulários;

namespace DocWpf.Formulários
{
    /// <summary>
    /// Lógica interna para FmCalcular.xaml
    /// </summary>
    public partial class FmCalcular : Window
    {
        public FmCalcular()
        {
            InitializeComponent();
        }

        private void btVoltar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btSoma_Click(object sender, RoutedEventArgs e)
        {
            float valor = Convert.ToSingle(valor1.Text);
            float valorr = Convert.ToSingle(valor2.Text);

            float result = valor + valorr;

            resultado.Text = Convert.ToString(result);
        }

        private void btSubtracao_Click(object sender, RoutedEventArgs e)
        {
            float valor = Convert.ToSingle(valor1.Text);
            float valorr = Convert.ToSingle(valor2.Text);

            float result = valor - valorr;

            resultado.Text = Convert.ToString(result);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            float valor = Convert.ToSingle(valor1.Text);
            float valorr = Convert.ToSingle(valor2.Text);

            float result = valor * valorr;

            resultado.Text = Convert.ToString(result);
        }

        private void btDivisao_Click(object sender, RoutedEventArgs e)
        {
            float valor = Convert.ToSingle(valor1.Text);
            float valorr = Convert.ToSingle(valor2.Text);

            float result = valor / valorr;

            resultado.Text = Convert.ToString(result);
        }
    }
}
