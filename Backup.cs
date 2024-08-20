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

namespace ManipulacaoArquivos
{
    public partial class Backup : Form
    {
        public Backup()
        {
            InitializeComponent();
        }

        string pastaDestino;

        List<string> listaArquivos = new List<string>();

        private void btnSelecionar01_Click(object sender, EventArgs e)
        {

            //componente pra selecionar os arquivos
            var OpenFileDialog = new OpenFileDialog();

            OpenFileDialog.Title = "Selecione os arquivos";

            //permite que selecione qualquer tipo de arquivo
            OpenFileDialog.Filter = "Todos (*.*) | *.*";


            if(OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                listaArquivos.Clear();

                //adiciona os arquivos selecionados na lista
                listaArquivos.AddRange(OpenFileDialog.FileNames);

                //exibe uma mensagem com o numero de arquivos selecionados
                MessageBox.Show($"total de {listaArquivos.Count} arquivos selecionados.");

                //coloca o nome do arquivo escolhido
                tbOrigem.Text = Path.GetFileName(OpenFileDialog.FileName);

            }

        }

        private void btnSelecionar02_Click(object sender, EventArgs e)
        {
            //cria componente para selecionar a pasta de destino dos arquivos
            var folderBrowserDialog = new FolderBrowserDialog();

            folderBrowserDialog.Description = "Selecione a pasta de destino";

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK )
            {
                pastaDestino = folderBrowserDialog.SelectedPath;
                tbDestino.Text = pastaDestino;
            }
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            try{

                //percorre a lista de arquivos
                foreach(var file in listaArquivos)
                {
                    //monta o nome do arquivo
                    var fileName = Path.GetFileName(file);
                    var destFile = Path.Combine(pastaDestino, fileName);

                    //copia cada arquivo
                    File.Copy(file, destFile, true);
                }

                MessageBox.Show("Arquivos copiados com sucesso");

            }
            catch (Exception ex ) 
            {
                MessageBox.Show($"Aconteceu o seguinte erro: {ex.Message}");
            }
        }
    }
}
