using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_média
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esse aplicativo foi feito para reduzir seu tempo perdendo tempo calculando merda de nota de aluno chato que fica enchendo seu saco durante o ano todo e quando chega no final começa a ser bonzinho pra no próximo ano voltar a ser um porre.", "Olá!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Calcula média do aluno baseado em 3 notas
            double n1, n2, n3, media;
            n1 = Convert.ToDouble(txtNota1.Text); //linha correspondente à primeira nota
            n2 = Convert.ToDouble(txtNota2.Text); //linha correspondente à segunda nota
            n3 = Convert.ToDouble(txtNota3.Text); //linha correspondente à terceira nota
            media = (n1 + n2 + n3) / 3; //calculo da média
            txtMedia.Text = media.ToString();

            if (media < 5)
                MessageBox.Show("A Peste Reprovou!!", "TOOMA!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (media >= 7)
                MessageBox.Show("Aluno Aprovado!", "Parabéns  para ele", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                MessageBox.Show("Aluno em recuperação", "OPA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNota1.Text = "";
            txtNota2.Text = "";
            txtNota3.Text = "";
            txtMedia.Text = "";

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
