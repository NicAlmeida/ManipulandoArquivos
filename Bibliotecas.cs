using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViaCep;

namespace ManipulacaoArquivos
{
    public partial class Bibliotecas : Form
    {
        public Bibliotecas()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            var result = new ViaCepClient().Search(txtCEP.Text);

            txtRua.Text = result.Street;
            txtBairro.Text = result.Neighborhood;
            txtCidade.Text = result.City;
            txtUF.Text = result.StateInitials;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            string caminhoArquivo = @"D:\nicolly\";


            string nome, email, cpf, telefone, celular;
            string cep, rua, bairro, complemento, numero, cidade, uf;


            nome = txtNome.Text;
            email = txtEmail.Text;
            cpf = txtCPF.Text;
            telefone = txtTelefone.Text;
            celular = txtCelular.Text;

            cep = txtCEP.Text;
            rua = txtRua.Text;
            bairro = txtBairro.Text;
            complemento = txtComp.Text;
            numero = txtNumero.Text;
            cidade = txtCidade.Text;
            uf = txtUF.Text;


            string conteudoArquivo =
            "===================================\n" +
            $"Nome: {nome} \n " +
            $"Email: {email} \n" +
            $"Cpf: {cpf}\n" +
            $"Telefone: {telefone}\n" +
            $"Celular: {celular} \n" +
            $"Cep: {cep} \n" +
            $"Rua: {rua}\n" +
            $"Bairro: {bairro} \n" +
            $"Complemento: {complemento} \n" +
            $"Número: {numero} \n" +
            $"Cidade: {cidade} \n" +
            $"Uf: {uf} \n" +
            "==================================";



            try
            {
                //grava o conteúdo no arquivo
                File.AppendAllText(caminhoArquivo, conteudoArquivo + Environment.NewLine);

                MessageBox.Show("Dados salvos com sucesso no arquivo. ");

                txtNome.Clear();
                txtEmail.Clear();
                txtCPF.Clear();
                txtTelefone.Clear();
                txtCelular.Clear();
                txtCEP.Clear();
                txtRua.Clear();
                txtBairro.Clear();
                txtComp.Clear();
                txtNumero.Clear();
                txtCidade.Clear();
                txtUF.Clear();
            }
            catch (Exception erro) 
            {
                MessageBox.Show("Erro ao salvar dados ."  + erro);

            }
        }
    }
}
