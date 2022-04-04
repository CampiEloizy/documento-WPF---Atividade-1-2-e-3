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
using DocWpf.Formulários;

namespace DocWpf
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btSair_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btEntrar_Click(object sender, RoutedEventArgs e)
        {
            string usuario = txtEmail.Text;
            string senha = passSenha.Password.ToString();

            if (usuario == "" || senha == "")
            {
                MessageBox.Show("Insira as informações solicitadas!");
            }
            else
            {
                if (usuario == txtEmail.Text || senha == passSenha.Password)
                {
                    MessageBox.Show("Conta Logada!");
                    FmCalcular calculo = new FmCalcular();
                    calculo.ShowDialog();
                }
                else
                    MessageBox.Show("Conta não identificada. Crie seu cadastro para entrar!");
            }  
        }

        private void btCadastro_Click(object sender, RoutedEventArgs e)
        {
            Cadastrar cadastro = new Cadastrar();
            cadastro.ShowDialog();
        }

        private void btDadosPessoais_Click(object sender, RoutedEventArgs e)
        {
            FmTelaAlternativa tela = new FmTelaAlternativa();
            tela.ShowDialog();
        }
    }
}
