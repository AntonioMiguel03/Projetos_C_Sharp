using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangulos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TxtLadoA_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Verificar se o numero e real
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != '.') && (e.KeyChar != '-');
        }

        private void TxtLadoB_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Verificar se o numero e real
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != '.') && (e.KeyChar != '-');
        }

        private void TxtLadoC_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Verificar se o numero e real
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != '.') && (e.KeyChar != '-');
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (txtLadoA.Text == "" || txtLadoB.Text == "" || txtLadoC.Text == "")
                MessageBox.Show("Um ou mais campos estão vazios!!!", "Espaços Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else
            {
                double ladoA, ladoB, ladoC;

                ladoA = double.Parse(txtLadoA.Text);
                ladoB = double.Parse(txtLadoB.Text);
                ladoC = double.Parse(txtLadoC.Text);

                if ((Math.Abs(ladoB - ladoC) < ladoA && ladoA < (ladoB + ladoC)) && (Math.Abs(ladoA - ladoC) < ladoB && ladoB < (ladoA + ladoC)) && (Math.Abs(ladoA - ladoB) < ladoC && ladoC < (ladoA + ladoB)))
                {
                    if ((ladoA == ladoB) && (ladoB == ladoC) && (ladoA == ladoC))
                        txtResultado.Text = "Triângulo Equilátero";
                    else if ((ladoA == ladoB) && (ladoB != ladoC) && (ladoA != ladoC))
                        txtResultado.Text = "Triângulo Isóceles";
                    else if ((ladoA != ladoB) && (ladoB == ladoC) && (ladoA != ladoC))
                        txtResultado.Text = "Triângulo Isóceles";
                    else if ((ladoA != ladoB) && (ladoB != ladoC) && (ladoA == ladoC))
                        txtResultado.Text = "Triângulo Isóceles";
                    else
                        txtResultado.Text = "Triângulo Escaleno";
                }
                else
                    MessageBox.Show("Os valores digitados não formam um triângulo!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtLadoA.Text = "";
            txtLadoB.Text = "";
            txtLadoC.Text = "";
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("Deseja realmente sair deste programa?", "Sair do Programa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogo == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
