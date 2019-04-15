using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoTrivia
{
    public partial class MenuInicial : Form
    {
        public MenuInicial()
        {
            InitializeComponent();
        }

        private void Jugar_Click(object sender, EventArgs e)
        {
            IngresoNombre frm = new IngresoNombre(this);

            this.Hide();
            frm.Show();
        }

        private void Highscores_Click(object sender, EventArgs e)
        {
            Highscores frm = new Highscores(this);
            this.Hide();
            frm.Show();
        }
        private void Salir_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("¿Está seguro de que desea salir?", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                Application.ExitThread();
            }

        }
        private void MenuInicial_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Está seguro de que desea salir?", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Cancel)
            {
                e.Cancel = true;
            }

        }

        private void MenuInicial_Load(object sender, EventArgs e)
        {

        }

    }
}
