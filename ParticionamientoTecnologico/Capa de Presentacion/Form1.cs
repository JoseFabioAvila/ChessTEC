using ChessTEC.ParticionamientoTecnologico.Capa_de_Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessTEC
{
    public partial class Form1 : Form
    {
        PictureBox[][] matrizBotones;
        Tablero tablero;
        
        public Form1()
        {
            InitializeComponent();
            tablero = new Tablero();
            cargarBotones();
            updateTablero();
        }

        public void cargarBotones()
        {
            matrizBotones = new PictureBox[8][];
            for (int i = 0; i < matrizBotones.Length; i++)
            {
                matrizBotones[i] = new PictureBox[8];
            }

            matrizBotones[0][0] = p1A;
            matrizBotones[0][1] = p1B;
            matrizBotones[0][2] = p1C;
            matrizBotones[0][3] = p1D;
            matrizBotones[0][4] = p1E;
            matrizBotones[0][5] = p1F;
            matrizBotones[0][6] = p1G;
            matrizBotones[0][7] = p1H;

            matrizBotones[1][0] = p2A;
            matrizBotones[1][1] = p2B;
            matrizBotones[1][2] = p2C;
            matrizBotones[1][3] = p2D;
            matrizBotones[1][4] = p2E;
            matrizBotones[1][5] = p2F;
            matrizBotones[1][6] = p2G;
            matrizBotones[1][7] = p2H;

            matrizBotones[2][0] = p3A;
            matrizBotones[2][1] = p3B;
            matrizBotones[2][2] = p3C;
            matrizBotones[2][3] = p3D;
            matrizBotones[2][4] = p3E;
            matrizBotones[2][5] = p3F;
            matrizBotones[2][6] = p3G;
            matrizBotones[2][7] = p3H;

            matrizBotones[3][0] = p4A;
            matrizBotones[3][1] = p4B;
            matrizBotones[3][2] = p4C;
            matrizBotones[3][3] = p4D;
            matrizBotones[3][4] = p4E;
            matrizBotones[3][5] = p4F;
            matrizBotones[3][6] = p4G;
            matrizBotones[3][7] = p4H;
            
            matrizBotones[4][0] = p5A;
            matrizBotones[4][1] = p5B;
            matrizBotones[4][2] = p5C;
            matrizBotones[4][3] = p5D;
            matrizBotones[4][4] = p5E;
            matrizBotones[4][5] = p5F;
            matrizBotones[4][6] = p5G;
            matrizBotones[4][7] = p5H;

            matrizBotones[5][0] = p6A;
            matrizBotones[5][1] = p6B;
            matrizBotones[5][2] = p6C;
            matrizBotones[5][3] = p6D;
            matrizBotones[5][4] = p6E;
            matrizBotones[5][5] = p6F;
            matrizBotones[5][6] = p6G;
            matrizBotones[5][7] = p6H;

            matrizBotones[6][0] = p7A;
            matrizBotones[6][1] = p7B;
            matrizBotones[6][2] = p7C;
            matrizBotones[6][3] = p7D;
            matrizBotones[6][4] = p7E;
            matrizBotones[6][5] = p7F;
            matrizBotones[6][6] = p7G;
            matrizBotones[6][7] = p7H;

            matrizBotones[7][0] = p8A;
            matrizBotones[7][1] = p8B;
            matrizBotones[7][2] = p8C;
            matrizBotones[7][3] = p8D;
            matrizBotones[7][4] = p8E;
            matrizBotones[7][5] = p8F;
            matrizBotones[7][6] = p8G;
            matrizBotones[7][7] = p8H;            
        }

        private void updateTablero()
        {
            for (int i = 0; i < tablero.matrizTablero.Length; i++)
            {
                for (int j = 0; j < tablero.matrizTablero[i].Length; j++)
                {
                    if (tablero.matrizTablero[i][j] != null)
                    {
                        //Console.WriteLine(tablero.matrizTablero[i][j].imagen);
                        matrizBotones[i][j].ImageLocation = tablero.matrizTablero[i][j].imagen;

                    }
                }
            }
        }

        private void p1A_Click(object sender, EventArgs e)
        {
            turno.Text = p1A.Name;
        }

        private void p1B_Click(object sender, EventArgs e)
        {
            turno.Text = p1B.Name;
        }

        private void p1C_Click(object sender, EventArgs e)
        {
            turno.Text = p1C.Name;
        }

        private void p1D_Click(object sender, EventArgs e)
        {
            turno.Text = p1D.Name;
        }

        private void p1E_Click(object sender, EventArgs e)
        {
            turno.Text = p1E.Name;
        }

        private void p1F_Click(object sender, EventArgs e)
        {
            turno.Text = p1F.Name;
        }

        private void p1G_Click(object sender, EventArgs e)
        {
            turno.Text = p1G.Name;
        }

        private void p1H_Click(object sender, EventArgs e)
        {
            turno.Text = p1H.Name;
        }

        private void p2A_Click(object sender, EventArgs e)
        {

        }

        private void p2B_Click(object sender, EventArgs e)
        {

        }

        private void p2C_Click(object sender, EventArgs e)
        {

        }

        private void p2D_Click(object sender, EventArgs e)
        {

        }

        private void p2E_Click(object sender, EventArgs e)
        {

        }

        private void p2F_Click(object sender, EventArgs e)
        {

        }

        private void p2G_Click(object sender, EventArgs e)
        {

        }

        private void p2H_Click(object sender, EventArgs e)
        {

        }

        private void p3H_Click(object sender, EventArgs e)
        {

        }

        private void p3G_Click(object sender, EventArgs e)
        {

        }

        private void p3F_Click(object sender, EventArgs e)
        {

        }

        private void p3E_Click(object sender, EventArgs e)
        {

        }

        private void p3D_Click(object sender, EventArgs e)
        {

        }

        private void p3C_Click(object sender, EventArgs e)
        {

        }

        private void p3B_Click(object sender, EventArgs e)
        {

        }

        private void p3A_Click(object sender, EventArgs e)
        {

        }

        private void p4A_Click(object sender, EventArgs e)
        {

        }

        private void p4B_Click(object sender, EventArgs e)
        {

        }

        private void p4C_Click(object sender, EventArgs e)
        {

        }

        private void p4D_Click(object sender, EventArgs e)
        {

        }

        private void p4E_Click(object sender, EventArgs e)
        {

        }

        private void p4F_Click(object sender, EventArgs e)
        {

        }

        private void p4G_Click(object sender, EventArgs e)
        {

        }

        private void p4H_Click(object sender, EventArgs e)
        {

        }

        private void p5H_Click(object sender, EventArgs e)
        {

        }

        private void p5G_Click(object sender, EventArgs e)
        {

        }

        private void p5F_Click(object sender, EventArgs e)
        {

        }

        private void p5E_Click(object sender, EventArgs e)
        {

        }

        private void p5D_Click(object sender, EventArgs e)
        {

        }

        private void p5C_Click(object sender, EventArgs e)
        {

        }

        private void p5B_Click(object sender, EventArgs e)
        {

        }

        private void p5A_Click(object sender, EventArgs e)
        {

        }

        private void p6A_Click(object sender, EventArgs e)
        {

        }

        private void p6B_Click(object sender, EventArgs e)
        {

        }

        private void p6C_Click(object sender, EventArgs e)
        {

        }

        private void p6D_Click(object sender, EventArgs e)
        {

        }

        private void p6E_Click(object sender, EventArgs e)
        {

        }

        private void p6F_Click(object sender, EventArgs e)
        {

        }

        private void p6G_Click(object sender, EventArgs e)
        {

        }

        private void p6H_Click(object sender, EventArgs e)
        {

        }

        private void p7H_Click(object sender, EventArgs e)
        {

        }

        private void p7G_Click(object sender, EventArgs e)
        {

        }

        private void p7F_Click(object sender, EventArgs e)
        {

        }

        private void p7E_Click(object sender, EventArgs e)
        {

        }

        private void p7D_Click(object sender, EventArgs e)
        {

        }

        private void p7C_Click(object sender, EventArgs e)
        {

        }

        private void p7B_Click(object sender, EventArgs e)
        {

        }

        private void p7A_Click(object sender, EventArgs e)
        {

        }

        private void p8A_Click(object sender, EventArgs e)
        {

        }

        private void p8B_Click(object sender, EventArgs e)
        {

        }

        private void p8C_Click(object sender, EventArgs e)
        {

        }

        private void p8D_Click(object sender, EventArgs e)
        {

        }

        private void p8E_Click(object sender, EventArgs e)
        {

        }

        private void p8F_Click(object sender, EventArgs e)
        {

        }

        private void p8G_Click(object sender, EventArgs e)
        {

        }

        private void p8H_Click(object sender, EventArgs e)
        {

        }
    }
}
