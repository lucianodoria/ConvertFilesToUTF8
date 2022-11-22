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

namespace ConvertFilesToUTF
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnPasta_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            fbd.SelectedPath = txtPasta.Text;

            if(fbd.ShowDialog() == DialogResult.OK)
            {
                txtPasta.Text = fbd.SelectedPath;
            }
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            string folder = txtPasta.Text;
            btnConverter.Enabled = false;

            try
            {
                File.SetAttributes(folder, FileAttributes.Normal);

                var files = Directory.GetFiles(folder, txtSearchPatern.Text.Trim(), SearchOption.AllDirectories);

                var utf8WithoutBOM = new System.Text.UTF8Encoding(false, true);

                int total = files.Count();
                pgb.Minimum = 0;
                pgb.Maximum = total;
                pgb.Value = 0;

                foreach(var file in files)
                {
                    File.SetAttributes(file, FileAttributes.Normal);
                    
                    var content = File.ReadAllLines(file);

                    System.IO.File.WriteAllLines(file, content, utf8WithoutBOM);

                    pgb.Value += 1;
                    lblpgb.Text = pgb.Value.ToString() + " de " + total.ToString();
                }

                MessageBox.Show("Finalizado!");
            }
            catch(Exception exc)
            {
                MessageBox.Show("Err:" + exc.Message);
            }
            finally
            {
                btnConverter.Enabled = true;
            }
        }

        private void btnCopiarNomeArquivos_Click(object sender, EventArgs e)
        {
            string folder = txtPasta.Text;
            btnCopiarNomeArquivos.Enabled = false;
            string nomesArquivos = "";

            try
            {
                File.SetAttributes(folder, FileAttributes.Normal);

                var files = Directory.GetFiles(folder, txtSearchPatern.Text.Trim(), SearchOption.AllDirectories);

                int total = files.Count();
                pgb.Minimum = 0;
                pgb.Maximum = total;
                pgb.Value = 0;

                foreach (var file in files)
                {
                    nomesArquivos += Path.GetFileName(file) + ";" + Environment.NewLine;

                    pgb.Value += 1;
                    lblpgb.Text = pgb.Value.ToString() + " de " + total.ToString();
                }

                Clipboard.SetText(nomesArquivos);

                MessageBox.Show("Finalizado!");
            }
            catch (Exception exc)
            {
                MessageBox.Show("Err:" + exc.Message);
            }
            finally
            {
                btnCopiarNomeArquivos.Enabled = true;
            }
        }
    }
}
