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
    /// Lógica interna para FmTelaAlternativa.xaml
    /// </summary>
    public partial class FmTelaAlternativa : Window
    {
        public FmTelaAlternativa()
        {
            InitializeComponent();
        }

        private void btVoltar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btCadastrar_Click(object sender, RoutedEventArgs e)
        {
            string nome = txtNome.Text;
            string cpf = txtCPF.Text;
            string rg = txtRG.Text;
            string dataNasc = dataNascimento.Text;
            string rua = txtRua.Text;
            string numero = txtNumeroRua.Text;
            string bairro = txtBairro.Text;
            string cidade = txtCidade.Text;
            string uf = txtUF.Text;

            if (nome == "" || cpf == "" || rg == "" || dataNasc == "" || rua == "" || numero == "" || bairro == "" || cidade == "" || uf == "")
                MessageBox.Show("Insira as informações que estão faltando!");
            else
            {
                MessageBox.Show("Cadastro concluído!");
                txtNome.Clear();
                txtCPF.Clear();
                txtRG.Clear();
                txtRua.Clear();
                txtNumeroRua.Clear();
                txtBairro.Clear();
                txtCidade.Clear();
                txtUF.Clear();
            }
        }
    }
}
