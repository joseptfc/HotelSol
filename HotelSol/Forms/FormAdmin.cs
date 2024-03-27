using HotelSol.Forms;
using HotelSol.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelSol
{
    public partial class FormAdmin : Form
    {
        public FormAdmin(usuario user)
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FormGestionClientes formGestionClientes = new FormGestionClientes();
            formGestionClientes.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            FormGestionReservas formReservas = new FormGestionReservas();
            formReservas.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            FormFacturas formFacturas = new FormFacturas();
            formFacturas.Show();
        }
        private void button5_Click(object sender, EventArgs e)
        {
           
        }
        private void button6_Click(object sender, EventArgs e)
        {
            FormContabilidad formGestionClientes = new FormContabilidad();
            formGestionClientes.Show();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            FormTarifas formTarifas = new FormTarifas();
            formTarifas.Show();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            FormConsultaHabitaciones formHabitaciones = new FormConsultaHabitaciones();
            formHabitaciones.Show();
        }
        private void button9_Click(object sender, EventArgs e)
        {
           
        }

    }
}
