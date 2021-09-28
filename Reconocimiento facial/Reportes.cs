using System;
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
    public partial class Reportes : MetroFramework.Forms.MetroForm
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetConjunt.Count_entries' Puede moverla o quitarla según sea necesario.
        
            // TODO: esta línea de código carga datos en la tabla 'DataSetConjunt.report_impuntuales' Puede moverla o quitarla según sea necesario.

            // TODO: esta línea de código carga datos en la tabla 'DataSetConjunt.report_impuntuales_Porcent' Puede moverla o quitarla según sea necesario.

            // TODO: esta línea de código carga datos en la tabla 'DataSetConjunt.report_Puntuales' Puede moverla o quitarla según sea necesario.


            this.dateTimePicker2.Text = DateTime.Now.ToString("dd/MM/yyy");
            this.dateTimePicker1.Text = DateTime.Now.ToString("dd/MM/yyy");


            this.dateimp1.Text = DateTime.Now.ToString("dd/MM/yyy");
            this.dateimp2.Text = DateTime.Now.ToString("dd/MM/yyy");

            this.dateimpp1.Text = DateTime.Now.ToString("dd/MM/yyy");
            this.dateimpp2.Text = DateTime.Now.ToString("dd/MM/yyy");

            this.DatePickerR1.Text = DateTime.Now.ToString("dd/MM/yyy");
            this.DatepickerR2.Text = DateTime.Now.ToString("dd/MM/yyy");

            this.datepickerRR1.Text = DateTime.Now.ToString("dd/MM/yyy");
            this.datepickerRR2.Text = DateTime.Now.ToString("dd/MM/yyy");
            // TODO: esta línea de código carga datos en la tabla 'DataSetConjunt.report_Puntuales_Porcent' Puede moverla o quitarla según sea necesario.

            this.R1.RefreshReport();
            this.R2.RefreshReport();

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btngenerarR1_Click(object sender, EventArgs e)
        {
            this.report_Puntuales_PorcentTableAdapter.Fill(this.DataSetConjunt.report_Puntuales_Porcent,DatePickerR1.Text.ToString(),DatepickerR2.Text.ToString());
            this.R1.RefreshReport();
        }

        private void btngenerateR2_Click(object sender, EventArgs e)
        {
            this.report_PuntualesTableAdapter.Fill(this.DataSetConjunt.report_Puntuales,datepickerRR1.Text.ToString(),datepickerRR2.Text.ToString());
            this.R2.RefreshReport();
        }

        private void generateimp1_Click(object sender, EventArgs e)
        {
            this.report_impuntuales_PorcentTableAdapter.Fill(this.DataSetConjunt.report_impuntuales_Porcent,dateimp1.Text.ToString(),dateimp2.Text.ToString());
            this.reportimp1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.report_impuntualesTableAdapter.Fill(this.DataSetConjunt.report_impuntuales, dateimpp1.Text.ToString(),dateimpp2.Text.ToString());
            this.reportdetailimp.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Count_entriesTableAdapter.Fill(this.DataSetConjunt.Count_entries, dateTimePicker2.Text.ToString(), dateTimePicker1.Text.ToString());
            this.reportViewer1.RefreshReport();
        }
    }
}
