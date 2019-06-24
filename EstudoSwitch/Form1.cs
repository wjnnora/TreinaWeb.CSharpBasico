using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstudoSwitch
{
    public partial class fmrSwitch : Form
    {
        public fmrSwitch()
        {
            InitializeComponent();
        }

        private void BtnVerificar_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(txbNumero.Text);
            // 0 - 3: número baixo
            // 4 - 6: número médio
            // 7 - 10: número alto
            /*if ((numero >= 0) && (numero <= 3))
                MessageBox.Show("Número baixo.");
            else if ((numero >= 4) && (numero <= 6))
                MessageBox.Show("Número médio.");
            else
                MessageBox.Show("Número alto.");*/
            switch (numero)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                    MessageBox.Show("Número baixo.");
                    break;
                case 4:
                case 5:
                case 6:
                    MessageBox.Show("Número médio.");
                    break;
                case 7:
                case 8:
                case 9:
                case 10:
                    MessageBox.Show("Número alto.");
                    break;
                default:
                    MessageBox.Show("Número fora do intervalo.");
                    break;


            }
                 

        }
    }
}
