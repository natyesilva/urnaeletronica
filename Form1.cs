using System.Windows.Forms;
using System.Text;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace UrnaEletronica
{
    public partial class Urna : Form
    {
        public string numero = "";
        StreamWriter resultado;
        string data;
        string nomeArquivo;
        string path = Directory.GetCurrentDirectory();
        int total, candidato1, candidato2, candidato3 = 0;

        public Urna()
        {
            InitializeComponent();

            data = DateTime.Now.ToString().Replace("/", "-").Replace(":", ".");
            nomeArquivo = "Resultado Votação " + data + ".txt";
            
            if (!Directory.Exists(path+@"\Resultado"))
            {
                Directory.CreateDirectory(path + @"\Resultado");
            }

            numero.Trim();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numero = numero + "2";
            verifica(numero);

           
        }

        private void button10_Click(object sender, EventArgs e)
        {
            numero = numero + "0";
            verifica(numero);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numero = numero + "1";
            verifica(numero);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            numero = numero + "3";
            verifica(numero);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            numero = numero + "4";
            verifica(numero);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            numero = numero + "5";
            verifica(numero);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            numero = numero + "6";
            verifica(numero);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            numero = numero + "7";
            verifica(numero);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            numero = numero + "8";
            verifica(numero);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            numero = numero + "9";
            verifica(numero);
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            numero = "";
            verifica(numero);
        }

        private void btnCorrige_Click(object sender, EventArgs e)
        {
            numero = "";
            verifica(numero);
        }

        private void btnFim_Click(object sender, EventArgs e)
        {

            resultado.WriteLine("O Total de votos foram:" + total.ToString());
            resultado.WriteLine("Dilma :" + candidato1.ToString() + "votos" + "(" + ((100 * candidato1) / 100).ToString() + "%)");
            resultado.WriteLine("Bolsonaro :" + candidato2.ToString() + "votos" + "(" + ((100 * candidato2) / 100).ToString() + "%)");
            resultado.WriteLine("Dilma :" + candidato3.ToString() + "votos" + "(" + ((100 * candidato3) / 100).ToString() + "%)");

            MessageBox.Show("Finalizado com sucesso");

        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            resultado = new StreamWriter(path + @"\Resultado\" + nomeArquivo, true);
            resultado.WriteLine("voto no candidato:  " + numero);
            canditato.Text = "";
            nome.Text = "";
            total += 1;



        }
        private void verifica(string numero)
        {
            if (numero.Length == 2)
            {
                dados(numero);
                canditato.Text = numero;
            }
            
            
        }
        private void dados(string numero)
        {
           switch(numero)
           {
                case "13":
                    nome.Text = "Dilma";
                    fotocandidato.ImageLocation = @"Foto\dilma.jpg";
                    candidato1 += 1;
                    break;
                case "22":
                    nome.Text = "Bolsonaro";
                    fotocandidato.ImageLocation = @"Foto\bolsonaro.jpg";
                    candidato2 += 1;
                    break;
                case "55":
                    nome.Text = "Aecio";
                    fotocandidato.ImageLocation = @"Foto\aecio.jpg";
                    candidato3+= 1;
                    break;


            }
        }

       
    }
}