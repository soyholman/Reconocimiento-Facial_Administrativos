using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace Reconocimiento_facial
{
    public partial class Menu : MetroFramework.Forms.MetroForm
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            this.Hide();
        }


        private void xuiFormDesign1_WorkingArea_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
       
            this.Hide();


        }

        public void llenardatos()
        {







        }



        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //new Categoria().Show();
            //this.Hide();
       
        }
        OleDbConnection c = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = Faces.mdb");
        public DateTime datefinal;
        public int holi;
      
        private void button3_Click(object sender, EventArgs e)
        {
            
      
        }

        Ingreso ink= new Ingreso();
        private void Menu_Load(object sender, EventArgs e)
        {
          
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

           

        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Identification().Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {

            new IA().Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btnDocentes_Click(object sender, EventArgs e)
        {
            new Docente().Show();
            this.Hide();

        }

        private void buttoback_Click_1(object sender, EventArgs e)
        {
            new Identification().Show();
            this.Hide();
        }

        private void btnreportes_Click(object sender, EventArgs e)
        {
            new Reportes().Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new Asistencias().Show();
            this.Hide();
        }
    }
}
