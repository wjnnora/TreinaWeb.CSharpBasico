using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstudoEnums
{
    public partial class frmEnums : Form
    {
        public frmEnums()
        {
            InitializeComponent();
        }

        private void FrmEnums_Load(object sender, EventArgs e)
        {
            cmbDias.DataSource = Enum.GetValues(typeof(dias));
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dia Escolhido: " + Enum.GetName(typeof(dias), cmbDias.SelectedIndex));
        }
    }
}
