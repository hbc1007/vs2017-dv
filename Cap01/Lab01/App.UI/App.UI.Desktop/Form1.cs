using App.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace App.UI.Desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = ConfigurationManager.AppSettings["IGV"].ToString();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            clsFactura documento = new clsFactura();
            documento.Total = Convert.ToDecimal(txtTotal.Text);

            documento.Calcular();

            lblTotal.Text = documento.Total.ToString();
            lblIGV.Text = documento.IGV.ToString();
            lblSubTotal.Text = documento.SubTotal.ToString();


            ////EN ESTA FORMA SE MUESTRA EL POLIFORMISMO ENTRE DOCUMENTO Y FACTURA
            //clsDocumento documento = new clsFactura();
            //documento.Total = Convert.ToDecimal(txtTotal.Text);

            //documento.Calcular();

            //lblTotal.Text = documento.Total.ToString();
            //lblIGV.Text = ((clsFactura)documento).IGV.ToString();
            //lblSubTotal.Text = ((clsFactura)documento).SubTotal.ToString();



            //DELEGADOS: DELEGANDO UN EVENTO
            //clsDocumento documento = new clsFactura();
            //documento.Total = Convert.ToDecimal(txtTotal.Text);

            //documento.onDespuesCalcular+=new Entities.Events.clsListeners.DespuesCalcular(MostrarDatos);
            //documento.Calcular();
        }

        private void MostrarDatos(object obj)
        {
            var documento = (clsFactura)obj;
            lblTotal.Text = documento.Total.ToString();
            lblIGV.Text = ((clsFactura)documento).IGV.ToString();
            lblSubTotal.Text = ((clsFactura)documento).SubTotal.ToString();
        }
    }
}
