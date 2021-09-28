using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reconocimiento_facial
{
    public partial class Docente : MetroFramework.Forms.MetroForm
    {
        public Docente()
        {
            InitializeComponent();
        }
        LinqDataDataContext data = new LinqDataDataContext();
        private void Docente_Load(object sender, EventArgs e)
        {
          
            // TODO: esta línea de código carga datos en la tabla 'dataSetConjunt.Docentes' Puede moverla o quitarla según sea necesario.
       


                this.docentesTableAdapter.Fill(this.dataSetConjunt.Docentes);


           
          


            btneditar.Enabled = false;
            btncancelar.Enabled = false;
            btneliminar.Enabled = false;



        }


        void show()
        {
            if (txtsearch.Text.Trim() == null)
            {



                this.docentesTableAdapter.Fill(this.dataSetConjunt.Docentes);


            }

            else
            {

                this.searchdocenteTableAdapter.Fill(this.dataSetConjunt.searchdocente, txtsearch.Text);
                datalist.DataSource = DataSearch;
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            new Menu().Show();

        }




        void Delete()
        {
            try
            {

                string SqlString = "delete Docentes where id_docente= @id_docente";

                using (SqlConnection conn = new SqlConnection((ConfigurationManager.ConnectionStrings["Reconocimiento_facial.Properties.Settings.FacesConnectionString"].ConnectionString)))
                {
                    using (SqlCommand cmd = new SqlCommand(SqlString, conn))
                    {
                        cmd.CommandType = CommandType.Text;
           

                        cmd.Parameters.AddWithValue("@id_docente", int.Parse(lblid.Text.ToString()));

                        conn.Open();
                        cmd.ExecuteNonQuery();

                        txtidentificador.Text = txtnombre.Text = "";

                        MessageBox.Show("Se Elimino Correctamente el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        show();
                    }


                }



            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }


        }

        void update()
        {

            try
            {

                string SqlString = "Update Docentes set  Nombre= @Nombre , identificador=@identificador where id_docente= @id_docente";

                using (SqlConnection conn = new SqlConnection((ConfigurationManager.ConnectionStrings["Reconocimiento_facial.Properties.Settings.FacesConnectionString"].ConnectionString)))
                {
                    using (SqlCommand cmd = new SqlCommand(SqlString, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@Nombre", txtnombre.Text.ToString());
                        cmd.Parameters.AddWithValue("@identificador", txtidentificador.Text.ToString());

                        cmd.Parameters.AddWithValue("@id_docente", int.Parse(lblid.Text.ToString()));

                        conn.Open();
                        cmd.ExecuteNonQuery();



                        MessageBox.Show("Se Editado Correctamente el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        show();


                    }


                }



            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message,"",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {

                string SqlString = "Insert Into Docentes (Nombre , Identificador) Values (@nombre,@identificador)";

                using (SqlConnection conn = new SqlConnection((ConfigurationManager.ConnectionStrings["Reconocimiento_facial.Properties.Settings.FacesConnectionString"].ConnectionString)))
                {
                    using (SqlCommand cmd = new SqlCommand(SqlString, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@nombre", txtnombre.Text.ToString());
                        cmd.Parameters.AddWithValue("@identificador",txtidentificador.Text.ToString());

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Se inserto correctamente el registro","", MessageBoxButtons.OK,MessageBoxIcon.Information);
                        txtidentificador.Text = "";
                       txtnombre.Text ="";
                    }

                }
                show();


            }
            catch (Exception Ex)
            {


                MessageBox.Show(Ex.Message);
            }



        }

        private void btneditar_Click(object sender, EventArgs e)
        {

            DialogResult Dialog = MessageBox.Show("Desea Editar este Usuario?", "Editar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (Dialog.Equals(DialogResult.OK))
            {
                update();

                btneliminar.Enabled = btneditar.Enabled = false;
                btnguardar.Enabled = true;

                txtidentificador.Text = txtnombre.Text = "";

                btncancelar.Enabled = false;
            }

            else
            {

                btncancelar.Enabled = false;

                show();

                btneliminar.Enabled = btneditar.Enabled = false;
                btnguardar.Enabled = true;

                txtidentificador.Text = txtnombre.Text = "";

            }
                    
                    
                    
                   
           
        }

        private void datalist_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

           
        }

        private void datalist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnguardar.Enabled = false;
            try
            {

                if (datalist != null)
                {

                    foreach(DataGridViewCell cell in datalist.Rows[0].Cells)
                    {
                        if (cell.Value != null)
                        {

                           lblid.Text = datalist.CurrentRow.Cells[0].Value.ToString();
                        txtnombre.Text = (string)datalist.CurrentRow.Cells[1].Value.ToString();
                 txtidentificador.Text = (string)datalist.CurrentRow.Cells[2].Value.ToString() ;
                     
                            btneditar.Enabled = true;
                            btneliminar.Enabled = true;
                            btncancelar.Enabled = true;
                        }

                        else
                        {

                            btncancelar.Enabled = false;
                            btneditar.Enabled = false;


                        }

                    }

                    
               
                }


            }catch(Exception ex)
            {


                show();
            }

        }

        private void datalist_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void datalist_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Menu().Show();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            DialogResult Dialog = MessageBox.Show("Desea Eliminar este Usuario?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (Dialog.Equals(DialogResult.OK))
            {
                Delete();

                btneliminar.Enabled = btneditar.Enabled = false;
                btnguardar.Enabled = true;

                txtidentificador.Text = txtnombre.Text = "";

                btncancelar.Enabled = false;
            }

            else
            {
                btncancelar.Enabled = false;


                show();

                btneliminar.Enabled = btneditar.Enabled = false;
                btnguardar.Enabled = true;

                txtidentificador.Text = txtnombre.Text = "";

            }



        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            show();

            btneliminar.Enabled = btneditar.Enabled = false;
            btnguardar.Enabled = true;

            txtidentificador.Text = txtnombre.Text = "";

            btncancelar.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
               if (txtsearch.Text.Trim() == null)
            {

        

                this.docentesTableAdapter.Fill(this.dataSetConjunt.Docentes);


            }

            else 
            {

                this.searchdocenteTableAdapter.Fill(this.dataSetConjunt.searchdocente, txtsearch.Text);
                datalist.DataSource = DataSearch;
            }



        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
       

        }

        private void bindingSearch_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
