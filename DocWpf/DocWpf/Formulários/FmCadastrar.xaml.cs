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

namespace DocWpf.Formulários
{
    /// <summary>
    /// Lógica interna para Cadastrar.xaml
    /// </summary>
    public partial class Cadastrar : Window
    {
        public Cadastrar()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        { 
            string usuario = txtNome.Text;
            string email = txtEmail.Text;
            string senha = passSenha.Password.ToString();
            string confirmacaoSenha = passConfirmacaoSenha.Password.ToString();

            if (usuario == "" || email == "" || senha == "" || confirmacaoSenha == "")
            {
                MessageBox.Show("Insira as informações socilitadas!");
            }
            else
            {
                if (confirmacaoSenha == senha)
                {
                    MessageBox.Show("Conta Logada!");
                    txtNome.Clear();
                    txtEmail.Clear();
                    passSenha.Clear();
                    passConfirmacaoSenha.Clear();
                }
                else
                {
                    MessageBox.Show("Senha incorreta!");
                    passSenha.Clear();
                    passConfirmacaoSenha.Clear();
                }
            }
        }

        private void btSair_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
