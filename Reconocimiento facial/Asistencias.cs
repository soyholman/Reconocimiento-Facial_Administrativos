using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Reconocimiento_facial
{
    public partial class Asistencias :MetroFramework.Forms.MetroForm
    {
        public Asistencias()
        {
            InitializeComponent();
        }

        private void Asistencias_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetConjunt.report_asit' Puede moverla o quitarla según sea necesario.
            this.dateTimePicker1.Text = DateTime.Now.ToString("dd/MM/yyy");
            this.reportdate.RefreshReport();
            this.reportdate.RefreshReport();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {

         
      
           
            this.report_asitTableAdapter.Fill(this.DataSetConjunt.report_asit,dateTimePicker1.Text.ToString());
            this.reportdate.RefreshReport();
        
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Hide();
                
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
