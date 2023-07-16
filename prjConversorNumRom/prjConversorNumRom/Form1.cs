using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjConversorNumRom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnApagar_Click(object sender, EventArgs e)
        {
            cbxUnidadeA.Text = "";
            cbxUnidadeB.Text = "";

            txtValorDigitado.Text = "";
            txtValorConvertido.Text = "";
        }

        public static string ParaRomano(int numArabico)
        {            
            if (numArabico < 1) return string.Empty;
            if (numArabico >= 1000) return "M" + ParaRomano(numArabico - 1000);
            if (numArabico >= 900) return "CM" + ParaRomano(numArabico - 900);
            if (numArabico >= 500) return "D" + ParaRomano(numArabico - 500);
            if (numArabico >= 400) return "CD" + ParaRomano(numArabico - 400);
            if (numArabico >= 100) return "C" + ParaRomano(numArabico - 100);
            if (numArabico >= 90) return "XC" + ParaRomano(numArabico - 90);
            if (numArabico >= 50) return "L" + ParaRomano(numArabico - 50);
            if (numArabico >= 40) return "XL" + ParaRomano(numArabico - 40);
            if (numArabico >= 10) return "X" + ParaRomano(numArabico - 10);
            if (numArabico >= 9) return "IX" + ParaRomano(numArabico - 9);
            if (numArabico >= 5) return "V" + ParaRomano(numArabico - 5);
            if (numArabico >= 4) return "IV" + ParaRomano(numArabico - 4);
            if (numArabico >= 1) return "I" + ParaRomano(numArabico - 1);
            throw new Exception("Valor Inválido!");
        }

        private static Dictionary<char, int> MapaRomano = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        public static int ParaArabico(string valRomano)
        {
            int numArabico = 0;
            for (int i = 0; i < valRomano.Length; i++)
            {
                if (i + 1 < valRomano.Length && MapaRomano[valRomano[i]] < MapaRomano[valRomano[i + 1]])
                    numArabico -= MapaRomano[valRomano[i]];              
                else                
                    numArabico += MapaRomano[valRomano[i]];                
            }
            return numArabico;
        }

        private void BtnConveter_Click(object sender, EventArgs e)
        {
            int valArabico;
            string valRomano;

            if (txtValorDigitado.Text != "")
            {
                if (cbxUnidadeA.Text == "Arábico" && int.TryParse(txtValorDigitado.Text, out valArabico) && valArabico < 1)
                {
                    MessageBox.Show("Não digite valores menores que 1!");
                    cbxUnidadeA.Text = "";
                    cbxUnidadeB.Text = "";
                    txtValorDigitado.Text = "";
                    txtValorConvertido.Text = "";
                }
                else if (cbxUnidadeA.Text == "Arábico" && !int.TryParse(txtValorDigitado.Text, out valArabico) && txtValorDigitado.Text != "")
                {
                    MessageBox.Show("Valor Inválido!");
                    cbxUnidadeA.Text = "";
                    cbxUnidadeB.Text = "";
                    txtValorDigitado.Text = "";
                    txtValorConvertido.Text = "";
                    return;
                }
                else if (cbxUnidadeA.Text == "Romano" && int.TryParse(txtValorDigitado.Text, out valArabico))
                {
                    MessageBox.Show("Valor Inválido!");
                    cbxUnidadeA.Text = "";
                    cbxUnidadeB.Text = "";
                    txtValorDigitado.Text = "";
                    txtValorConvertido.Text = "";
                    return;
                }

                else if (cbxUnidadeA.Text == cbxUnidadeB.Text)
                    txtValorConvertido.Text = txtValorDigitado.Text;

                else if (cbxUnidadeA.Text == "Arábico" && cbxUnidadeB.Text == "Romano")
                {
                    valArabico = int.Parse(txtValorDigitado.Text);

                    txtValorConvertido.Text = ParaRomano(valArabico);
                }
                else if (cbxUnidadeA.Text == "Romano" && cbxUnidadeB.Text == "Arábico")
                {
                    valRomano = txtValorDigitado.Text;

                    txtValorConvertido.Text = ParaArabico(valRomano).ToString();
                }

                else
                    txtValorConvertido.Text = "";
            }
        }
    }
}
