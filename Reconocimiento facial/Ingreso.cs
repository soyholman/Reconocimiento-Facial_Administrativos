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
using System.Data.SqlClient;
namespace Reconocimiento_facial
{
    public partial class Ingreso : MetroFramework.Forms.MetroForm
    {
        public Ingreso()
        {
            InitializeComponent();
        }
        SqlConnection c = new SqlConnection(@"Data Source=DESKTOP-M4KLV1U\HOL;Initial Catalog=Faces;Integrated Security=True");
        private string iduser = null;
        private bool editar = false;
        public static string ji;
        private void Ingreso_Load(object sender, EventArgs e)
        {
            mostrar();

      
        }

        public int ho;
        LinqDataDataContext linq = new LinqDataDataContext();
        private void mostrar()
        {


            //var show = (from x in linq.viwe select x ).ToList();

          
            //dataGridView1.DataSource = show;
        }

       


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Hide();

        }

        private void btnagreagar_Click(object sender, EventArgs e)
        {
            

        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
       
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
                   }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            


        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void xuiFormDesign1_WorkingArea_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            new Identification().Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}