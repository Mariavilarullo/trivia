using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace JuegoTrivia
{
    public partial class IngresoNombre : Form
    {
        public MenuInicial frm1;
        public SQLiteConnection con;
        public Jugador gamer;

        public IngresoNombre(MenuInicial frm)
        {
            InitializeComponent();
            frm1 = frm;
        }


        private void IngresoNombre_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm1 = (MenuInicial)this.Owner;
            gamer = new Jugador(textbox1.Text);
            Juego frm4 = new Juego(this);
            this.Hide();
            frm4.Show();
        }
        public void guardarJugador()
        {
            try
            {
                con = new SQLiteConnection(@"Data Source=C:\Users\Nuevo Usuario\Desktop\JuegoTrivia\Preguntas.sqlite;Version=3;");
                con.Open();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            String query = "Insert into Jugadores(Nombre, Puntaje) values('"+gamer.Nombre.ToString()+"','"+ gamer.Puntaje.ToString()+"')";
            SQLiteCommand com = new SQLiteCommand(query, con);
            com.ExecuteNonQuery();
            com.Dispose();
            con.Close();
        }
        private void IngresoNombre_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Está seguro de que desea salir?", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            
            if (dialogResult == DialogResult.Cancel)
            {
                e.Cancel = true;
            }

        }
    
    }
}
