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
    public partial class Highscores : Form
    {
        private MenuInicial frm1;
        SQLiteConnection con;
        public Highscores(MenuInicial frm)
        {
            InitializeComponent();
            frm1 = frm;

            try
            {
                con = new SQLiteConnection(@"Data Source=C:\Users\Nuevo Usuario\Desktop\JuegoTrivia\Preguntas.sqlite;Version=3;");
                con.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            String query = "Select * from Jugadores order by Puntaje DESC";
            SQLiteCommand cmd = new SQLiteCommand(query,con);
            SQLiteDataReader dr = cmd.ExecuteReader();
            
            listView1.View = View.Details;
            
            listView1.Columns.Add("Nombre");
            listView1.Columns.Add("Puntaje");

            while (dr.Read())
            {
                var item = new ListViewItem();
                item.SubItems.Add(dr["Puntaje"].ToString());
                item.Text = dr["Nombre"].ToString();
                listView1.Items.Add(item);
            }        
            
            con.Close();
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.None);
            listView1.Columns[0].Width = 267;
            listView1.Columns[1].Width = 267;
        }

        private void Highscores_Load(object sender, EventArgs e)
        {

        }

        private void Volver_Click(object sender, EventArgs e)
        {
            frm1.Show();
            this.Hide();
        }


    }
}
